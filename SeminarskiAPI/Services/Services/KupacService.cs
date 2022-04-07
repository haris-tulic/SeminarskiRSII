using AutoMapper;
using eAutobusModel;
using eAutobusModel.Requests;
using Microsoft.EntityFrameworkCore;
using SeminarskiWebAPI.Database;
using SeminarskiWebAPI.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;


namespace SeminarskiWebAPI.Services
{
    public class KupacService : IKupacService
    {
        
        private readonly Database.eAutobusi _context;
        private readonly IMapper _mapper;
        private readonly IKorisnikService _korisnik;
        private readonly IKartaKupacService _kartaKupac;
        public KupacService(Database.eAutobusi context, IMapper mapper, IKorisnikService korisnik, IKartaKupacService kartaKupac = null)
        {
            _context = context;
            _mapper = mapper;
            _korisnik = korisnik;
            _kartaKupac = kartaKupac;
        }

        public eAutobusModel.KupacModel Delete(int id)
        {
            var entity = _context.Kupac.Find(id);
            _context.Kupac.Remove(entity);
            _context.SaveChanges();
            return _mapper.Map<eAutobusModel.KupacModel>(entity);
        }

        public List<eAutobusModel.KupacModel> Get(KupacGetRequest request)
        {
            var query = _context.Kupac.Include(k=>k.KartaList).Include(k=>k.Recenzija).AsQueryable();
            if (!string.IsNullOrWhiteSpace(request.Ime))
            {
                query = query.Where(k => k.Ime.StartsWith(request.Ime));
            }
            if (!string.IsNullOrWhiteSpace(request.Prezime))
            {
                query = query.Where(k => k.Prezime.StartsWith(request.Prezime));
            }
            if (!string.IsNullOrWhiteSpace(request.UserName))
            {
                query = query.Where(k => k.KorisnickoIme == request.UserName);
            }

            var list = query.ToList();
            var listM = new List<KupacModel>();
            _mapper.Map(list, listM);
            if (list.Count()==1)
            {
                var search = new KartaKupacGetRequest();
                foreach (var item in list)
                {
                    search.KupacID = item.KupacID;
                }
                List<KartaKupacModel> listaKarata = _kartaKupac.Get(search);
                for (int i = 0; i < listM.Count; i++)
                {
                    listM[i].KartaKupacs = listaKarata;
                }
            }
            return listM;
        }

        public eAutobusModel.KupacModel GetByID(int id)
        {
            var entity = _context.Kupac.Include(k=>k.KartaList).Include(k=>k.PlaceneKarte).Where(k=>k.KupacID==id).FirstOrDefault();
            return _mapper.Map<eAutobusModel.KupacModel>(entity);
        }


        public eAutobusModel.KupacModel Insert(KupacInsertRequest request)
        {
          
            var entity = _mapper.Map<Database.Kupac>(request);
            if (!string.IsNullOrEmpty(request.KorisnickoIme) && request.Password==request.PotrvrdaPassworda)
            {
                //entity.KorisnickoIme = entity.Ime.ToLower() + "." + entity.Prezime.ToLower();
                //request.Password = entity.Ime.ToLower() + "" + entity.Prezime.ToLower() + "123";
                entity.LozinkaSalt = GenerateSalt();
                entity.LozinkaHash = GenerateHash(entity.LozinkaSalt, request.Password);
            }
            var pronadji = PronadjiKupca(request);
            if (pronadji!=null)
            {
                Update(request,pronadji.KupacID);
            }
            else
            {
                _context.Kupac.Add(entity);
                _context.SaveChanges();
            }
           
            return _mapper.Map<eAutobusModel.KupacModel>(entity);

          
        }

        public eAutobusModel.KupacModel Update(KupacInsertRequest request,int id)
        {
            var entity = _context.Kupac.Find(id);
            _mapper.Map(request, entity);
            if (!string.IsNullOrEmpty(entity.KorisnickoIme) && request.Password == request.PotrvrdaPassworda)
            {
                //entity.KorisnickoIme = entity.Ime.ToLower() + "." + entity.Prezime.ToLower();
                //request.Password = entity.Ime.ToLower() + "" + entity.Prezime.ToLower() + "123";
                entity.LozinkaSalt = GenerateSalt();
                entity.LozinkaHash = GenerateHash(entity.LozinkaSalt, request.Password);
            }
            _context.Kupac.Update(entity);
            _context.SaveChanges();
            return _mapper.Map<eAutobusModel.KupacModel>(entity);


        }

        public static string GenerateSalt()
        {
            var buf = new byte[16];
            (new RNGCryptoServiceProvider()).GetBytes(buf);
            return Convert.ToBase64String(buf);
        }

        public static string GenerateHash(string salt, string password)
        {
            byte[] src = Convert.FromBase64String(salt);
            byte[] bytes = Encoding.Unicode.GetBytes(password);
            byte[] dst = new byte[src.Length + bytes.Length];

            System.Buffer.BlockCopy(src, 0, dst, 0, src.Length);
            System.Buffer.BlockCopy(bytes, 0, dst, src.Length, bytes.Length);

            HashAlgorithm algorithm = HashAlgorithm.Create("SHA1");
            byte[] inArray = algorithm.ComputeHash(dst);
            return Convert.ToBase64String(inArray);

        }
        public Kupac PronadjiKupca(KupacInsertRequest kupac)
        {
            var pronadji = _context.Kupac.Where(k => k.Ime == kupac.Ime && k.Prezime == kupac.Prezime  && k.BrojTelefona == kupac.BrojTelefona && k.KorisnickoIme==kupac.KorisnickoIme)
                .Include(x=>x.KartaList).Include(x=>x.PlaceneKarte).Include(x=>x.Recenzija)
                .Include("KartaList.Karta").Include("PlaceneKarte.Karta").FirstOrDefault();
            if (pronadji!=null)
            {
                return pronadji;
            }
            return null;
        }

    }
}

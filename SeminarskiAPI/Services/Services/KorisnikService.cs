using AutoMapper;
using eAutobusModel;
using eAutobusModel.Requests;
using Microsoft.EntityFrameworkCore;
using SeminarskiWebAPI.Database;
using SeminarskiWebAPI.Exceptions;
using SeminarskiWebAPI.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SeminarskiWebAPI.Services.Services
{
    public class KorisnikService : IKorisnikService
    {
        private readonly eAutobus _context;
        private readonly IMapper _mapper;
        private readonly IUlogeService _uloga;
        private readonly IVozacService _vozac;

        public KorisnikService(eAutobus context, IMapper mapper, IUlogeService uloga, IVozacService vozac)
        {
            _context = context;
            _mapper = mapper;
            _uloga = uloga;
            _vozac = vozac;
        }

        public List<KorisnikModel> Get(KorisnikGetRequest search)
        {
            var query = _context.Korisnik.Include(x=>x.Uloge).AsQueryable();
            if (search.UlogaID.ToString()!="0" && !string.IsNullOrWhiteSpace(search.UlogaID.ToString()))
            {
                query = query.Where(k=>k.UlogeID==search.UlogaID);
            }
            if (!string.IsNullOrWhiteSpace(search.Ime))
            {
                query = query.Where(k => k.Ime.StartsWith(search.Ime));
            }
            if (!string.IsNullOrWhiteSpace(search.Prezime))
            {
                query = query.Where(k => k.Prezime.StartsWith(search.Prezime));
            }
            var list = query.ToList();
            var listM = _mapper.Map<List<KorisnikModel>>(list);
            for (int i = 0; i < list.Count(); i++)
            {
                listM[i].Uloge = list[i].Uloge.Naziv;
            }
            return listM;
        }
              
        public KorisnikModel GetByID(int id)
        {
            var entity = _context.Korisnik.Find(id);
            return _mapper.Map<KorisnikModel>(entity);
        }

        public async Task<KorisnikModel> Insert(KorisnikUpsertRequest request)
        {
            if (request.Password!=request.PasswordPotrvda)
            {
                throw new Exception("Passwordi se ne slažu!");
            }
            var entity = _mapper.Map<Korisnik>(request);
            entity.LozinkaSalt = GenerateSalt();
            entity.LozinkaHash = GenerateHash(entity.LozinkaSalt, request.Password);
            _context.Korisnik.Add(entity);
            await _context.SaveChangesAsync();
            var uloga = await _uloga.GetById(request.UlogeID);
            if (uloga.Naziv=="Vozač" || uloga.Naziv=="Kondukter")
            {
                var vozac = new VozacUpsertRequest()
                {
                    KorisnikID = entity.KorisnikID,
                    VozackaKategorija = "B" + ", " + "C" + ", " + "D",
                    
                };
                _vozac.Insert(vozac);
            }
            return _mapper.Map<KorisnikModel>(entity);
        }

        public KorisnikModel Delete(int id)
        {
            var entity = _context.Korisnik.Find(id);
            _context.Korisnik.Remove(entity);
            _context.SaveChanges();
            return _mapper.Map<KorisnikModel>(entity);
        }

        public KorisnikModel Update(KorisnikUpsertRequest request, int id)
        {
            var entity = _context.Korisnik.Find(id);
            _mapper.Map(request, entity);
            if (!string.IsNullOrEmpty(request.Password))
            {
                if (request.Password == request.PasswordPotrvda)
                {
                    entity.LozinkaSalt = GenerateSalt();
                    entity.LozinkaHash = GenerateHash(entity.LozinkaSalt, request.Password);

                }
                else
                {
                    throw new Exception("Nemoguće izmijeniti password!");
                }
            }
            
            _context.SaveChanges();
            return _mapper.Map<KorisnikModel>(entity);
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
            System.Buffer.BlockCopy(bytes, 0, dst,src.Length, bytes.Length);

            HashAlgorithm algorithm = HashAlgorithm.Create("SHA1");
            byte[] inArray = algorithm.ComputeHash(dst);
            return Convert.ToBase64String(inArray);

        }

      
    }
}

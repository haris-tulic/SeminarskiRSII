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
        
        private readonly eAutobus _context;
        private readonly IMapper _mapper;
        private readonly IKorisnikService _korisnik;
        public KupacService(eAutobus context,IMapper mapper, IKorisnikService korisnik)
        {
            _context = context;
            _mapper = mapper;
            _korisnik = korisnik;
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
            var query = _context.Kupac.AsQueryable();
            if (!string.IsNullOrWhiteSpace(request.Ime))
            {
                query = query.Where(k => k.Ime.StartsWith(request.Ime));
            }
            if (!string.IsNullOrWhiteSpace(request.Prezime))
            {
                query = query.Where(k => k.Prezime.StartsWith(request.Prezime));
            }
            var list = query.ToList();
           
            return _mapper.Map<List<KupacModel>>(list);
        }

        public eAutobusModel.KupacModel GetByID(int id)
        {
            var entity = _context.Kupac.Find(id);
            return _mapper.Map<eAutobusModel.KupacModel>(entity);
        }


        public eAutobusModel.KupacModel Insert(KupacInsertRequest request)
        {
          
            var entity = _mapper.Map<Database.Kupac>(request);
            entity.LozinkaSalt=GenerateSalt();
            entity.LozinkaHash = GenerateHash(entity.LozinkaSalt, request.Password);
            _context.Kupac.Add(entity);
            _context.SaveChanges();
            return _mapper.Map<eAutobusModel.KupacModel>(entity);

          
        }

        public eAutobusModel.KupacModel Update(KupacInsertRequest request,int id)
        {
            var entity = _context.Kupac.Find(id);
            _mapper.Map(request, entity);
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
    }
}

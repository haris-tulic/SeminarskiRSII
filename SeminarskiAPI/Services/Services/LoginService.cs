using AutoMapper;
using eAutobusModel;
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
    public class LoginService : ILoginService
    {
        private readonly eAutobus _context;
        private readonly IMapper _mapper;

        public LoginService(IMapper mapper, eAutobus context)
        {
            _mapper = mapper;
            _context = context;
        }

        public async Task<KorisnikModel> Autentificiraj(string userName, string password)
        {
            var entity = await  _context.Korisnik.Include(x => x.Uloge).FirstOrDefaultAsync(u => u.KorisnickoIme == userName);
            if (entity == null)
            {
                throw new UserException("Pogresan username ili password");
            }

            var hash = GenerateHash(entity.LozinkaSalt, password);
            if (hash != entity.LozinkaHash)
            {
                throw new UserException("Pogresan username ili password");
            }

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
            System.Buffer.BlockCopy(bytes, 0, dst, src.Length, bytes.Length);

            HashAlgorithm algorithm = HashAlgorithm.Create("SHA1");
            byte[] inArray = algorithm.ComputeHash(dst);
            return Convert.ToBase64String(inArray);
        }
    }
}

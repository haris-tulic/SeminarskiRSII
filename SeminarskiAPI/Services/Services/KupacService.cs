using AutoMapper;
using eAutobusModel;
using eAutobusModel.Requests;
using SeminarskiWebAPI.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace SeminarskiWebAPI.Services
{
    public class KupacService : IKupacService
    {
        
        private readonly eAutobus _context;
        private readonly IMapper _mapper;

        public KupacService(eAutobus context,IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
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
            var lista = query.ToList();
            return _mapper.Map<List<eAutobusModel.KupacModel>>(lista);
        }

        public eAutobusModel.KupacModel GetByID(int id)
        {
            var entity = _context.Kupac.Find(id);
            return _mapper.Map<eAutobusModel.KupacModel>(entity);
        }

        public eAutobusModel.KupacModel Insert(KupacInsertRequest request)
        {
            var entity = _mapper.Map<Database.Kupac>(request);
            //if (request.Password!=request.ConfirmPassword)
            //{
            //    throw new Exception("Passwordi nisu isti!");
            //}
            //entity.PasswordSalt = GenerisiSalt();
            //entity.PasswordHash = GenerisiHash();
            _context.Kupac.Add(entity);
            _context.SaveChanges();
            
            _context.SaveChanges();
            return _mapper.Map<eAutobusModel.KupacModel>(entity);

          
        }

        public eAutobusModel.KupacModel Update(KupacInsertRequest request,int id)
        {
            var entity = _context.Kupac.Find(id);
            _context.Kupac.Attach(entity);
            _context.Kupac.Update(entity);
            if (!string.IsNullOrWhiteSpace(request.Password))
            {
                if (request.Password!=request.ConfirmPassword)
                {
                    throw new Exception("Passwordi nisu isti!");
                }
                //entity.PasswordSalt = GenerisiSalt();
                //entity.PasswordHash = GenerisiHash();
            }
            _mapper.Map(request, entity);
            _context.SaveChanges();
            return _mapper.Map<eAutobusModel.KupacModel>(entity);


        }
    }
}

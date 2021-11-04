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
    public class UpravaService : IUpravaService
    {
        private readonly eAutobus _context;
        private readonly IMapper _mapper;
        public UpravaService(eAutobus context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public eAutobusModel.UpravaModel Delete(int id)
        {
            var entity = _context.Uprava.Find(id);
            _context.Uprava.Remove(entity);
            _context.SaveChanges();
            return _mapper.Map<eAutobusModel.UpravaModel>(entity);
        }

        public List<eAutobusModel.UpravaModel> Get(UpravaGetRequest request)
        {
            var query = _context.Uprava.AsQueryable();
           
            var lista = query.ToList();
            return _mapper.Map<List<eAutobusModel.UpravaModel>>(lista);
        }

        public eAutobusModel.UpravaModel GetByID(int id)
        {
            var entity = _context.Uprava.Find(id);
            return _mapper.Map<eAutobusModel.UpravaModel>(entity);
        }

        public eAutobusModel.UpravaModel Insert(UpravaUpsertRequest request)
        {
            var entity = _mapper.Map<Database.Uprava>(request);
            //if (request.Password!=request.ConfirmPassword)
            //{
            //    throw new Exception("Passwordi nisu isti!");
            //}
            //entity.PasswordSalt = GenerisiSalt();
            //entity.PasswordHash = GenerisiHash();
            _context.Uprava.Add(entity);
            _context.SaveChanges();
            _context.SaveChanges();
            return _mapper.Map<eAutobusModel.UpravaModel>(entity);
        }

        public eAutobusModel.UpravaModel Update(UpravaUpsertRequest request, int id)
        {
            var entity = _context.Uprava.Find(id);
            _context.Uprava.Attach(entity);
            _context.Uprava.Update(entity);
            if (!string.IsNullOrWhiteSpace(request.Password))
            {
                if (request.Password != request.ConfirmPassword)
                {
                    throw new Exception("Passwordi nisu isti!");
                }
                //entity.PasswordSalt = GenerisiSalt();
                //entity.PasswordHash = GenerisiHash();
            }
            _mapper.Map(request, entity);
            _context.SaveChanges();
            return _mapper.Map<eAutobusModel.UpravaModel>(entity);
        }
    }
}

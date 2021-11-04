using AutoMapper;
using eAutobusModel;
using eAutobusModel.Requests;
using Microsoft.EntityFrameworkCore;
using SeminarskiWebAPI.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SeminarskiWebAPI.Services
{
    public class AutobusService : IAutobusService
    {
        private readonly eAutobus _context;
        private readonly IMapper _mapper;

        public AutobusService(eAutobus context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public eAutobusModel.AutobusiModel Delete(int id)
        {
            var entity = _context.Autobus.Find(id);
            _context.Autobus.Remove(entity);
            _context.SaveChanges();
            return _mapper.Map<eAutobusModel.AutobusiModel>(entity);
        }

        public List<eAutobusModel.AutobusiModel> Get(AutobusGetRequest request)
        {
            var query = _context.Autobus.Include(a=>a.Garaza).AsQueryable();
            if (!string.IsNullOrEmpty(request.Marka))
            {
                query = query.Where(x => x.MarkaAutobusa.StartsWith(request.Marka));
                
            }
            var lista = query.ToList();
            var entityl = new List<AutobusiModel>();
            _mapper.Map(lista, entityl);
            for (int i = 0; i < lista.Count; i++)
            {
                entityl[i].NazivGaraze = lista[i].Garaza.NazivGaraze;
            }
            return entityl;
        }

        public eAutobusModel.AutobusiModel Insert(AutobusInsertRequest request)
        {
            var entity = _mapper.Map<Database.Autobus>(request);
            _context.Autobus.Add(entity);
            _context.SaveChanges();
            return _mapper.Map<eAutobusModel.AutobusiModel>(entity);
        }

        public eAutobusModel.AutobusiModel Update(AutobusInsertRequest request, int id)
        {
            var entity = _context.Autobus.Find(id);
            _mapper.Map(request, entity);
            _context.SaveChanges();
            return _mapper.Map<eAutobusModel.AutobusiModel>(entity);
        }
    }
}

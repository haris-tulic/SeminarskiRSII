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
    public class ZonaService : IZonaService
    {
        private readonly eAutobus _context;
        private readonly IMapper _mapper;
        public ZonaService(eAutobus context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public eAutobusModel.ZonaModel Delete(int id)
        {
            var entity = _context.Zona.Find(id);
            _context.Zona.Remove(entity);
            _context.SaveChanges();
            return _mapper.Map<eAutobusModel.ZonaModel>(entity);
        }

        public List<eAutobusModel.ZonaModel> Get()
        {
            var list = _context.Zona.ToList();
            return _mapper.Map<List<eAutobusModel.ZonaModel>>(list);
        }

        public eAutobusModel.ZonaModel GetById(int id)
        {
            var entity = _context.Zona.Find(id);
            return _mapper.Map<eAutobusModel.ZonaModel>(entity);
        }

        public eAutobusModel.ZonaModel Insert(ZonaInsertRequest request)
        {
            var entity = _mapper.Map<Database.Zona>(request);
            _context.Zona.Add(entity);
            _context.SaveChanges();
            return _mapper.Map<eAutobusModel.ZonaModel>(entity);
        }
    }
}

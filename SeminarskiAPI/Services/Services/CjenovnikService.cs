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
    public class CjenovnikService : ICjenovnikService
    {
        private readonly eAutobus _context;
        private readonly IMapper _mapper;
        public CjenovnikService(eAutobus context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public eAutobusModel.CjenovnikModel Delete(int id)
        {
            var entity = _context.Cjenovnik.Find(id);
            _context.Cjenovnik.Remove(entity);
            _context.SaveChanges();
            return _mapper.Map<eAutobusModel.CjenovnikModel>(entity);
        }

        public List<eAutobusModel.CjenovnikModel> Get(CjenovnikSearchRequest request)
        {
            var query = _context.Cjenovnik.Include(t => t.Tipkarte).Include(v => v.VrstaKarte).AsQueryable();
            if (!string.IsNullOrWhiteSpace(request?.Tipkarte))
            {
                query = query.Where(x => x.Tipkarte.Naziv.StartsWith(request.Tipkarte));
            }
            if (!string.IsNullOrWhiteSpace(request?.Zona))
            {
                query = query.Where(y => y.Zona.OznakaZone.StartsWith(request.Zona));
            }
            var list = query.ToList();
            return _mapper.Map<List<eAutobusModel.CjenovnikModel>>(list);
        }

        public eAutobusModel.CjenovnikModel GetByID(int id)
        {
            var entity = _context.Cjenovnik.Find(id);
            return _mapper.Map<eAutobusModel.CjenovnikModel>(entity);
        }

        public eAutobusModel.CjenovnikModel Insert(CjenovnikInsertRequest request)
        {
            var entity = _mapper.Map<Database.Cjenovnik>(request);
            _context.Cjenovnik.Add(entity);
            _context.SaveChanges();
            return _mapper.Map<eAutobusModel.CjenovnikModel>(entity);
        }

        public eAutobusModel.CjenovnikModel Update(CjenovnikInsertRequest request, int id)
        {
            var entity = _context.Cjenovnik.Find(id);
            _mapper.Map(request, entity);
            _context.SaveChanges();
            return _mapper.Map<eAutobusModel.CjenovnikModel>(entity);
        }
    }
}

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
    public class AutobusVozacService : IAutobusVozacService
    {
        private readonly eAutobus _context;
        private readonly IMapper _mapper;
        public AutobusVozacService(eAutobus context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public eAutobusModel.AutobusVozacModel Delete(int id)
        {
            var entity = _context.AutobusVozac.Find(id);
            _context.AutobusVozac.Remove(entity);
            _context.SaveChanges();
            return _mapper.Map<eAutobusModel.AutobusVozacModel>(entity);
        }

        public List<eAutobusModel.AutobusVozacModel> Get(AutobusVozacGetRequest request)
        {
            var query = _context.AutobusVozac.Include(a => a.Autobus).Include(v => v.Vozac).AsQueryable();
            return _mapper.Map<List<eAutobusModel.AutobusVozacModel>>(query);
        }

        public eAutobusModel.AutobusVozacModel GetByID(int id)
        {
            var obj = _context.AutobusVozac.Find(id);
            return _mapper.Map<eAutobusModel.AutobusVozacModel>(obj);

        }

        public eAutobusModel.AutobusVozacModel Insert(AutobusVozacUpsertRequest request)
        {
            var entity = _mapper.Map<Database.AutobusVozac>(request);
            _context.AutobusVozac.Add(entity);
            _context.SaveChanges();
            return _mapper.Map<eAutobusModel.AutobusVozacModel>(entity);
        }

        public eAutobusModel.AutobusVozacModel Update(AutobusVozacUpsertRequest request, int id)
        {
            var entity = _context.AutobusVozac.Find(id);
            _mapper.Map(request, entity);
            _context.SaveChanges();
            return _mapper.Map<eAutobusModel.AutobusVozacModel>(entity);

        }
    }
}

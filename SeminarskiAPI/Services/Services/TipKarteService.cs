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
    public class TipKarteService : ITipKarteService
    {
        private readonly eAutobus _context;
        private readonly IMapper _mapper;
        public TipKarteService(eAutobus context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public eAutobusModel.TipKarteModel Delete(int id)
        {
            var entity = _context.TipKarte.Find(id);
            _context.TipKarte.Remove(entity);
            _context.SaveChanges();
            return _mapper.Map<eAutobusModel.TipKarteModel>(entity);
        }

        public List<eAutobusModel.TipKarteModel> Get()
        {
            var list = _context.TipKarte.ToList();
            return _mapper.Map<List<eAutobusModel.TipKarteModel>>(list);
        }

        public eAutobusModel.TipKarteModel GetById(int id)
        {
            var entity = _context.TipKarte.Find(id);
            return _mapper.Map<eAutobusModel.TipKarteModel>(entity);
        }

        public eAutobusModel.TipKarteModel Insert(TipKarteInsertRequest request)
        {
            var entity = _mapper.Map<Database.TipKarte>(request);
            _context.TipKarte.Add(entity);
            _context.SaveChanges();
            return _mapper.Map<eAutobusModel.TipKarteModel>(entity);
        }
    }
}

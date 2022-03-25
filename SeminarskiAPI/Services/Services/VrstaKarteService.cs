using AutoMapper;
using eAutobusModel.Requests;
using SeminarskiWebAPI.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SeminarskiWebAPI.Services
{
    public class VrstaKarteService:IVrstaKarteService
    {
        private readonly Database.eAutobusi _context;
        private readonly IMapper _mapper;
        public VrstaKarteService (Database.eAutobusi context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public eAutobusModel.VrstaKarteModel Delete(int id)
        {
            var entity = _context.VrstaKarte.Find(id);
            _context.VrstaKarte.Remove(entity);
            _context.SaveChanges();
            return _mapper.Map<eAutobusModel.VrstaKarteModel>(entity);
        }

        public List<eAutobusModel.VrstaKarteModel> Get()
        {
            var lista = _context.VrstaKarte.ToList();
            return _mapper.Map<List<eAutobusModel.VrstaKarteModel>>(lista);
        }

        public eAutobusModel.VrstaKarteModel GetById(int id)
        {
            var entity = _context.VrstaKarte.Find(id);
            return _mapper.Map<eAutobusModel.VrstaKarteModel>(entity);
        }

        public eAutobusModel.VrstaKarteModel Insert(VrstaKarteInsertRequest request)
        {
            var entity = _mapper.Map<Database.VrstaKarte>(request);
            _context.VrstaKarte.Add(entity);
            _context.SaveChanges();
            return _mapper.Map<eAutobusModel.VrstaKarteModel>(entity);
        }
    }
}

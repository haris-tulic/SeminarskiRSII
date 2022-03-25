using AutoMapper;
using eAutobusModel;
using eAutobusModel.Requests;
using SeminarskiWebAPI.Database;
using SeminarskiWebAPI.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace SeminarskiWebAPI.Services
{
    public class GarazaService : IGarazaService
    {
        private readonly eAutobusi _context;
        private readonly IMapper _mapper;
        public GarazaService(Database.eAutobusi context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public List<eAutobusModel.GarazaModel> Get()
        {
            var list = _context.Garaza.ToList();
            return _mapper.Map<List<eAutobusModel.GarazaModel>>(list);
        }

        public eAutobusModel.GarazaModel GetByID(int id)
        {
            var entity = _context.Garaza.Where(i=>i.GarazaID==id).FirstOrDefault();
            return _mapper.Map<eAutobusModel.GarazaModel>(entity);
        }

        public eAutobusModel.GarazaModel Insert(GarazaUpsertRequest request)
        {
            var entity = _mapper.Map<Database.Garaza>(request);
            _context.Garaza.Add(entity);
            _context.SaveChanges();
            return _mapper.Map<eAutobusModel.GarazaModel>(entity);
        }

        public eAutobusModel.GarazaModel Update(GarazaUpsertRequest update, int id)
        {
            var entity = _context.Garaza.Where(i => i.GarazaID == id).FirstOrDefault();
            _mapper.Map(update, entity);
            _context.SaveChanges();
            return _mapper.Map<eAutobusModel.GarazaModel>(entity);
        }

        public GarazaModel Delete(int id)
        {
            var entity = _context.Garaza.Find(id);
            _context.Garaza.Remove(entity);
            _context.SaveChanges();
            return _mapper.Map<GarazaModel>(entity);
        }
        public bool IsPopunjeno(int GarazaID)
        {
            var entity = _context.Garaza.Find(GarazaID);
            if (entity.IsPopunjeno==true || entity.TrenutnoAutobusa>=entity.BrojMjesta)
            {
                entity.IsPopunjeno = true;
                return entity.IsPopunjeno;
            }
            else
            {
                return entity.IsPopunjeno;
            }
        }
    }
}

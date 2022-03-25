using AutoMapper;
using eAutobusModel;
using eAutobusModel.Requests;
using Microsoft.EntityFrameworkCore;
using SeminarskiWebAPI.Database;
using SeminarskiWebAPI.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SeminarskiWebAPI.Services
{
    public class AutobusService : IAutobusService
    {
        private readonly eAutobusi _context;
        private readonly IMapper _mapper;
        private readonly IGarazaService _garaza;

        public AutobusService(eAutobusi context, IMapper mapper, IGarazaService garaza)
        {
            _context = context;
            _mapper = mapper;
            _garaza = garaza;
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
            for (int i = 0; i < lista.Count(); i++)
            {
                entityl[i].NazivGaraze = lista[i].Garaza.NazivGaraze;
            }
            return entityl;
        }

        public async Task<AutobusiModel> GetById(int id)
        {
            var entity =await _context.Autobus.FindAsync(id);
            return _mapper.Map<AutobusiModel>(entity);
        }

        public eAutobusModel.AutobusiModel Insert(AutobusInsertRequest request)
        {
            var entity = _mapper.Map<Database.Autobus>(request);
            var garaza = _garaza.GetByID(request.GarazaID);
            var IsPopunjeno = garaza.IsPopunjeno;
            if (!IsPopunjeno)
            {
                _context.Autobus.Add(entity);
                _context.SaveChanges();
                garaza.TrenutnoAutobusa++;
                return _mapper.Map<eAutobusModel.AutobusiModel>(entity);
            }
            else
            {
                throw new Exception("Garaža je popunjena!");
            }
           
        }

        public bool Popunjeno(int GarazaId)
        {
            return _garaza.IsPopunjeno(GarazaId);
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

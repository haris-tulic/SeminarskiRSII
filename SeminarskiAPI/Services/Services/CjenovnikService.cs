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
        private readonly Database.eAutobusi _context;
        private readonly IMapper _mapper;
        public CjenovnikService(Database.eAutobusi context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public CjenovnikModel Delete(int id)
        {
            var entity = _context.Cjenovnik.Find(id);
            //_context.Cjenovnik.Remove(entity);
            entity.IsDeleted = true;
            _context.SaveChanges();
            return _mapper.Map<eAutobusModel.CjenovnikModel>(entity);
        }

        public List<CjenovnikModel> Get(CjenovnikSearchRequest request)
        {
            var query = _context.Cjenovnik.Include(t => t.Tipkarte)
                .Include(v => v.VrstaKarte)
                .Include(z=>z.Zona)
                .Include(p=>p.Polaziste)
                .Include(o=>o.Odrediste)
                .Where(c=>c.IsDeleted==false).AsQueryable();
            if (request.TipkarteID.ToString()!="0")
            {
                query = query.Where(x => x.TipkarteID==request.TipkarteID);
            }
            if (request.ZonaID.ToString()!="0")
            {
                query = query.Where(y =>y.ZonaID==request.ZonaID);
            }

            if (request.VrstaKarteID.ToString()!="0")
            {
                query = query.Where(c => c.VrstaKarteID == request.VrstaKarteID);
            }
            if (request.PolazisteID.ToString()!="0")
            {
                query = query.Where(p => p.PolazisteID == request.PolazisteID);
            }
            if (request.OdredisteID.ToString()!="0")
            {
                query = query.Where(o => o.OdredisteID == request.OdredisteID);
            }
            var list = query.ToList();
            var listC = new List<CjenovnikModel>();
            _mapper.Map(list,listC);
            for (int i = 0; i < list.Count(); i++)
            {
                listC[i].Tipkarte = list[i].Tipkarte.Naziv;
                listC[i].VrstaKarte = list[i].VrstaKarte.Naziv;
                listC[i].Zona = list[i].Zona.OznakaZone;
                listC[i].Odrediste = list[i].Odrediste.NazivLokacijeStanice;
                listC[i].Polaziste = list[i].Polaziste.NazivLokacijeStanice;
                
            }
            return listC;
        }
        public CjenovnikModel GetCijena(CjenovnikSearchRequest cijena)
        {
            var entity = _context.Cjenovnik.Where(x=>x.TipkarteID== cijena.TipkarteID && x.VrstaKarteID== cijena.VrstaKarteID).FirstOrDefault();

            return _mapper.Map <CjenovnikModel>(entity);

        }
        public CjenovnikModel GetByID(int id)
        {
            var entity = _context.Cjenovnik.Find(id);
            return _mapper.Map<eAutobusModel.CjenovnikModel>(entity);
        }

        public CjenovnikModel Insert(CjenovnikInsertRequest request)
        {
            var entity = _mapper.Map<Database.Cjenovnik>(request);
            _context.Cjenovnik.Add(entity);
            _context.SaveChanges();
            return _mapper.Map<eAutobusModel.CjenovnikModel>(entity);
        }

        public CjenovnikModel Update(int id,CjenovnikInsertRequest request)
        {
            var entity = _context.Cjenovnik.Find(id);
            _mapper.Map(request, entity);
            _context.SaveChanges();
            return _mapper.Map<eAutobusModel.CjenovnikModel>(entity);
        }
    }
}

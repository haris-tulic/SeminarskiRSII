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
    public class RasporedVoznjeService : IRasporedVoznjeService
    {
        private readonly eAutobus _context;
        private readonly IMapper _mapper;
        public RasporedVoznjeService(eAutobus context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public eAutobusModel.RasporedVoznjeModel Delete(int id)
        {
            var entity = _context.RasporedVoznje.Find(id);
            _context.RasporedVoznje.Remove(entity);
            _context.SaveChanges();
            return _mapper.Map<eAutobusModel.RasporedVoznjeModel>(entity);
        }
        public List<eAutobusModel.RasporedVoznjeModel> Get(RasporedVoznjeGetRequest search)
        {
            
            var query = _context.RasporedVoznje.Include(a=>a.Autobus).Include(o=>o.Odrediste).Include(d=>d.Polaziste).Include(v=>v.Vozac).Include(k=>k.Kondukter).AsQueryable();
            if (search.OdredisteID.ToString()!="0")
            {
                query = query.Where(r => r.OdredisteID == search.OdredisteID);
            }
            if (search.PolazisteID.ToString()!="0")
            {
                query = query.Where(r => r.PolazisteID == search.PolazisteID);
            }
            //if (!string.IsNullOrEmpty(search.Datum.ToString()) && search.Datum.Year>1)
            //{
            //    query = query.Where(r => r.Datum == search.Datum);
            //}
            var list = query.ToList();
            var listR = new List<RasporedVoznjeModel>();
            _mapper.Map(list, listR);
            for (int i = 0; i <list.Count; i++)
            {
                listR[i].Odlazak = list[i].Odrediste.NazivLokacijeStanice;
                listR[i].Polazak = list[i].Polaziste.NazivLokacijeStanice;
                listR[i].BrojAutobusa = list[i].Autobus.BrojAutobusa;
            }
            return listR;
        }

        private RasporedVoznjeModel Convert(RasporedVoznje x)
        {
            RasporedVoznjeModel entity = new RasporedVoznjeModel
            {
                Polazak = x.Polaziste.NazivLokacijeStanice,
                Odlazak = x.Odrediste.NazivLokacijeStanice,
                BrojAutobusa = x.Autobus.BrojAutobusa,
                BrojLinije = x.BrojLinije,
                AutobusID = x.AutobusID,
                Datum = x.Datum,
                OdredisteID = x.OdredisteID,
                PolazisteID = x.PolazisteID,
                RasporedVoznjeID = x.RasporedVoznjeID,
                VozacID = x.VozacID,
                VrijemeDolaska = x.VrijemeDolaska,
                VrijemePolaska = x.VrijemePolaska,
                KondukterID = x.KondukterID,
            };
            return entity;
        }

        public eAutobusModel.RasporedVoznjeModel GetById(int id)
        {
            var entity = _context.RasporedVoznje.Find(id);
            return _mapper.Map<eAutobusModel.RasporedVoznjeModel>(entity);
        }

        public eAutobusModel.RasporedVoznjeModel Insert(RasporedVoznjeUpsertRequest request)
        {
            var entity = _mapper.Map<Database.RasporedVoznje>(request);
            _context.RasporedVoznje.Add(entity);
            _context.SaveChanges();
            return _mapper.Map<eAutobusModel.RasporedVoznjeModel>(entity);
        }

        public eAutobusModel.RasporedVoznjeModel Update(RasporedVoznjeUpsertRequest request, int id)
        {
            var update = _context.RasporedVoznje.Find(id);
            _mapper.Map(request, update);
            _context.SaveChanges();
            return _mapper.Map<eAutobusModel.RasporedVoznjeModel>(update);
        }
    }
}

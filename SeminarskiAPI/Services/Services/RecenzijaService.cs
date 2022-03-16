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

namespace SeminarskiWebAPI.Services.Services
{
    public class RecenzijaService : IRecenzijaService
    {
        private readonly eAutobus _context;
        private readonly IMapper _mapper;
        
        public RecenzijaService(eAutobus context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public List<RecenzijaModel> Get(RecenzijaGetRequest search)
        {
            var query = _context.Recenzija.Include(x => x.RasporedVoznje).Include(x=>x.Kupac).Include("RasporedVoznje.Polaziste").Include("RasporedVoznje.Odrediste").AsQueryable();
            if (search.Ocjena>0  && search.Ocjena<=5)
            {
                query = query.Where(x => x.Ocjena == search.Ocjena);
            }
            var list = query.ToList();
            var listM = new List<RecenzijaModel>();
            _mapper.Map(list, listM);
            for (int i = 0; i < list.Count; i++)
            {
                listM[i].RasporedVoznje = list[i].RasporedVoznje.Polaziste.NazivLokacijeStanice + "-" + list[i].RasporedVoznje.Odrediste.NazivLokacijeStanice;
                listM[i].ImePrezimeKupca = list[i].Kupac.Ime + " " + list[i].Kupac.Prezime;
            }
            return listM;
        }

        public RecenzijaModel Insert(RecenzijaUpsertRequest request)
        {
            var entity = _mapper.Map<Recenzija>(request);
           
            _context.Recenzija.Add(entity);
            _context.SaveChanges();
            var pronadji = _context.RasporedVoznje.Include(r => r.Recenzija).Where(v => v.RasporedVoznjeID == request.RasporedVoznjeID).FirstOrDefault();
            if (pronadji.Recenzija!=null)
            {
                decimal ocjena = 0;
                foreach (var recenzija in pronadji.Recenzija)
                {
                    ocjena += recenzija.Ocjena;
                }
                decimal brojOcjena = pronadji.Recenzija.Count();
                pronadji.FinalOcjena = ocjena / brojOcjena;
               
            }
            else
            {
                pronadji.FinalOcjena = request.Ocjena;
            }
            _context.SaveChanges();
            return _mapper.Map<RecenzijaModel>(entity);
        }
    }
}

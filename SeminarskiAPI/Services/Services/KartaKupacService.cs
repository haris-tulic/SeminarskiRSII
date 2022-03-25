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
    public class KartaKupacService : IKartaKupacService
    {
        private readonly Database.eAutobusi _context;
        private readonly IMapper _mapper;
        public KartaKupacService(Database.eAutobusi context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public List<KartaKupacModel> Get(KartaKupacGetRequest search)
        {
            var list = _context.KartaKupac.Include(k=>k.Karta)
                .Include("Karta.Odrediste")
                .Include("Karta.Polaziste")
                .Include(u=>u.Kupac)
                .Include(t=>t.Karta.TipKarte)
                .Include(v=>v.Karta.VrstaKarte)
                .Where(x=>x.KupacID==search.KupacID)
                .ToList();
            var listM = new List<KartaKupacModel>();
            _mapper.Map(list, listM);
            for (int i = 0; i < list.Count; i++)
            {
                listM[i].Karta = list[i].Karta.TipKarte.Naziv+" "+ list[i].Karta.VrstaKarte.Naziv;
                listM[i].Kupac = list[i].Kupac.Ime + " " + list[i].Kupac.Prezime;
                listM[i].Polaziste = list[i].Karta.Polaziste.NazivLokacijeStanice;
                listM[i].Odrediste = list[i].Karta.Odrediste.NazivLokacijeStanice;

            }
            return listM;
        }

        public KartaKupacModel Insert(KartaKupacUpsertRequest request)
        {
            var entity = _mapper.Map<KartaKupac>(request);
            _context.KartaKupac.Add(entity);
            _context.SaveChanges();
            return _mapper.Map<KartaKupacModel>(entity);
        }
    }
}

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
    public class KartaService : IKartaService   
    {
        private readonly eAutobus _context;
        private readonly IMapper _mapper;
        private readonly IKupacService _kupac;
        private readonly IKartaKupacService _kartaKupac;

        public KartaService(eAutobus context, IMapper mapper, IKupacService kupac, IKartaKupacService kartaKupac)
        {
            _context = context;
            _mapper = mapper;
            _kupac = kupac;
            _kartaKupac = kartaKupac;
        }
        public eAutobusModel.KartaModel Delete(int id)
        {
            var entity = _context.Karta.Find(id);
            _context.Karta.Remove(entity);
            _context.SaveChanges();
            return _mapper.Map<KartaModel>(entity);
        }

        public List<KartaModel> Get(KartaGetRequest request)
        {
            var query = _context.Karta.Include(v => v.VrstaKarte)
                                    .Include("KartaKupac.Kupac")
                                    .Include(t => t.TipKarte)
                                    .AsQueryable();
            var list = query.ToList();
            return _mapper.Map<List<KartaModel>>(list);

        }

        public KartaModel GetById(int id)
        {
            var entity = _context.Karta.Find(id);
            return _mapper.Map<KartaModel>(entity);
          
        }

        public KartaModel Insert(KartaUpsertRequest request)
        {
            
            var entity = _mapper.Map<Karta>(request);
            _context.Karta.Add(entity);
            _context.SaveChanges();
            var kupac = new KupacInsertRequest()
            {
                Ime = request.Ime,
                Prezime = request.Prezime,
                AdresaStanovanja = request.AdresaStanovanja,
                BrojTelefona = request.BrojTelefona,
            };

            KupacModel newKupac = _kupac.Insert(kupac);

            var kupacKarta = new KartaKupacUpsertRequest()
            {
                Aktivna = true,
                DatumVadjenjaKarte = request.DatumVadjenjaKarte,
                DatumVazenjaKarte = request.DatumVazenjaKarte,
                KartaID = entity.KartaID,
                KupacID = newKupac.KupacID,
                Pravac = request.Pravac,
                PravacS = request.PravacS,
            };

            KartaKupacModel osobineKarte = _kartaKupac.Insert(kupacKarta);
            
            return _mapper.Map<KartaModel>(entity);
        }

        public KartaModel Update(KartaUpsertRequest request, int id)
        {
            var update = _context.Karta.Find(id);
            _mapper.Map(request, update);
            _context.SaveChanges();
            return _mapper.Map<KartaModel>(update);
        }
    }
}

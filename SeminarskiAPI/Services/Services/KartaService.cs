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
        private readonly IKorisnikService _korisnik;

        public KartaService(eAutobus context,IMapper mapper,IKorisnikService korisnik)
        {
            _context = context;
            _mapper = mapper;
            _korisnik = korisnik;
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
                                    .Include(k => k.Korisnik)
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
            var kupac = new KorisnikUpsertRequest
            {
                Ime = request.Ime,
                Prezime = request.Prezime,
                AdresaStanovanja = request.AdresaStanovanja,
               
                
            };
            KorisnikModel newKupac=_korisnik.Insert(kupac);
            request.KorisnikID = newKupac.KorisnikID;
            var entity = _mapper.Map<Karta>(request);
            _context.Karta.Add(entity);
            _context.SaveChanges();
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

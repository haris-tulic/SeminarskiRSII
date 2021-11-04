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
    public class KorisnikService : IKorisnikService
    {
        private readonly eAutobus _context;
        private readonly IMapper _mapper;

        public KorisnikService(eAutobus context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public List<KorisnikModel> Get(KorisnikGetRequest search)
        {
            var query = _context.Korisnik.Include(x=>x.TipKorisnika).AsQueryable();
            if (search.TipKorisnikaID.ToString()!="0" && !string.IsNullOrWhiteSpace(search.TipKorisnikaID.ToString()))
            {
                query = query.Where(k => k.TipKorisnikaID == search.TipKorisnikaID);
            }
            if (!string.IsNullOrWhiteSpace(search.Ime))
            {
                query = query.Where(k => k.Ime.StartsWith(search.Ime));
            }
            if (!string.IsNullOrWhiteSpace(search.Prezime))
            {
                query = query.Where(k => k.Prezime.StartsWith(search.Prezime));
            }
            var list = query.ToList();
            var listM = _mapper.Map<List<KorisnikModel>>(list);
            for (int i = 0; i < list.Count(); i++)
            {
                listM[i].TipKorisnika = list[i].TipKorisnika.Naziv;
            }
            return listM;
        }
              
        public KorisnikModel GetByID(int id)
        {
            var entity = _context.Korisnik.Find(id);
            return _mapper.Map<KorisnikModel>(entity);
        }

        public KorisnikModel Insert(KorisnikUpsertRequest request)
        {
            var entity = _mapper.Map<Korisnik>(request);
            _context.Korisnik.Add(entity);
            _context.SaveChanges();
            return _mapper.Map<KorisnikModel>(entity);
        }

        public KorisnikModel Delete(int id)
        {
            var entity = _context.Korisnik.Find(id);
            _context.Korisnik.Remove(entity);
            _context.SaveChanges();
            return _mapper.Map<KorisnikModel>(entity);
        }

        public KorisnikModel Update(KorisnikUpsertRequest request, int id)
        {
            var entity = _context.Korisnik.Find(id);
            _mapper.Map(request, entity);
            _context.SaveChanges();
            return _mapper.Map<KorisnikModel>(entity);
        }
    }
}

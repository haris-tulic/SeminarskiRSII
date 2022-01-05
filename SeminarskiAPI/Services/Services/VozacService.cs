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
    public class VozacService:IVozacService
    {
        private readonly eAutobus _context;
        private readonly IMapper _mapper;
        public VozacService (eAutobus context,IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public eAutobusModel.VozacModel Delete(int id)
        {
            var entity = _context.Vozac.Find(id);
            _context.Vozac.Remove(entity);
            _context.SaveChanges();
            return _mapper.Map<eAutobusModel.VozacModel>(entity);
        }

        public List<eAutobusModel.VozacModel> Get(VozacGetRequest request)
        {
            var query = _context.Vozac.Include(v=>v.Korisnik).AsQueryable();
            var list = query.ToList();
            var listM = new List<VozacModel>();
            _mapper.Map(list, listM);
            for (int i = 0; i < list.Count; i++)
            {
                listM[i].Ime = list[i].Korisnik.Ime;
                listM[i].Prezime = list[i].Korisnik.Prezime;
                listM[i].Email = list[i].Korisnik.Email;
                listM[i].DatumRodjenja = list[i].Korisnik.DatumRodjenja;

            }
            return listM;
        }

        public eAutobusModel.VozacModel GetById(int id)
        {
            var entity = _context.Vozac.Find(id);
            return _mapper.Map<eAutobusModel.VozacModel>(entity);
        }

        public eAutobusModel.VozacModel Insert(VozacUpsertRequest request)
        {
            var novi = _mapper.Map<Database.Vozac>(request);
            _context.Vozac.Add(novi);
            _context.SaveChanges();
            return _mapper.Map<eAutobusModel.VozacModel>(novi);
        }

        public eAutobusModel.VozacModel Update(VozacUpsertRequest request, int id)
        {
            var update = _context.Vozac.Find(id);
            _mapper.Map(request, update);
            _context.SaveChanges();
            return _mapper.Map<eAutobusModel.VozacModel>(update);

        }
    }
}

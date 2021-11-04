using AutoMapper;
using eAutobusModel;
using eAutobusModel.Requests;
using SeminarskiWebAPI.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SeminarskiWebAPI.Services
{
    public class TipKorisnikaService : ITipKorisnikaService
    {
        private readonly eAutobus _context;
        private readonly IMapper _mapper;

        public TipKorisnikaService(eAutobus context,IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public eAutobusModel.TipKorisnikaModel Delete(int id)
        {
            var entity = _context.TipKorisnika.Find(id);
            _context.TipKorisnika.Remove(entity);
            _context.SaveChanges();
            return _mapper.Map<eAutobusModel.TipKorisnikaModel>(entity);
        }

        public List<eAutobusModel.TipKorisnikaModel> Get()
        {
            var list = _context.TipKorisnika.ToList();
            return _mapper.Map<List<eAutobusModel.TipKorisnikaModel>>(list);
        }

        public eAutobusModel.TipKorisnikaModel Insert(TipKorisnikaInsertRequest request)
        {
            var search = _context.TipKorisnika.Where(k => k.Naziv == request.Naziv).FirstOrDefault();
            if (search==null)
            {
                var entity = _mapper.Map<TipKorisnika>(request);
                _context.TipKorisnika.Add(entity);
                _context.SaveChanges();
                return _mapper.Map<eAutobusModel.TipKorisnikaModel>(entity);
            }
            return null;
        }
    }
}

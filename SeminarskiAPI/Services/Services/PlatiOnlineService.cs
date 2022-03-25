using AutoMapper;
using eAutobusModel.Requests;
using SeminarskiWebAPI.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SeminarskiWebAPI.Database;
using Microsoft.EntityFrameworkCore;
using eAutobusModel;

namespace SeminarskiWebAPI.Services.Services
{
    public class PlatiOnlineService : IPlatiOnlineService
    {
        private readonly eAutobusi _context;
        private readonly IMapper _mapper;
        public PlatiOnlineService(Database.eAutobusi context,IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public List<PlatiKartuModel> Get(PlatiKartuGetRequest search)
        {
            var query = _context.PlatiKartu.Include(x => x.Kupac).Include(x => x.Karta).AsQueryable();
            var list = query.ToList();
            return _mapper.Map<List<PlatiKartuModel>>(list);
        }

        public PlatiKartuModel GetById(int id)
        {
            var entity = _context.PlatiKartu.Include(x => x.Kupac).Include(x => x.Karta).Where(k=>k.PlatiKartuID==id);
            return _mapper.Map<PlatiKartuModel>(entity);
        }

        public PlatiKartuModel Insert(PlatiKartuUpsertRequest request)
        {
            var entity = _mapper.Map<PlatiKartu>(request);
            _context.PlatiKartu.Add(entity);
            _context.SaveChanges();
            return _mapper.Map<PlatiKartuModel>(entity);
        }

        public PlatiKartuModel Update(PlatiKartuUpsertRequest request,int id)
        {
            var entity = _context.PlatiKartu.Find(id);
            _mapper.Map(request, entity);
            _context.SaveChanges();
            return _mapper.Map<PlatiKartuModel>(entity);
        }
    }
}

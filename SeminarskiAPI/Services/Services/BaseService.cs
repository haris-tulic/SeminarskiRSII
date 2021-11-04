using AutoMapper;
using SeminarskiWebAPI.Database;
using SeminarskiWebAPI.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SeminarskiWebAPI.Services.Services
{
    public class BaseService<TModel, TSearch,TDatabase> : IService<TModel, TSearch> where TDatabase: class
    {
        private readonly eAutobus _context;
        private readonly IMapper _mapper;

        public BaseService(eAutobus context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public List<TModel> Get(TSearch search)
        {
            var list = _context.Set<TDatabase>().ToList();
            return _mapper.Map<List<TModel>>(list);
        }

        public TModel GetByID(int id)
        {
            var entity = _context.Set<TDatabase>().Find(id);
            return _mapper.Map<TModel>(entity); 
        }
    }
}

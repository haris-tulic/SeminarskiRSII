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
    public class UlogeService : IUlogeService
    {
        private readonly eAutobus _context;
        private readonly IMapper _mapper;

        public UlogeService(eAutobus context,IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<UlogeModel> Delete(int id)
        {
            var entity = _context.Uloge.Find(id);
            _context.Uloge.Remove(entity);
            await _context.SaveChangesAsync();
            return _mapper.Map<eAutobusModel.UlogeModel>(entity);
        }

        public async Task<List<UlogeModel>> Get(UlogeGetRequest search)
        {
            
            var query =  _context.Uloge.AsQueryable();
            if (search.UlogeID.ToString() != "0" && !string.IsNullOrWhiteSpace(search.UlogeID.ToString()))
            {
                 query = query.Where(u => u.UlogeID == search.UlogeID);
            }
            var list =  query.ToList();
            return _mapper.Map<List<eAutobusModel.UlogeModel>>(list);
        }

        public async Task<UlogeModel> Insert(UlogeInsertRequest request)
        {
            var search = _context.Uloge.Where(k => k.Naziv == request.Naziv).FirstOrDefault();
            if (search==null)
            {
                var entity = _mapper.Map<Uloge>(request);
                _context.Uloge.Add(entity);
               await _context.SaveChangesAsync();
                return _mapper.Map<eAutobusModel.UlogeModel>(entity);
            }
            return null;
        }
        public async Task<UlogeModel> Update(int id,UlogeInsertRequest request)
        {
            var search = await _context.Uloge.FindAsync(id);
            if (search != null)
            {
                var entity = _mapper.Map<Uloge>(request);
                _mapper.Map(request, entity);
                await _context.SaveChangesAsync();
                return _mapper.Map<eAutobusModel.UlogeModel>(entity);
            }
            return null;
        }
            public async Task<UlogeModel> GetById(int id)
        {
            var entity = await _context.Uloge.FindAsync(id);
            return _mapper.Map<UlogeModel>(entity);
        }
    }
}

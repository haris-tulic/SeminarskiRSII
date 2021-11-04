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
    public class GradService : IGradService
    {
        private readonly eAutobus _context;
        private readonly IMapper _mapper;
        public GradService(eAutobus context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public eAutobusModel.GradModel Delete(int id)
        {
            var entity = _context.Grad.Find(id);
            _context.Grad.Remove(entity);
            _context.SaveChanges();
            return _mapper.Map<eAutobusModel.GradModel>(entity);

        }

        public List<eAutobusModel.GradModel> Get()
        {
            var list = _context.Grad.ToList();
            return _mapper.Map<List<eAutobusModel.GradModel>>(list);
        }

        public eAutobusModel.GradModel GetById(int id)
        {
            var entity = _context.Grad.Find(id);
            return _mapper.Map<eAutobusModel.GradModel>(entity);
        }

        public eAutobusModel.GradModel Insert(GradInsertRequest request)
        {
            var entity = _mapper.Map<Database.Grad>(request);
            _context.Grad.Add(entity);
            _context.SaveChanges();
            return _mapper.Map<eAutobusModel.GradModel>(entity);
        }

        public eAutobusModel.GradModel Update(GradInsertRequest request, int id)
        {
            var entity = _context.Grad.Find(id);
            _mapper.Map(request, entity);
            _context.SaveChanges();
            return _mapper.Map<eAutobusModel.GradModel>(entity);
        }
    }
}

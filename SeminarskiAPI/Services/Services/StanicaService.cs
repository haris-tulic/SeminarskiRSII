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
    public class StanicaService : IStanicaService
    {
        private readonly eAutobus _context;
        private readonly IMapper _mapper;
        public StanicaService(eAutobus context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public eAutobusModel.StanicaModel Delete(int id)
        {
            var entity = _context.Stanica.Find(id);
            _context.Stanica.Remove(entity);
            _context.SaveChanges();
            return _mapper.Map<eAutobusModel.StanicaModel>(entity);
        }

        public List<eAutobusModel.StanicaModel> Get()
        {
            var list = _context.Stanica.Include(s=>s.Grad).ToList();
            var listS = new List<StanicaModel>();
            listS = _mapper.Map<List<eAutobusModel.StanicaModel>>(list);
            for (int i = 0; i < list.Count; i++)
            {
                listS[i].Grad = list[i].Grad.NazivGrada;
            }
            return listS ;
        }

        public eAutobusModel.StanicaModel GetById(int id)
        {
            var entity = _context.Stanica.Find(id);
            return _mapper.Map<eAutobusModel.StanicaModel>(entity);
        }

        public eAutobusModel.StanicaModel Insert(StanicaInsertRequest request)
        {
            var entity = _mapper.Map<Database.Stanica>(request);
            _context.Stanica.Add(entity);
            _context.SaveChanges();
            return _mapper.Map<eAutobusModel.StanicaModel>(entity);

        }
    }
}

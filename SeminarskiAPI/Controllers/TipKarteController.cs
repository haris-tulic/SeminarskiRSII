using eAutobusModel.Requests;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SeminarskiWebAPI.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SeminarskiWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TipKarteController : ControllerBase
    {
        private readonly ITipKarteService _service;
        public TipKarteController(ITipKarteService service)
        {
            _service = service;
        }
        [HttpGet]
        public List<eAutobusModel.TipKarteModel> Get()
        {
            return _service.Get();
        }
        [HttpGet("{id}")]
        public eAutobusModel.TipKarteModel GetById(int id)
        {
            return _service.GetById(id);
        }
        [HttpPost]
        public eAutobusModel.TipKarteModel Insert(TipKarteInsertRequest request)
        {
            return _service.Insert(request);
        }
        [HttpDelete]
        public eAutobusModel.TipKarteModel Delete(int id)
        {
            return _service.Delete(id);
        }
    }
}

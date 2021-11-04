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
    public class ZonaController : ControllerBase
    {
        private readonly IZonaService _service;
        public ZonaController(IZonaService service)
        {
            _service = service;
        }
        [HttpGet]
        public List<eAutobusModel.ZonaModel> Get()
        {
            return _service.Get();
        }
        [HttpGet("{id}")]
        public eAutobusModel.ZonaModel GetById(int id)
        {
            return _service.GetById(id);
        }
        [HttpPost]
        public eAutobusModel.ZonaModel Insert(ZonaInsertRequest request)
        {
            return _service.Insert(request);
        }
        [HttpDelete("{id}")]
        public eAutobusModel.ZonaModel Delete(int id)
        {
            return _service.Delete(id);
        }
    }
}

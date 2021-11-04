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
    public class UpravaController : ControllerBase
    {
        private readonly IUpravaService _service;
        public UpravaController(IUpravaService service)
        {
            _service = service;
        }
        [HttpGet("{id}")]
        public eAutobusModel.UpravaModel GetByID(int id)
        {
            return _service.GetByID(id);
        }
        [HttpGet]
        public List<eAutobusModel.UpravaModel> Get([FromQuery] UpravaGetRequest request)
        {
            return _service.Get(request);
        }
        [HttpPost]
        public eAutobusModel.UpravaModel Insert(UpravaUpsertRequest request)
        {
            return _service.Insert(request);
        }
        [HttpPut("{id}")]
        public eAutobusModel.UpravaModel Update(UpravaUpsertRequest request, int id)
        {
            return _service.Update(request, id);
        }
        [HttpDelete("{id}")]
        public eAutobusModel.UpravaModel Delete(int id)
        {
            return _service.Delete(id);
        }
    }
}

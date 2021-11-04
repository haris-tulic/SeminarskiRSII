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
    public class RasporedVoznjeController : ControllerBase
    {
        private readonly IRasporedVoznjeService _service;
        public RasporedVoznjeController(IRasporedVoznjeService service)
        {
            _service = service;
        }
        [HttpGet]
        public List<eAutobusModel.RasporedVoznjeModel> Get([FromQuery]RasporedVoznjeGetRequest search)
        {
            return _service.Get(search);
        }
        
        [HttpGet("{id}")]
        public eAutobusModel.RasporedVoznjeModel GetById(int id)
        {
            return _service.GetById(id);
        }
     
        [HttpPost]
        public eAutobusModel.RasporedVoznjeModel Insert(RasporedVoznjeUpsertRequest request)
        {
            return _service.Insert(request);
        }
        
        [HttpPut("{id}")]
        public eAutobusModel.RasporedVoznjeModel Update(RasporedVoznjeUpsertRequest request, int id)
        {
            return _service.Update(request, id);
        }
        
        [HttpDelete("{id}")]
        public eAutobusModel.RasporedVoznjeModel Delete(int id)
        {
            return _service.Delete(id);
        }
    }
}

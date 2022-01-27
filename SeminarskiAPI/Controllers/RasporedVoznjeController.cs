using eAutobusModel;
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
        public List<RasporedVoznjeModel> Get([FromQuery]RasporedVoznjeGetRequest search)
        {
            return _service.Get(search);
        }
        
        [HttpGet("{id}")]
        public RasporedVoznjeModel GetById(int id)
        {
            return _service.GetById(id);
        }
     
        [HttpPost]
        public RasporedVoznjeModel Insert(RasporedVoznjeUpsertRequest request)
        {
            return _service.Insert(request);
        }
        
        [HttpPut("{id}")]
        public RasporedVoznjeModel Update(RasporedVoznjeUpsertRequest request, int id)
        {
            return _service.Update(request, id);
        }
        
        [HttpDelete("{id}")]
        public RasporedVoznjeModel Delete(int id)
        {
            return _service.Delete(id);
        }
    }
}

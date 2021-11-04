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
    public class AutobusVozacController : ControllerBase
    {
        private readonly IAutobusVozacService _service;

        public AutobusVozacController(IAutobusVozacService service)
        {
            _service = service;
        }
        [HttpGet]
        public List<eAutobusModel.AutobusVozacModel> Get([FromQuery] AutobusVozacGetRequest request)
        {
            return _service.Get(request);
        }
        [HttpGet("{id}")]
        public eAutobusModel.AutobusVozacModel GetByID(int id)
        {
            return _service.GetByID(id);
        }
        [HttpPost]
        public eAutobusModel.AutobusVozacModel Insert(AutobusVozacUpsertRequest request)
        {
            return _service.Insert(request);
        }
        [HttpPut("{id}")]
        public eAutobusModel.AutobusVozacModel Update(AutobusVozacUpsertRequest request, int id)
        {
            return _service.Update(request, id);
        }
        [HttpDelete("{id}")]
        public eAutobusModel.AutobusVozacModel Delete(int id)
        {
            return _service.Delete(id);
        }
    }
}

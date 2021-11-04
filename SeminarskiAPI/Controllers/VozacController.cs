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
    public class VozacController : ControllerBase
    {
        private readonly IVozacService _service;
        public VozacController(IVozacService service)
        {
            _service = service;
        }
        [HttpGet]
        public List<eAutobusModel.VozacModel> Get([FromQuery]VozacGetRequest request)
        {
            return _service.Get(request);
        }

        [HttpGet("{id}")]
        public eAutobusModel.VozacModel GetById(int id)
        {
            return _service.GetById(id);
        }
        [HttpPost]
        public eAutobusModel.VozacModel Insert(VozacUpsertRequest request)
        {
            return _service.Insert(request);
        }
        [HttpPut("{id}")]

        public eAutobusModel.VozacModel Update(VozacUpsertRequest request, int id)
        {
            return _service.Update(request, id);
        }
        [HttpDelete("{id}")]

        public eAutobusModel.VozacModel Delete(int id)
        {
            return _service.Delete(id);
        }
    }
}

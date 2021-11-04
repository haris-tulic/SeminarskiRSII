using eAutobusModel.Requests;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SeminarskiWebAPI.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SeminarskiAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class AutobusiController : ControllerBase
    {
        private readonly IAutobusService _service;
        public AutobusiController(IAutobusService service)
        {
            _service = service;
        }
        [HttpGet]

        public ActionResult<List<eAutobusModel.AutobusiModel>> Get([FromQuery] AutobusGetRequest request)
        {
            return _service.Get(request);
        }
        [HttpPost]
        public eAutobusModel.AutobusiModel Insert(AutobusInsertRequest request)
        {
            return _service.Insert(request);
        }
        [HttpPut("{id}")]
        public eAutobusModel.AutobusiModel Update(AutobusInsertRequest request, int id)
        {
            return _service.Update(request, id);
        }
        [HttpDelete("{id}")]
        public eAutobusModel.AutobusiModel Delete(int id)
        {
            return _service.Delete(id);
        }
    }
}

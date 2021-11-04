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
    public class StanicaController : ControllerBase
    {
        private readonly IStanicaService _service;
        public StanicaController(IStanicaService service)
        {
            _service = service;
        }
        [HttpGet]
        public List<eAutobusModel.StanicaModel> Get()
        {
            return _service.Get();
        }
        [HttpGet("{id}")]
        public eAutobusModel.StanicaModel GetById(int id)
        {
            return _service.GetById(id);
        }
        [HttpPost]
        public eAutobusModel.StanicaModel Insert(StanicaInsertRequest request)
        {
            return _service.Insert(request);
        }
        [HttpDelete("{id}")]
        public eAutobusModel.StanicaModel Delete(int id)
        {
            return _service.Delete(id);
        }
    }
}

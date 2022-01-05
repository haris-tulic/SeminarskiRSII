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
    public class CjenovnikController : ControllerBase
    {
        private ICjenovnikService _service;
        public CjenovnikController(ICjenovnikService service)
        {
            _service = service;
        }
        [HttpGet]
        public List<eAutobusModel.CjenovnikModel> Get([FromQuery] CjenovnikSearchRequest request)
        {
            return _service.Get(request);
        }
        [HttpGet("{id}")]
        public eAutobusModel.CjenovnikModel GetByID(int id)
        {
            return _service.GetByID(id);
        }
        [HttpPost]
        public eAutobusModel.CjenovnikModel Insert(CjenovnikInsertRequest request)
        {
            return _service.Insert(request);
        }
        [HttpPut("{id}")]
        public eAutobusModel.CjenovnikModel Update(int id, CjenovnikInsertRequest request)
        {
            return _service.Update(id, request) ;
        }
        [HttpDelete]
        public eAutobusModel.CjenovnikModel Delete(int id)
        {
            return _service.Delete(id);
        }
       
    }
}

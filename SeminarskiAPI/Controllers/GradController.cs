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
    public class GradController : ControllerBase
    {
        private readonly IGradService _service;
        public GradController(IGradService service)
        {
            _service = service;
        }
        [HttpGet]
        public List<eAutobusModel.GradModel> Get()
        {
            return _service.Get();
        }
        [HttpGet("{id}")]
        public eAutobusModel.GradModel GetById(int id)
        {
            return _service.GetById(id);
        }
        [HttpPost]
        public eAutobusModel.GradModel Insert(GradInsertRequest request)
        {
            return _service.Insert(request);
        }
        [HttpPut("{id}")]
        public eAutobusModel.GradModel Update(GradInsertRequest request, int id)
        {
            return _service.Update(request, id);
        }
        [HttpDelete("{id}")]
        public eAutobusModel.GradModel Delete(int id)
        {
            return _service.Delete(id);
        }
    }
}

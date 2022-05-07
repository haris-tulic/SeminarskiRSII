using eAutobusModel;
using eAutobusModel.Requests;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SeminarskiWebAPI.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SeminarskiWebAPI.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class KupacController : ControllerBase
    {
        private readonly IKupacService _service;
        public KupacController(IKupacService service)
        {
            _service = service;
        }

        
        [HttpGet]
        public List<eAutobusModel.KupacModel> Get([FromQuery]KupacGetRequest request)
        {
            return _service.Get(request);
        }
        [HttpGet("{id}")]
        public eAutobusModel.KupacModel GetByID(int id)
        {
            return _service.GetByID(id);
        }

        [AllowAnonymous]
        [HttpPost]
        public eAutobusModel.KupacModel Insert(KupacInsertRequest request)
        {
            return _service.Insert(request);
        }

        [AllowAnonymous]
        [HttpPut("{id}")]
        public eAutobusModel.KupacModel Update(KupacInsertRequest request, int id)
        {
            return _service.Update(request, id);
        }
        [HttpDelete("{id}")]
        public eAutobusModel.KupacModel Delete(int id)
        {
            return _service.Delete(id);
        }
        [AllowAnonymous]
        [HttpPost("{request}")]
        public KupacModel RegistrujSe(KupacInsertRequest request)
        {
            return _service.RegistrujSe(request);
        }

    }
}

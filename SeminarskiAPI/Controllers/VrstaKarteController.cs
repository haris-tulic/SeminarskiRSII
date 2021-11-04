using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SeminarskiWebAPI.Services;
using eAutobusModel.Requests;

namespace SeminarskiWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VrstaKarteController : ControllerBase
    {
        private readonly IVrstaKarteService _service;
        public VrstaKarteController(IVrstaKarteService service)
        {
            _service = service;
        }
        [HttpGet]
       public List<eAutobusModel.VrstaKarteModel> Get()
        {
            return _service.Get();
        }
        [HttpGet("{id}")]

        public eAutobusModel.VrstaKarteModel GetById(int id)
        {
            return _service.GetById(id);
        }
        [HttpPost]
       public eAutobusModel.VrstaKarteModel Insert(VrstaKarteInsertRequest request)
        {
            return _service.Insert(request);
        }
        [HttpDelete("{id}")]
       public eAutobusModel.VrstaKarteModel Delete(int id)
        {
            return _service.Delete(id);
        }
    }
}

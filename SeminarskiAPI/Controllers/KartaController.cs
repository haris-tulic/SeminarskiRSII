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
    public class KartaController : ControllerBase
    {
        private readonly IKartaService _service;
        public KartaController(IKartaService service)
        {
            _service = service;
        }
       [HttpGet]
        public List<eAutobusModel.KartaModel> Get([FromQuery] KartaGetRequest request)
        {
            return _service.Get(request);
        }
       [HttpGet("{id}")] 
        public eAutobusModel.KartaModel GetById(int id)
        {
            return _service.GetById(id);
        }
       [HttpPost]
       public eAutobusModel.KartaModel Insert(KartaUpsertRequest request)
        {
            return _service.Insert(request);
        }
       [HttpPut("{id}")]
        public eAutobusModel.KartaModel Update(KartaUpsertRequest request, int id)
        {
            return _service.Update(request, id);
        }
       [HttpDelete("{id}")]
         public eAutobusModel.KartaModel Delete(int id)
        {
            return _service.Delete(id);
        }

    }
}

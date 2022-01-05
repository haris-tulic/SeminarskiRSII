using eAutobusModel;
using eAutobusModel.Requests;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SeminarskiWebAPI.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SeminarskiWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GarazaController : ControllerBase
    {
        private readonly IGarazaService _service;

        public GarazaController(IGarazaService service)
        {
            _service = service;
        }

        [HttpGet]
        public List<eAutobusModel.GarazaModel> Get()
        {
            return _service.Get();
        }

        [HttpGet("{id}")]
        public eAutobusModel.GarazaModel GetByID(int id)
        {
            return _service.GetByID(id);
        }

        [HttpPost]
        public eAutobusModel.GarazaModel Insert(GarazaUpsertRequest request)
        {
            return _service.Insert(request);
        }

        [HttpPut("{id}")]
        public eAutobusModel.GarazaModel Update(GarazaUpsertRequest update,int id)
        {
            return _service.Update(update,id);
        }

        [HttpDelete("{id}")]
        public GarazaModel Delete(int id)
        {
            return _service.Delete(id);
        }
    }
}

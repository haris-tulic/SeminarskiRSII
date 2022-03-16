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
    public class RecenzijaController : ControllerBase
    {
        private readonly IRecenzijaService _service;

        public RecenzijaController(IRecenzijaService service)
        {
            _service = service;
        }
        [HttpGet]
        public List<RecenzijaModel> Get([FromQuery] RecenzijaGetRequest search)
        {
            return _service.Get(search);
        }

        [HttpPost]
        public RecenzijaModel Insert(RecenzijaUpsertRequest request)
        {
            return _service.Insert(request);
        }
    }
}

using eAutobusModel;
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
    public class PreporukeController : ControllerBase
    {
        private readonly IPreporukeService _service;

        public PreporukeController(IPreporukeService service)
        {
            _service = service;
        }
        [HttpGet]
        public List<RasporedVoznjeModel> Get(int RasporedLinijeID)
        {
            return _service.Get(RasporedLinijeID);
        }

        [HttpGet("{id}")]
        public RasporedVoznjeModel GetById(int RasporedLinijeID)
        {
            return _service.GetById(RasporedLinijeID);
        }
    }
}

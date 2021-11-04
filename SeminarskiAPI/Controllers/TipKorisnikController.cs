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
    public class TipKorisnikController : ControllerBase
    {
        private readonly ITipKorisnikaService _service;

        public TipKorisnikController(ITipKorisnikaService service)
        {
            _service = service;
        }

        [HttpGet]
        public List<eAutobusModel.TipKorisnikaModel> Get()
        {
            return _service.Get();
        }

        [HttpPost]
        public eAutobusModel.TipKorisnikaModel Insert(TipKorisnikaInsertRequest request)
        {
            return _service.Insert(request);
        }

        [HttpDelete("{id}")]
        public eAutobusModel.TipKorisnikaModel Delete(int id)
        {
            return _service.Delete(id);
        }
    }
}

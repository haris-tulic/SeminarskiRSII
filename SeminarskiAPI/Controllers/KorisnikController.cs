using eAutobusModel;
using eAutobusModel.Requests;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SeminarskiWebAPI.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SeminarskiWebAPI.Controllers
{
    //[Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class KorisnikController : ControllerBase
    {
        private readonly IKorisnikService _service;

        public KorisnikController(IKorisnikService service)
        {
            _service = service;
        }
        [HttpGet]
        public List<KorisnikModel> Get([FromQuery]KorisnikGetRequest search)
        {
            return _service.Get(search);
        }
        
        [HttpGet("{id}")]
        public KorisnikModel GetByID(int id)
        {
            return _service.GetByID(id);
        }

        [HttpPost]
        
        public async Task<KorisnikModel> Insert(KorisnikUpsertRequest request)
        {
            return await _service.Insert(request);
        }

        [HttpPut("{id}")]
        public KorisnikModel Update(KorisnikUpsertRequest request, int id)
        {
            return _service.Update(request, id);
        }

        [HttpDelete("{id}")]
        public KorisnikModel Delete(int id)
        {
            return _service.Delete(id);
        }
    }

}

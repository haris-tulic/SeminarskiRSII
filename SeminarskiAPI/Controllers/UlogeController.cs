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
    public class UlogeController : ControllerBase
    {
        private readonly IUlogeService _service;

        public UlogeController(IUlogeService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<List<UlogeModel>> Get([FromQuery]UlogeGetRequest search)
        {
            return await _service.Get(search);
        }

        [HttpPost]
        public async Task<UlogeModel> Insert(UlogeInsertRequest request)
        {
            return await _service.Insert(request);
        }

        [HttpDelete("{id}")]
        public async Task<UlogeModel> Delete(int id)
        {
            return await _service.Delete(id);
        }

        [HttpGet("{id}")]
        public async Task<UlogeModel> GetById(int id)
        {
            return await _service.GetById(id);
        }
        [HttpPut("{id}")]
        public async Task<UlogeModel> Update(int id,UlogeInsertRequest request)
        {
            return await _service.Update(id, request);
        }     
       
    }
}

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
    public class PlatiKartuController : ControllerBase
    {
        private readonly IPlatiOnlineService _service;

        public PlatiKartuController(IPlatiOnlineService service)
        {
            _service = service;
        }
        [HttpGet]
        public List<PlatiKartuModel> Get([FromQuery]PlatiKartuGetRequest search)
        {
            return _service.Get(search);
        }

        [HttpGet("{id}")]
        public PlatiKartuModel GetById(int id)
        {
            return _service.GetById(id);
        }

        [HttpPost]
        public PlatiKartuModel Insert(PlatiKartuUpsertRequest request)
        {
            return _service.Insert(request);
        }

        [HttpPut("{id}")]
        public PlatiKartuModel Update(PlatiKartuUpsertRequest request, int id)
        {
            return _service.Update(request,id);
        }
    }
}

using eAutobusModel;
using eAutobusModel.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SeminarskiWebAPI.Services.Interfaces
{
    public interface IRecenzijaService
    {
        List<RecenzijaModel> Get(RecenzijaGetRequest search);
        RecenzijaModel Insert(RecenzijaUpsertRequest request);
        
    }
}

using eAutobusModel.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SeminarskiWebAPI.Services
{
    public interface IRasporedVoznjeService
    {
        List<eAutobusModel.RasporedVoznjeModel> Get(RasporedVoznjeGetRequest search);
        eAutobusModel.RasporedVoznjeModel GetById(int id);
        eAutobusModel.RasporedVoznjeModel Insert(RasporedVoznjeUpsertRequest request);
        eAutobusModel.RasporedVoznjeModel Update(RasporedVoznjeUpsertRequest request, int id);
        eAutobusModel.RasporedVoznjeModel Delete(int id);
    }
}

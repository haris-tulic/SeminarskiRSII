using eAutobusModel.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SeminarskiWebAPI.Services
{
    public interface IUpravaService
    {
        eAutobusModel.UpravaModel GetByID(int id);
        List<eAutobusModel.UpravaModel> Get(UpravaGetRequest request);
        eAutobusModel.UpravaModel Insert(UpravaUpsertRequest request);
        eAutobusModel.UpravaModel Update(UpravaUpsertRequest request, int id);
        eAutobusModel.UpravaModel Delete(int id);
    }
}

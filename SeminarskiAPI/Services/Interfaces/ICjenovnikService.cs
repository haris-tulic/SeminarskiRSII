using eAutobusModel.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SeminarskiWebAPI.Services
{
    public interface ICjenovnikService
    {
        List<eAutobusModel.CjenovnikModel> Get(CjenovnikSearchRequest request);
        eAutobusModel.CjenovnikModel GetByID(int id);
        eAutobusModel.CjenovnikModel Insert(CjenovnikInsertRequest request);
        eAutobusModel.CjenovnikModel Update(CjenovnikInsertRequest request, int id);
        eAutobusModel.CjenovnikModel Delete(int id);


    }
}

using eAutobusModel;
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
        CjenovnikModel GetByID(int id);
        CjenovnikModel Insert(CjenovnikInsertRequest request);
        CjenovnikModel Update( int id, CjenovnikInsertRequest request);
        CjenovnikModel Delete(int id);
        CjenovnikModel GetCijena(CjenovnikSearchRequest request);


    }
}

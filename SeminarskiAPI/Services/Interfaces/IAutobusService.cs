using eAutobusModel.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace SeminarskiWebAPI.Services
{
    public interface IAutobusService
    {
        List<eAutobusModel.AutobusiModel> Get(AutobusGetRequest request);
        eAutobusModel.AutobusiModel Insert(AutobusInsertRequest request);
        eAutobusModel.AutobusiModel Update(AutobusInsertRequest request,int id);
        eAutobusModel.AutobusiModel Delete(int id);
    }
}

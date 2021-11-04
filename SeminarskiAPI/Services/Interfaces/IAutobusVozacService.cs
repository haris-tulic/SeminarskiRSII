using eAutobusModel.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SeminarskiWebAPI.Services
{
    public interface IAutobusVozacService
    {
        List<eAutobusModel.AutobusVozacModel> Get(AutobusVozacGetRequest request);
        eAutobusModel.AutobusVozacModel GetByID(int id);
        eAutobusModel.AutobusVozacModel Insert(AutobusVozacUpsertRequest request);
        eAutobusModel.AutobusVozacModel Update(AutobusVozacUpsertRequest request,int id);

        eAutobusModel.AutobusVozacModel Delete(int id);

    }
}

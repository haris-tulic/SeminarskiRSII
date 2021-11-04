using eAutobusModel.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SeminarskiWebAPI.Services
{
    public interface IVozacService
    {
        List<eAutobusModel.VozacModel> Get(VozacGetRequest request);
        eAutobusModel.VozacModel GetById(int id);
        eAutobusModel.VozacModel Insert(VozacUpsertRequest request);
        eAutobusModel.VozacModel Update(VozacUpsertRequest request,int id);
        eAutobusModel.VozacModel Delete(int id);

    }
}

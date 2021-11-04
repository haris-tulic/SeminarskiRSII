using eAutobusModel.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SeminarskiWebAPI.Services
{
    public interface IGradService
    {
        List<eAutobusModel.GradModel> Get();
        eAutobusModel.GradModel GetById(int id);
        eAutobusModel.GradModel Insert(GradInsertRequest request);
        eAutobusModel.GradModel Update(GradInsertRequest request, int id);
        eAutobusModel.GradModel Delete(int id);
    }
}

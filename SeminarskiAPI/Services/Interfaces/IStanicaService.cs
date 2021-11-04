using eAutobusModel.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SeminarskiWebAPI.Services
{
    public interface IStanicaService
    {
        List<eAutobusModel.StanicaModel> Get();
        eAutobusModel.StanicaModel GetById(int id);
        eAutobusModel.StanicaModel Insert(StanicaInsertRequest request);
        eAutobusModel.StanicaModel Delete(int id);
    }
}

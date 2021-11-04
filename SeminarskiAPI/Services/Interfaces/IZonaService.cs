using eAutobusModel.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SeminarskiWebAPI.Services
{
    public interface IZonaService
    {
        List<eAutobusModel.ZonaModel> Get();
        eAutobusModel.ZonaModel GetById(int id);
        eAutobusModel.ZonaModel Insert(ZonaInsertRequest request);
        eAutobusModel.ZonaModel Delete(int id);
    }
}

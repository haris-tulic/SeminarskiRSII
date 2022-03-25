using eAutobusModel.Requests;
using SeminarskiWebAPI.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SeminarskiWebAPI.Services
{
    public interface IVrstaKarteService
    {
        List<eAutobusModel.VrstaKarteModel> Get();
        eAutobusModel.VrstaKarteModel GetById(int id);
        eAutobusModel.VrstaKarteModel Insert(VrstaKarteInsertRequest request);
        eAutobusModel.VrstaKarteModel Delete(int id);
        

    }
}

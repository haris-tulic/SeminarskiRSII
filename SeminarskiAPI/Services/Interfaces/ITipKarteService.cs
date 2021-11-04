using eAutobusModel.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SeminarskiWebAPI.Services
{
    public interface ITipKarteService
    {
        List<eAutobusModel.TipKarteModel> Get();
        eAutobusModel.TipKarteModel GetById(int id);
        eAutobusModel.TipKarteModel Insert(TipKarteInsertRequest request);
        eAutobusModel.TipKarteModel Delete(int id);


    }
}

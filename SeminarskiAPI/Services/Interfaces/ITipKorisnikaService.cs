using eAutobusModel.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SeminarskiWebAPI.Services
{
    public interface ITipKorisnikaService
    {
        List<eAutobusModel.TipKorisnikaModel> Get();
        eAutobusModel.TipKorisnikaModel Insert(TipKorisnikaInsertRequest request);
        eAutobusModel.TipKorisnikaModel Delete(int id);
    }
}

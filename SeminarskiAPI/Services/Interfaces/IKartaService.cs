using eAutobusModel.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SeminarskiWebAPI.Services
{
    public interface IKartaService
    {
        List<eAutobusModel.KartaModel> Get(KartaGetRequest request);
        eAutobusModel.KartaModel GetById(int id);
        eAutobusModel.KartaModel Insert(KartaUpsertRequest request);
        eAutobusModel.KartaModel Update(KartaUpsertRequest request,int id);
        eAutobusModel.KartaModel Delete(int id);


    }
}

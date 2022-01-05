using eAutobusModel;
using eAutobusModel.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SeminarskiWebAPI.Services.Interfaces
{
    public interface IGarazaService
    {
        List<eAutobusModel.GarazaModel> Get();
        eAutobusModel.GarazaModel GetByID(int id);
        eAutobusModel.GarazaModel Insert(GarazaUpsertRequest request);
        eAutobusModel.GarazaModel Update(GarazaUpsertRequest update, int id);
        GarazaModel Delete(int id);
        bool IsPopunjeno(int GarazaId);
    }
}

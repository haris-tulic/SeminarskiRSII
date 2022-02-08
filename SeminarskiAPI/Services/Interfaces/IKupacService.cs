using eAutobusModel;
using eAutobusModel.Requests;
using SeminarskiWebAPI.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SeminarskiWebAPI.Services
{
    public interface IKupacService
    {
        eAutobusModel.KupacModel GetByID(int id);
        List<eAutobusModel.KupacModel> Get(KupacGetRequest request);
        eAutobusModel.KupacModel Insert(KupacInsertRequest request);
        eAutobusModel.KupacModel Update(KupacInsertRequest request,int id);
        eAutobusModel.KupacModel Delete(int id);
        Kupac PronadjiKupca(KupacInsertRequest kupac);
    }
}

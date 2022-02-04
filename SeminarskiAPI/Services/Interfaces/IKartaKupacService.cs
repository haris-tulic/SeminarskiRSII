using eAutobusModel;
using eAutobusModel.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SeminarskiWebAPI.Services.Interfaces
{
    public interface IKartaKupacService
    {
        List<KartaKupacModel> Get(KartaKupacGetRequest search);
        KartaKupacModel Insert(KartaKupacUpsertRequest request);
    }
}

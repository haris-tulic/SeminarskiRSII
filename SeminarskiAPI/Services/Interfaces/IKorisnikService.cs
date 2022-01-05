using eAutobusModel;
using eAutobusModel.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SeminarskiWebAPI.Services.Interfaces
{
    public interface IKorisnikService
    {
        List<KorisnikModel> Get(KorisnikGetRequest search);
        KorisnikModel GetByID(int id);
        Task<KorisnikModel> Insert(KorisnikUpsertRequest request);
        KorisnikModel Update(KorisnikUpsertRequest request,int id);
        KorisnikModel Delete(int id);
        //Task<KorisnikModel> Login(string username, string password);

    }
}

using eAutobusModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SeminarskiWebAPI.Services.Interfaces
{
    public interface ILoginService
    {
        Task<KorisnikModel> Autentificiraj(string userName, string password);
    }
}

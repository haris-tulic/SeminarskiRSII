using eAutobusModel;
using SeminarskiWebAPI.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SeminarskiWebAPI.Services.Interfaces
{
    public interface IKorisniciUlogeService
    {
        List<KorisniciUlogeModel> UlogeIsEqual(int ulogaID); 
    }
}

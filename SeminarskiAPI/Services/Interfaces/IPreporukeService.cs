using eAutobusModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SeminarskiWebAPI.Services.Interfaces
{
    public interface IPreporukeService
    {
        List<RasporedVoznjeModel> Get(int RasporedLinijaID);
        RasporedVoznjeModel GetById(int RasporedLinijaID);
    }
}

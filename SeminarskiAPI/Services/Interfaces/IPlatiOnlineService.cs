using eAutobusModel;
using eAutobusModel.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SeminarskiWebAPI.Services.Interfaces
{
    public interface IPlatiOnlineService
    {
        List<PlatiKartuModel> Get(PlatiKartuGetRequest search);
        PlatiKartuModel GetById(int id);
        PlatiKartuModel Insert(PlatiKartuUpsertRequest request);
        PlatiKartuModel Update(PlatiKartuUpsertRequest request,int id);

    }
}

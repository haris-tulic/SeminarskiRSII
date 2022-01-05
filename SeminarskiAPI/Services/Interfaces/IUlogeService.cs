using eAutobusModel;
using eAutobusModel.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SeminarskiWebAPI.Services
{
    public interface IUlogeService
    {
        Task<List<UlogeModel>> Get(UlogeGetRequest search);
        Task<UlogeModel> Insert(UlogeInsertRequest request);
        Task<UlogeModel> Delete(int id);
        Task<UlogeModel> GetById(int id);
        Task<UlogeModel> Update(int id, UlogeInsertRequest request);
    }
}

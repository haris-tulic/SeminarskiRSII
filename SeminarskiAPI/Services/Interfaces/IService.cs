using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SeminarskiWebAPI.Services.Interfaces
{
    public interface IService<T,TSearch>
    {
        List<T> Get(TSearch search);
        T GetByID(int id);

    }
}

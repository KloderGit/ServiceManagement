using System;
using System.Collections.Generic;
using System.Text;

namespace SM.Domain.Service.Interfaces
{
    public interface IGetData<T> where T: class
    {
        T Get(string key);
        IEnumerable<T> GetList();
    }
}

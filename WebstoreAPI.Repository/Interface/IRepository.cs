using System;
using System.Collections.Generic;
using System.Text;
using WebStoreAPI.Domain.Interface;

namespace WebStoreAPI.Repository.Interface
{
    public interface IRepository<T> where T : IEntity
    {
        IEnumerable<T> Query(string query);
    }
}

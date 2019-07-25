using System;
using System.Collections.Generic;
using System.Text;
using WebStoreAPI.Domain;
using WebStoreAPI.Repository.Interface;
using System.Linq;
using WebStoreAPI.Domain.Interface;

namespace WebStoreAPI.Repository.Abstract
{
    public abstract class Repository<T> : IRepository<T> where T : IEntity
    {
        private List<T> _list = new List<T>();
        public List<T> FindAll() {
            return _list;
        }

        public IEnumerable<T> Query(string query) {
            throw new NotImplementedException();
        }
    }
}

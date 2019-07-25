using System;
using System.Collections.Generic;
using System.Text;
using WebStoreAPI.Domain.Interface;

namespace WebStoreAPI.Domain.Abstract
{
    public abstract class Entity : IEntity
    {
        public Guid Key { get ; set; }

        protected Entity() {
            Key = Guid.NewGuid();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace WebStoreAPI.Domain.Interface
{
    public interface IEntity {      
        
        Guid Key { get; set; }
    }
}

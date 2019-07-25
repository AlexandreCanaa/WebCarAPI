using System;
using System.Collections.Generic;
using System.Text;
using WebStoreAPI.Domain;

namespace WebStoreAPI.Repository.Interface
{
    public interface ICarRepository
    {
        List<Car> ListAllCars();
    }
}

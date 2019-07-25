using System;
using System.Collections.Generic;
using System.Text;
using WebStoreAPI.Repository.Abstract;
using WebStoreAPI.Domain;
using WebStoreAPI.Repository.Interface;


namespace WebStoreAPI.Repository
{
    public class CarRepository : Repository<Car>, ICarRepository
    {
        public List<Car> ListAllCars() {

        }
    }
}

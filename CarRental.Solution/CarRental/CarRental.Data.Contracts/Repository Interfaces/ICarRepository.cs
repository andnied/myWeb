using System;
using System.Collections.Generic;
using System.Linq;
using CarRental.Business.Entities;
using Core.Common.Contracts;

namespace CarRental.Data.Contracts
{
    public interface ICarRepository : IDataRepository<Car>
    {
        IEnumerable<Car> GetRentedCars();
        IEnumerable<Car> GetAvailableCars(DateTime pickupDate, DateTime returnDate);
    }
}

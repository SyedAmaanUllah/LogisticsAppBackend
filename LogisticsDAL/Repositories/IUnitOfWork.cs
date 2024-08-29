using LogisticsDAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogisticsDAL.Repositories
{
    public interface IUnitOfWork
    {
        IShipmentRepository Shipments { get; }
        IRepository<Customer> Customers { get; }
        IRepository<Airport> Airports { get; }
        IRepository<User> Users { get; }
        IRepository<Flight> Flights { get; }
        IRepository<ShipmentStatus> ShipmentStatuses { get; }
        Task<int> CompleteAsync();
    }
}

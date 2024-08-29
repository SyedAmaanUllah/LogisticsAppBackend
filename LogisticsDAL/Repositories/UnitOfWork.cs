using LogisticsDAL.Models;
using Microsoft.Extensions.Logging;

namespace LogisticsDAL.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly LogisticsDbContext _dbContext;
        private readonly ILogger<UnitOfWork> _logger;
        public UnitOfWork(LogisticsDbContext dbContext, ILogger<UnitOfWork> logger)
        {
            _dbContext = dbContext;
            Shipments = new ShipmentRepository(_dbContext);
            Customers = new Repository<Customer>(_dbContext);
            Airports = new Repository<Airport>(_dbContext);
            Users = new Repository<User>(_dbContext);
            Flights = new Repository<Flight>(_dbContext);
            ShipmentStatuses = new Repository<ShipmentStatus>(_dbContext);
            _logger = logger;
        }

        public IShipmentRepository Shipments { get; }

        public IRepository<Customer> Customers { get; }

        public IRepository<Airport> Airports { get; }

        public IRepository<User> Users { get; }

        public IRepository<Flight> Flights { get; }

        public IRepository<ShipmentStatus> ShipmentStatuses { get; }

        public async Task<int> CompleteAsync()
        {
            try
            {
                return await _dbContext.SaveChangesAsync();
            }
            catch (Exception ex) 
            {
                _logger.LogError(ex, "An error occurred while saving changes to the database.");
                return -1;
            }
        }

        public void Dispose()
        {
            _dbContext.Dispose();
        }

    }
}

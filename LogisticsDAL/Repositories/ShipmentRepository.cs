using LogisticsDAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogisticsDAL.Repositories
{
    public class ShipmentRepository : Repository<Shipment>, IShipmentRepository
    {
        private readonly LogisticsDbContext _context;
        public ShipmentRepository(LogisticsDbContext context) : base(context) 
        {
            _context = context;
        }

        public async Task<Shipment?> GetShipmentWithDetailsAsync(int id)
        {
            IQueryable<Shipment> query = _context.Shipments.AsQueryable();
            query = query
                    .Include(s => s.OriginAirport)
                    .Include(s => s.DestinationAirport)
                    .Include(s => s.Customer)
                    .Include(s => s.Flight)
                    .Include(s => s.Status);
            return await query.FirstOrDefaultAsync(s => s.ShipmentId == id);
        }
        public async Task<IEnumerable<Shipment>> GetAllShipmentWithDetailsAsync()
        {
            IQueryable<Shipment> query = _context.Shipments.AsQueryable();
            query = query
                    .Include(s => s.OriginAirport)
                    .Include(s => s.DestinationAirport)
                    .Include(s => s.Customer)
                    .Include(s => s.Flight)
                    .Include(s => s.Status);
            return await query.ToListAsync();
        }
    }
}

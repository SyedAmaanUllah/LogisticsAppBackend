using LogisticsDAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogisticsDAL.Repositories
{
    public interface IShipmentRepository: IRepository<Shipment>
    {
        Task<Shipment?> GetShipmentWithDetailsAsync(int id);
        Task<IEnumerable<Shipment>> GetAllShipmentWithDetailsAsync();
    }
}

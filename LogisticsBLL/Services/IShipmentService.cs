using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogisticsBLL
{
    public interface IShipmentService
    {
        Task<ShipmentDTO?> CreateShipmentAsync(ShipmentDTO shipmentDto);
        Task<ShipmentDTO?> GetShipmentByIdAsync(int id);
        Task<IEnumerable<ShipmentDTO>> GetAllShipmentsAsync();
        Task<bool> UpdateShipmentAsync(ShipmentDTO shipmentDto);
        Task<bool> DeleteShipmentAsync(ShipmentDTO shipment);
    }
}

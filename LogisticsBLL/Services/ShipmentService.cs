using LogisticsDAL.Models;
using LogisticsDAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogisticsBLL.Services
{
    public class ShipmentService : IShipmentService
    {
        private readonly IUnitOfWork _unitOfWork;
        public ShipmentService(IUnitOfWork unitOfWork) 
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<IEnumerable<ShipmentDTO>> GetAllShipmentsAsync()
        {
            var shipmentDTOs = new List<ShipmentDTO>();
            var shipments = await _unitOfWork.Shipments.GetAllShipmentWithDetailsAsync();
            foreach (var shipment in shipments)
            {
                var shipmentDTO = MapToDto(shipment);
                shipmentDTOs.Add(shipmentDTO);
            }
            return shipmentDTOs;
        }

        public async Task<ShipmentDTO?> GetShipmentByIdAsync(int id)
        {
            ShipmentDTO? shipmentDTO = null;
            var shipment = await _unitOfWork.Shipments.GetShipmentWithDetailsAsync(id);
            if (shipment != null)
            {
                shipmentDTO = MapToDto(shipment);
            }
            return shipmentDTO;
        }

        public async Task<ShipmentDTO?> CreateShipmentAsync(ShipmentDTO shipmentDto)
        {
            var shipment = new Shipment();
            MapToEntity(shipmentDto,shipment);
            await _unitOfWork.Shipments.AddAsync(shipment);
            int created = await _unitOfWork.CompleteAsync();
            if (created > 0)
            {
                shipmentDto.ShipmentId = shipment.ShipmentId;
                return shipmentDto;
            }
            return null;
        }
        
        public async Task<bool> DeleteShipmentAsync(ShipmentDTO shipmentDto)
        {
            var shipmentToDelete = await _unitOfWork.Shipments.GetByIdAsync(shipmentDto.ShipmentId);
            _unitOfWork.Shipments.RemoveAsync(shipmentToDelete);
            int deleted = await _unitOfWork.CompleteAsync();
            return deleted > 0;
        }
      
        public async Task<bool> UpdateShipmentAsync(ShipmentDTO shipmentDto)
        {
            var shipmentToUpdate = await _unitOfWork.Shipments.GetByIdAsync(shipmentDto.ShipmentId);
            MapToEntity(shipmentDto, shipmentToUpdate);
            _unitOfWork.Shipments.UpdateAsync(shipmentToUpdate);
            int updated = await _unitOfWork.CompleteAsync();
            return updated > 0;
        }

        private ShipmentDTO MapToDto(Shipment shipment)
        {
            return new ShipmentDTO
            {
                ShipmentId = shipment.ShipmentId,
                ShipmentCode = shipment.ShipmentCode,
                Description = shipment.Description,
                OriginAirportId = shipment.OriginAirportId,
                DestinationAirportId = shipment.DestinationAirportId,
                CustomerId = shipment.CustomerId,
                FlightId = shipment.FlightId,
                StatusId = shipment.StatusId,
                ShipmentDate = shipment.ShipmentDate,
                CreatedDate = shipment.CreatedDate,
                ModifiedDate = shipment.ModifiedDate,
                OriginAirportName = shipment.OriginAirport?.Name,
                DestinationAirportName = shipment.DestinationAirport?.Name,
                CustomerName = shipment.Customer?.Name,
                FlightNumber = shipment.Flight?.FlightNumber,
                StatusName = shipment.Status?.StatusName
            };
        }

        private void MapToEntity(ShipmentDTO shipmentDto, Shipment shipment)
        {
            shipment.ShipmentCode = shipmentDto.ShipmentCode;
            shipment.Description = shipmentDto.Description;
            shipment.OriginAirportId = shipmentDto.OriginAirportId;
            shipment.DestinationAirportId = shipmentDto.DestinationAirportId;
            shipment.CustomerId = shipmentDto.CustomerId;
            shipment.FlightId = shipmentDto.FlightId;
            shipment.StatusId = shipmentDto.StatusId;
            shipment.ShipmentDate = shipmentDto.ShipmentDate;
            shipment.ModifiedDate = shipmentDto.ModifiedDate ?? DateTime.UtcNow;
        }
    }
}

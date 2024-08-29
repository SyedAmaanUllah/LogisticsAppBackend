using LogisticsBLL;
using Microsoft.AspNetCore.Mvc;

namespace LogisticsAPI.Controllers
{
    [ApiController]
    [Route("api")]
    public class ShipmentController : Controller
    {
        private readonly IShipmentService _shipmentService;
        public ShipmentController(IShipmentService shipmentService) 
        {
            _shipmentService = shipmentService;
        }

        [HttpGet("/Index")]
        public async Task<IActionResult> Index()
        {
            var shipmentDTOs = await _shipmentService.GetAllShipmentsAsync();
            return Ok(shipmentDTOs);
        }

        [HttpGet("/GetShipment/{id}")]
        public async Task<IActionResult> GetShipment(int id) 
        {
            var shipmentDTO = await _shipmentService.GetShipmentByIdAsync(id);
            if (shipmentDTO == null) return NotFound();
            return Ok(shipmentDTO);
        }

        [HttpPost("/CreateShipment")]
        public async Task<IActionResult> CreateShipment(ShipmentDTO shipmentDTO) 
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            var updatedShipmentDTO = await _shipmentService.CreateShipmentAsync(shipmentDTO);
            if (updatedShipmentDTO != null) return CreatedAtAction("Index", updatedShipmentDTO);
            return BadRequest("Could not create the shipment.");  
        }

        [HttpDelete("/DeleteShipment/{id}")]
        public async Task<IActionResult> DeleteShipment(int id)
        {
            var shipment = await _shipmentService.GetShipmentByIdAsync(id);
            if (shipment == null) return NotFound();
            var isDeleted = await _shipmentService.DeleteShipmentAsync(shipment);
            if (isDeleted) return NoContent();
            return BadRequest("Could not delete the shipment.");
        }

        [HttpPut("/UpdateShipment")]
        public async Task<IActionResult> UpdateShipment(ShipmentDTO shipmentDTO)
        {
            if (!ModelState.IsValid)  return BadRequest(ModelState);

            var shipment = await _shipmentService.GetShipmentByIdAsync(shipmentDTO.ShipmentId);
            if (shipment == null) return NotFound();

            var isUpdated = await _shipmentService.UpdateShipmentAsync(shipmentDTO);
            if(isUpdated) return NoContent();
            return BadRequest("Could not update the shipment.");
        }
    }
}

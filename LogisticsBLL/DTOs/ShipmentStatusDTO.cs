using System.ComponentModel.DataAnnotations;

namespace LogisticsBLL.DTOs
{
    public class ShipmentStatusDTO
    {
        [Required]
        public int ShipmentStatusId { get; set; }

        [Required]
        [StringLength(50)]
        public string StatusName { get; set; }

        [DataType(DataType.Date)]
        public DateTime CreatedDate { get; set; } = DateTime.Now;

        [DataType(DataType.Date)]
        public DateTime? ModifiedDate { get; set; }
    }

}

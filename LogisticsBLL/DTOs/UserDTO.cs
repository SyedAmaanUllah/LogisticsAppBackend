using System.ComponentModel.DataAnnotations;


namespace LogisticsBLL.DTOs
{
    public class UserDTO
    {
        [Required]
        public int UserId { get; set; }

        [Required]
        [StringLength(100)]
        public string Username { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [StringLength(100)]
        public string Role { get; set; }

        [DataType(DataType.Date)]
        public DateTime CreatedDate { get; set; } = DateTime.Now;

        [DataType(DataType.Date)]
        public DateTime? ModifiedDate { get; set; }
    }

}

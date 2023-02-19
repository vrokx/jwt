using System.ComponentModel.DataAnnotations;

namespace EpicShopAPI.Models
{
    public class RefreshToken
    {
        [Key]
        public string TokenString { get; set; }

        [Required]
        public string UserId { get; set; }

        [Required]
        public DateTime Expires { get; set; }
    }
}

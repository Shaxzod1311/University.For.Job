using System.ComponentModel.DataAnnotations;

namespace University.Service.DTOs
{
    public class CityDTO
    {
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
    }
}

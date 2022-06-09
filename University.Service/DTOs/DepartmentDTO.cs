using System.ComponentModel.DataAnnotations;

namespace University.Service.DTOs
{
    public class DepartmentDTO
    {
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
    }
}

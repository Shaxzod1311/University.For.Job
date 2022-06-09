using System.ComponentModel.DataAnnotations;

namespace University.Service.DTOs
{
    public class SubjectDTO
    {
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
    }
}

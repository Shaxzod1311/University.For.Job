using System;
using System.ComponentModel.DataAnnotations;
using University.Domain;

namespace University.Service.DTOs
{
    public class TeacherDTO
    {
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        public Guid CityId { get; set; }

        [Required]
        public DateTime BirthDate { get; set; }

        [Required]
        public Gender Gender { get; set; }
    }
}

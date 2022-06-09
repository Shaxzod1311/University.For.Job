using Newtonsoft.Json;
using System;
using System.ComponentModel.DataAnnotations;
using University.Domain;

namespace University.Service.DTOs
{
    public class StudentDTO
    {
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        public Guid CityId { get; set; }

        [Required]
        public DateTime BirthDate { get; set; }

        [Required]
        [JsonIgnore]
        public Gender gender { get; set; }

        public string Gender { get; set; }

        [Required]
        public short CurrentGradeLevel { get; set; }

        public void SetGender()
        {
            Gender = gender == 0 ? "Female" : "Male";
        }
    }
}

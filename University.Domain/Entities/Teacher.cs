using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using University.Domain.Common;

namespace University.Domain.Entities
{
    public class Teacher : BaseEntity
    {
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        public Guid CityId { get; set; }
        public DateTime BirthDate { get; set; }
        public Gender Gender { get; set; }
        public virtual ICollection<Student> Students { get; set; }

    }
}
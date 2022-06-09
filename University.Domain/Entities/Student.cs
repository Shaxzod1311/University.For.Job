using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using University.Domain.Common;

namespace University.Domain.Entities
{
    public class Student : BaseEntity
    {
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        public Guid CityId { get; set; }
        public DateTime BirthDate { get; set; }
        public string Gender { get; set; }

        [Required]
        public short CurrentGradeLevel { get; set; }
        public virtual ICollection<Subject> Subjects { get; set; }
        public virtual ICollection<Teacher> Teachers { get; set; }
    }
}

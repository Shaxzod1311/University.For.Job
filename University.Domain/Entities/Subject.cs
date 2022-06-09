using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using University.Domain.Common;

namespace University.Domain.Entities
{
    public class Subject : BaseEntity
    {
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        public virtual ICollection<Teacher> Teachers { get; set; }
    }
}

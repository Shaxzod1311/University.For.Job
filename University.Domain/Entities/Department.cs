using System.ComponentModel.DataAnnotations;
using University.Domain.Common;

namespace University.Domain.Entities
{
    public class Department : BaseEntity
    {
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
    }
}


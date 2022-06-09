using System.ComponentModel.DataAnnotations;
using University.Domain.Common;

namespace University.Domain.Entities
{
    public class City : BaseEntity
    {
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

    }
}

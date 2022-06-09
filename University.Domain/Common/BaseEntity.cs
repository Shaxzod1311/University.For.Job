using System;

namespace University.Domain.Common
{
    public class BaseEntity
    {
        public Guid Id { get; set; } = new Guid();
        public DateTime CreatedDate { get; set; }
        public DateTime LastUpdatedDate { get; set; }
        public bool IsDeleted { get; set; } = false;

        public void Create()
        {
            CreatedDate = DateTime.Now;
        }
        
        public void Update()
        {
            LastUpdatedDate = DateTime.Now;
        }
    }
}

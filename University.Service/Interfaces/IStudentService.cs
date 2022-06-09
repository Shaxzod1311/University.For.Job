using University.Domain.Entities;
using University.Service.DTOs;

namespace University.Service.Interfaces
{
    public interface IStudentService : IGenericService<Student, StudentDTO>
    {
    }
}

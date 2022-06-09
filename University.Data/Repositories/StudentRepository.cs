using University.Data.IRepositories;
using University.Domain.Entities;

namespace University.Data.Repositories
{
    public class StudentRepository : GenericRepository<Student>, IStudentRepository
    {

    }
}

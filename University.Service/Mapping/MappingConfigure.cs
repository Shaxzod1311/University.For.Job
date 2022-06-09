using AutoMapper;
using University.Domain.Entities;
using University.Service.DTOs;

namespace University.Service.Mapping
{
    public class MappingConfigure : Profile
    {
        public MappingConfigure()
        {
            CreateMap<Teacher, TeacherDTO>().ReverseMap();
            CreateMap<Student, StudentDTO>().ReverseMap();
            CreateMap<Department, DepartmentDTO>().ReverseMap();
            CreateMap<City, CityDTO>().ReverseMap();
            CreateMap<Subject, StudentDTO>().ReverseMap();
        }
    }
}

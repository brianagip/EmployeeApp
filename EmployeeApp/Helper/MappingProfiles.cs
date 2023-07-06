using AutoMapper;
using EmployeeApp.Dto;
using EmployeeApp.Models;

namespace EmployeeApp.Helper
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<Employee, EmployeeDto>();
            CreateMap<EmployeeDto, Employee>();
        }
    }
}

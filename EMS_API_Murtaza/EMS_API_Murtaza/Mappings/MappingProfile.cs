using AutoMapper;
using EMS_API_Murtaza.Models;
using EMS_API_Murtaza.DTOs;

namespace EMS_API_Murtaza.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Employee, EmployeeDto>().ReverseMap();
        }
    }
}

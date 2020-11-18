using AutoMapper;
using MasGlobalConsulting.Api.DataContracts.Output;
using MasGlobalConsulting.Domain;

namespace MasGlobalConsulting.Api.Profiles
{
    public class EmployeeOutputProfile : Profile
    {
        public EmployeeOutputProfile()
        {
            CreateMap<Employee, EmployeeOutput>()
                .ForMember(dest => dest.Id, opts => opts.MapFrom(src => src.Id))
                .ForMember(dest => dest.Name, opts => opts.MapFrom(src => src.Name))
                .ForMember(dest => dest.AnualSalary, opts => opts.MapFrom(src => src.AnualSalary))
                .ForMember(dest => dest.Role, opts => opts.MapFrom(src => src.Role))
                .ForMember(dest => dest.Contract, opts => opts.MapFrom(src => src.Contract));
        }
    }
}

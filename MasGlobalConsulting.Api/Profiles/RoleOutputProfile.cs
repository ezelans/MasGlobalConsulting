using AutoMapper;
using MasGlobalConsulting.Api.DataContracts.Output;
using MasGlobalConsulting.Domain;

namespace MasGlobalConsulting.Api.Profiles
{
    public class RoleOutputProfile : Profile
    {
        public RoleOutputProfile()
        {
            CreateMap<Role, RoleOutput>()
                .ForMember(dest => dest.Id, opts => opts.MapFrom(src => src.Id))
                .ForMember(dest => dest.Name, opts => opts.MapFrom(src => src.Name))
                .ForMember(dest => dest.Description, opts => opts.MapFrom(src => src.Description));
        }
    }
}

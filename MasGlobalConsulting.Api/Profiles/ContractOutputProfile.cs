using AutoMapper;
using MasGlobalConsulting.Api.DataContracts.Output;
using MasGlobalConsulting.Domain;

namespace MasGlobalConsulting.Api.Profiles
{
    public class ContractOutputProfile : Profile
    {
        public ContractOutputProfile()
        {
            CreateMap<Contract, ContractOutput>()
                .ForMember(dest => dest.Type, opts => opts.MapFrom(src => src.ContractTypeName));
        }
    }
}

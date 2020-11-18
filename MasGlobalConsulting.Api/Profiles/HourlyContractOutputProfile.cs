using AutoMapper;
using MasGlobalConsulting.Api.DataContracts.Output;
using MasGlobalConsulting.Domain;

namespace MasGlobalConsulting.Api.Profiles
{
    public class HourlyContractOutputProfile : Profile
    {
        public HourlyContractOutputProfile()
        {
            CreateMap<HourlyContract, HourlyContractOutput>()
                .IncludeBase<Contract, ContractOutput>()
                .ForMember(dest => dest.HourlySalary, opts => opts.MapFrom(src => src.HourlySalary));
        }
    }
}

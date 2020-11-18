using AutoMapper;
using MasGlobalConsulting.Api.DataContracts.Output;
using MasGlobalConsulting.Domain;

namespace MasGlobalConsulting.Api.Profiles
{
    public class MonthlyContractOutputProfile : Profile
    {
        public MonthlyContractOutputProfile()
        {
            CreateMap<MonthlyContract, MonthlyContractOutput>()
                .IncludeBase<Contract, ContractOutput>()
                .ForMember(dest => dest.MonthlySalary, opts => opts.MapFrom(src => src.MonthlySalary));
                ;
        }
    }
}

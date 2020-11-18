using System.Runtime.Serialization;

namespace MasGlobalConsulting.Api.DataContracts.Output
{
    [DataContract]
    public class MonthlyContractOutput : ContractOutput
    {
        [DataMember]
        public decimal MonthlySalary { get; set; }
    }
}

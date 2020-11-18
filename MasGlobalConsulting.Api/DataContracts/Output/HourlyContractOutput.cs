using System.Runtime.Serialization;

namespace MasGlobalConsulting.Api.DataContracts.Output
{
    [DataContract]
    public class HourlyContractOutput : ContractOutput
    {
        [DataMember]
        public decimal HourlySalary { get; set; }
    }
}

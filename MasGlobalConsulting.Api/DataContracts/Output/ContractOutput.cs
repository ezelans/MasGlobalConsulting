using System.Runtime.Serialization;

namespace MasGlobalConsulting.Api.DataContracts.Output
{
    [DataContract]
    [KnownType(typeof(MonthlyContractOutput))]
    [KnownType(typeof(HourlyContractOutput))]
    public class ContractOutput
    {
        [DataMember]
        public string Type { get; set; }
    }
}

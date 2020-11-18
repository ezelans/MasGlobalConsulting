
using System.Runtime.Serialization;

namespace MasGlobalConsulting.Api.DataContracts.Output
{
    [DataContract]
    public class EmployeeOutput
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public decimal AnualSalary { get; set; }
        [DataMember]
        public RoleOutput Role { get; set; }
        [DataMember]
        public ContractOutput Contract { get; set; }
    }
}

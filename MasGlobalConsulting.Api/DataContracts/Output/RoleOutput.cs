using System.Runtime.Serialization;

namespace MasGlobalConsulting.Api.DataContracts.Output
{
    [DataContract]
    public class RoleOutput
    {
        [DataMember]
        public string Id { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string Description { get; set; }
    }
}

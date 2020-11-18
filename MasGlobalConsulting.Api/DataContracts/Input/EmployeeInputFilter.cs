namespace MasGlobalConsulting.Api.DataContracts.Input
{
    public class EmployeeInputFilter
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int RoleId { get; set; }
        public string RoleName { get; set; }
        public string ContractTypeName { get; set; }
        public decimal Salary { get; set; }
    }
}

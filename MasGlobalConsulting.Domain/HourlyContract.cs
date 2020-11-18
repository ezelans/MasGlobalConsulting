namespace MasGlobalConsulting.Domain
{
    public class HourlyContract : Contract
    {
        public decimal HourlySalary { get; }

        public HourlyContract(string contractTypeName, decimal salary) : base (contractTypeName)
        {
            HourlySalary = salary;
        }

        public override decimal GetAnualSalary()
        {
            return 120 * HourlySalary * months;
        }
    }
}

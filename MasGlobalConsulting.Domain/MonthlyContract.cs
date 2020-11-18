namespace MasGlobalConsulting.Domain
{
    public class MonthlyContract : Contract
    {
        public decimal MonthlySalary { get; }

        public MonthlyContract(string contractTypeName, decimal salary) : base(contractTypeName)
        {
            MonthlySalary = salary;
        }

        public override decimal GetAnualSalary()
        {
            return MonthlySalary * months;
        }
    }
}

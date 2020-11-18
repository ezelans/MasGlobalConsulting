namespace MasGlobalConsulting.Domain.Factories
{
    public class MonthlyContractCreator : ContractCreator
    {
        protected override Contract MakeContract(string contractTypeName, decimal salary)
        {
            return new MonthlyContract(contractTypeName, salary);
        }

    }
}

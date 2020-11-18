namespace MasGlobalConsulting.Domain.Factories
{
    public class HourlyContractCreator : ContractCreator
    {
        protected override Contract MakeContract(string contractTypeName, decimal salary)
        {
            return new HourlyContract(contractTypeName, salary);
        }
    }
}
namespace MasGlobalConsulting.Domain.Factories
{
    public abstract class ContractCreator
    {
        protected abstract Contract MakeContract(string contractTypeName, decimal salary);

        public Contract CreateContract(string contractTypeName, decimal salary)
        {
            return this.MakeContract(contractTypeName, salary);
        }
    }
}
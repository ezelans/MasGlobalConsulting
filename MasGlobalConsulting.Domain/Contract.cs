namespace MasGlobalConsulting.Domain
{
    public abstract class Contract
    {
        protected int months = 12;
        public string ContractTypeName { get; }

        public Contract(string contractTypeName)
        {
            ContractTypeName = contractTypeName;
        }

        public abstract decimal GetAnualSalary();
    }
}

namespace MasGlobalConsulting.Data.Repositories.Contracts
{
    public interface IFacadeRepository
    {
        public IEmployeesRepository EmployeesRepository { get; }
    }
}

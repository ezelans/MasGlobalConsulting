
using MasGlobalConsulting.Data.Repositories.Contracts;

namespace MasGlobalConsulting.Data
{
    public class FacadeRepository : IFacadeRepository
    {
        public IEmployeesRepository EmployeesRepository { get; }


        public FacadeRepository(IEmployeesRepository employeesRepository)
        {
            EmployeesRepository = employeesRepository;
        }
    }
}

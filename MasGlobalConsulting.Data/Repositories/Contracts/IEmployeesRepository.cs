using System.Collections.Generic;
using System.Threading.Tasks;

namespace MasGlobalConsulting.Data.Repositories.Contracts
{
    public interface IEmployeesRepository
    {
        public Task<IEnumerable<Models.Employee>> Find(int id, string name, int roleId, string roleName, string contractTypeName, decimal salary);
    }
}

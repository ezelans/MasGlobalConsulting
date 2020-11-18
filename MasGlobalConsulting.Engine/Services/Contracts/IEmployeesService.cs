using MasGlobalConsulting.Domain;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MasGlobalConsulting.Engine.Services.Contracts
{
    public interface IEmployeesService
    {
        Task<IEnumerable<Employee>> Find(int id, string name, int roleId, string roleName, string contractTypeName, decimal salary);
    }
}
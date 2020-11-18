using MasGlobalConsulting.Data.Repositories.Contracts;
using MasGlobalConsulting.Domain;
using MasGlobalConsulting.Engine.Services.Contracts;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MasGlobalConsulting.Engine.Services
{
    public class EmployeesService : IEmployeesService
    {
        private readonly IFacadeRepository _facadeRepository;
        public EmployeesService(IFacadeRepository facadeRepository)
        {
            _facadeRepository = facadeRepository;
        }

        public async Task<IEnumerable<Employee>> Find(int id, string name, int roleId, string roleName, string contractTypeName, decimal salary)
        {
            var employees = new List<Employee>();
            var dataEmployees = await _facadeRepository.EmployeesRepository.Find(id, name, roleId, roleName, contractTypeName, salary);

            foreach (var dataEmployee in dataEmployees)
            {
                var employee = new Employee(dataEmployee);
                employees.Add(employee);
            }

            return employees;
        }

    }

}
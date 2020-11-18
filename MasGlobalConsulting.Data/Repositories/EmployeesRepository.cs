using MasGlobalConsulting.Data.Models;
using MasGlobalConsulting.Data.Repositories.Contracts;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace MasGlobalConsulting.Data.Repositories
{
    public class EmployeesRepository : IEmployeesRepository
    {
        public async Task<IEnumerable<Employee>> Find(int id, string name, int roleId, string roleName, string contractTypeName, decimal salary)
        {
            var employees = new List<Employee>();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("http://masglobaltestapi.azurewebsites.net/api/Employees"))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    employees = JsonConvert.DeserializeObject<List<Employee>>(apiResponse);
                }
            }

            if (id > 0)
                employees = employees.FindAll(x => x.Id == id);

            if(!string.IsNullOrWhiteSpace(name))
                employees = employees.FindAll(x => x.Name == name);

            if (roleId > 0)
                employees = employees.FindAll(x => x.RoleId == roleId);

            if (!string.IsNullOrWhiteSpace(roleName))
                employees = employees.FindAll(x => x.RoleName == roleName);

            if (!string.IsNullOrWhiteSpace(contractTypeName))
                employees = employees.FindAll(x => x.ContractTypeName == contractTypeName);

            if (salary > 0)
                employees = employees.FindAll(x => x.MonthlySalary == salary || x.HourlySalary == salary);

            return employees;
        }
    }
}

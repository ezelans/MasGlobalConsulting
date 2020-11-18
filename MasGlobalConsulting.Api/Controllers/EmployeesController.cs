using MasGlobalConsulting.Api.DataContracts.Input;
using MasGlobalConsulting.Api.DataContracts.Output;
using MasGlobalConsulting.Api.Filters;
using MasGlobalConsulting.Domain;
using MasGlobalConsulting.Engine.Services.Contracts;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace MasGlobalConsulting.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private readonly IEmployeesService _employeesService;
        public EmployeesController(IEmployeesService employeesService)
        {
            _employeesService = employeesService;
        }

        /// <summary>
        /// Gets a list of employees with their data
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [ProducesResponseType(typeof(IEnumerable<EmployeeOutput>), (int)HttpStatusCode.OK)]
        [CustomResultFilter(typeof(IEnumerable<Employee>), typeof(IEnumerable<EmployeeOutput>))]
        public async Task<IActionResult> Get([FromQuery] EmployeeInputFilter search)
        {
            var employees = await _employeesService.Find( search.Id, 
                                                            search.Name,
                                                            search.RoleId,
                                                            search.RoleName,
                                                            search.ContractTypeName,
                                                            search.Salary);

            if (employees == null && employees.Any())
                return NotFound();

            return Ok(employees);
        }
    }
}

using MasGlobalConsulting.Data.Models;
using MasGlobalConsulting.Domain;
using NUnit.Framework;

namespace MasGlobalConsulting.Test
{
    public class EmployeeCreatorTest
    {
        Data.Models.Employee dataEmployee;
        public EmployeeCreatorTest()
        {
            dataEmployee = new Data.Models.Employee
            {
                Id = 1,
                Name = "Juan",
                HourlySalary = 60000,
                MonthlySalary = 80000,
                RoleDescription = "",
                RoleId = 1,
                RoleName = "Administrator"
            };
        }

        [Test]
        public void ShouldGetMonthlySalaryEmployee()
        {
            //act
            dataEmployee.ContractTypeName = "MonthlySalaryEmployee";
            var employee = new Domain.Employee(dataEmployee);

            //assert
            Assert.AreEqual(dataEmployee.Id, employee.Id);
            Assert.AreEqual(dataEmployee.Name, employee.Name);
            Assert.AreEqual(dataEmployee.RoleDescription, employee.Role.Description);
            Assert.AreEqual(dataEmployee.RoleId, employee.Role.Id);
            Assert.AreEqual(employee.Contract.GetType(), typeof(MonthlyContract));
        }

        public void ShouldGetHourlySalaryEmployee()
        {
            //act
            dataEmployee.ContractTypeName = "HourlySalaryEmployee";
            var employee = new Domain.Employee(dataEmployee);

            //assert
            Assert.AreEqual(dataEmployee.Id, employee.Id);
            Assert.AreEqual(dataEmployee.Name, employee.Name);
            Assert.AreEqual(dataEmployee.RoleDescription, employee.Role.Description);
            Assert.AreEqual(dataEmployee.RoleId, employee.Role.Id);
            Assert.AreEqual(employee.Contract.GetType(), typeof(HourlyContract));
        }
    }
}

using MasGlobalConsulting.Data.Models;
using MasGlobalConsulting.Domain.Enums;
using MasGlobalConsulting.Domain.Factories;
using System;

namespace MasGlobalConsulting.Domain
{
    public class Employee
    {
        public int Id { get; }
        public string Name { get; }
        public Role Role { get; }
        public Contract Contract { get; }
        public decimal AnualSalary => this.Contract.GetAnualSalary();

        public Employee(Data.Models.Employee dataEmployee)
        {
            Id = dataEmployee.Id;
            Name = dataEmployee.Name;
            Role = new Role(dataEmployee.RoleId, dataEmployee.RoleName, dataEmployee.RoleDescription);
            
            if (Enum.TryParse(dataEmployee.ContractTypeName, true, out ContractEmployeeType contractEmployeeType))
            {
                Contract = GetContract(contractEmployeeType, dataEmployee.HourlySalary, dataEmployee.MonthlySalary);
            }
        }

        private Contract GetContract(ContractEmployeeType contractEmployeeType, decimal hourlySalary, decimal monthlySalary)
        {
            switch (contractEmployeeType)
            {
                case ContractEmployeeType.HourlySalaryEmployee:
                    {
                        return new HourlyContractCreator().CreateContract(ContractEmployeeType.HourlySalaryEmployee.ToString(), hourlySalary);
                    }
                case ContractEmployeeType.MonthlySalaryEmployee:
                    {
                        return new MonthlyContractCreator().CreateContract(ContractEmployeeType.MonthlySalaryEmployee.ToString(), monthlySalary);
                    }
                default:
                    throw new NotSupportedException();
            }
        }
    }
}

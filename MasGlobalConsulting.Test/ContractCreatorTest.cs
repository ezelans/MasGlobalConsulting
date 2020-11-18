using MasGlobalConsulting.Domain;
using MasGlobalConsulting.Domain.Enums;
using MasGlobalConsulting.Domain.Factories;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace MasGlobalConsulting.Test
{
    public class ContractCreatorTest
    {
        int months = 12;
        decimal hourlySalary = 6000;
        decimal monthlySalary = 80000;

        [Test]
        public void ShouldGetHourlyContract()
        {
            //act
            var contract = new HourlyContractCreator().CreateContract(ContractEmployeeType.HourlySalaryEmployee.ToString(), hourlySalary);

            //assert
            Assert.AreEqual(typeof(HourlyContract), contract.GetType());
            Assert.AreEqual(120 * hourlySalary * months, contract.GetAnualSalary());
        }

        [Test]
        public void ShouldGetMonthlyContract()
        {
            //act
            var contract = new MonthlyContractCreator().CreateContract(ContractEmployeeType.MonthlySalaryEmployee.ToString(), monthlySalary);

            //assert
            Assert.AreEqual(typeof(MonthlyContract), contract.GetType());
            Assert.AreEqual(monthlySalary * months, contract.GetAnualSalary());
        }
    }
}

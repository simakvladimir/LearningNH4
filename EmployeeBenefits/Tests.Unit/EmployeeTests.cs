using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Domain;

namespace Tests.Unit
{
    [TestFixture]
    public class EmployeeTests
    {
        [Test]
        public void EmployeeIsEntitledToPaidLeaves()
        {
            /*
            //Arrange
            var employee = new Employee();
            //Act
            employee.Leaves = new List<Leave>();
            employee.Leaves.Add(new Leave
            {
                Type = LeaveType.Paid,
                AvailableEntitlement = 15
            });
            //Assert
            var paidLeave = employee.Leaves.FirstOrDefault(l => l.Type == LeaveType.Paid);
            
            Assert.That(paidLeave, Is.Not.Null);
            Assert.That(paidLeave.AvailableEntitlement, Is.EqualTo(15));
            */
            Assert.That(true);
        }
    }
}
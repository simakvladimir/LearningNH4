using System;
using Domain;
using NHibernate;
using NUnit.Framework;

namespace Tests.Unit.Mappings.Xml
{
    [TestFixture]
    public class EmployeeMappingsTests
    {
        private InMemoryDatabaseForXmlMappings database;
        private ISession session;

        [OneTimeSetUp]
        public void Setup()
        {
            database = new InMemoryDatabaseForXmlMappings();
            session = database.Session;
        }

        [Test]
        public void MapsPrimitiveProperties()
        {
            object id = 0;
            using (var transaction = session.BeginTransaction())
            {
                id = session.Save(new Employee
                {
                    EmployeeNumber = "5987123",
                    Firstname = "Hillary",
                    Lastname = "Gamble",
                    EmailAddress = "hillary.gamble@corporate.com",
                    DateOfBirth = new DateTime(1980, 4, 23),
                    DateOfJoining = new DateTime(2010, 7, 12),
                    IsAdmin = true,
                    Password = "Password"
                });
                transaction.Commit();
            }
            session.Clear();

            using (var transaction = session.BeginTransaction())
            {
                var employee = session.Get<Employee>(id);
                Assert.That(employee.EmployeeNumber,
                Is.EqualTo("5987123"));
                Assert.That(employee.Firstname, Is.EqualTo("Hillary"));
                Assert.That(employee.Lastname, Is.EqualTo("Gamble"));
                Assert.That(employee.EmailAddress, Is.EqualTo("hillary.gamble@corporate.com"));
                Assert.That(employee.DateOfBirth.Year, Is.EqualTo(1980));
                Assert.That(employee.DateOfBirth.Month, Is.EqualTo(4));
                Assert.That(employee.DateOfBirth.Day, Is.EqualTo(23));
                Assert.That(employee.DateOfJoining.Year,
                Is.EqualTo(2010));
                Assert.That(employee.DateOfJoining.Month, Is.EqualTo(7));
                Assert.That(employee.DateOfJoining.Day, Is.EqualTo(12));
                Assert.That(employee.IsAdmin, Is.True);
                Assert.That(employee.Password, Is.EqualTo("Password"));
                transaction.Commit();
            }
        }
    }
}

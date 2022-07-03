using Microsoft.Extensions.Configuration;
using Moq;
using RepairShop.Core.Entities;
using RepairShop.Infrastructure.Repositories;
using RepairShop.Infrastructure.Wrappers;
using System.Data;

namespace RepairShop.Infrastructure.Tests
{
    public class CustomerRespoitoryTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void GetCustomerTest_ReturnsCustomersFromQueryUsingExpectedSQLQueryAndConnectionString()
        {
            //arrange
            var mockDapper = new Mock<IDapperWrapper>();
            var mockConfSection = new Mock<IConfigurationSection>();
            mockConfSection.SetupGet(m => m[It.Is<string>(s => s == "default")]).Returns("mock value");

            var mockConfiguration = new Mock<IConfiguration>();
            mockConfiguration.Setup(a => a.GetSection(It.Is<string>(s => s == "ConnectionStrings"))).Returns(mockConfSection.Object);
            var expectedConnectionString = @"Server=SERVERNAME;Database=TESTDB;Integrated Security=true;";
            var expectedQuery = "SELECT Name, Description, RuntimeMinutes, Year FROM Movies";
            var repo = new CustomerRepository(mockConfiguration.Object, mockDapper.Object);
            var expectedCustomers = new List<Customer>() { new Customer() { Name = "Test" } };

            mockDapper.Setup(t => t.Query<Customer>((IConfiguration)mockConfiguration, expectedQuery))
                .Returns(expectedCustomers);

            //act
            var customers = repo.GetAllAsync();

            //assert
            Assert.AreSame(expectedCustomers, customers);
        }
    }
}
using Microsoft.EntityFrameworkCore;
using Moq;
using SelectBoxAPI.Data;
using SelectBoxDomain.Models;
using SelectBoxAPI.Data.Repository.EntityFramework;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace SelectBoxTests
{
    [TestClass]
    public class SelectBoxTests
    {


        [TestMethod]
        public void PostCustomer_saves_a_customer_via_context()
        {

            var mockSet = new Mock<DbSet<Customer>>();

            var mockContext = new Mock<SelectBoxAPIContext>();
            mockContext.Setup(m => m.Customers).Returns(mockSet.Object);

            var service = new CustomerRepository(mockContext.Object);
            _ = service.PostCustomerAsync(new Customer() { CustomerId=1, CustomerAuth="192864asf", CustomerName="Test"});

            mockSet.Verify(m => m.Add(It.IsAny<Customer>()), Times.Once());
            mockContext.Verify(m => m.SaveChanges(), Times.Once());
        }

        [TestMethod]
        public void GetAllCustomers_by_name()
        {
            var data = new List<Customer>
            {
                new Customer { CustomerId=1, CustomerAuth="192864asfwrg", CustomerName="AAA"},
                new Customer { CustomerId=2, CustomerAuth="1247h2864asf", CustomerName="ZZZ"},
                new Customer { CustomerId=3, CustomerAuth="19wedf64hjef", CustomerName="BBB"},
            }.AsQueryable();

            var mockSet = new Mock<DbSet<Customer>>();
            mockSet.As<IQueryable<Customer>>().Setup(m => m.Provider).Returns(data.Provider);
            mockSet.As<IQueryable<Customer>>().Setup(m => m.Expression).Returns(data.Expression);
            mockSet.As<IQueryable<Customer>>().Setup(m => m.ElementType).Returns(data.ElementType);
            mockSet.As<IQueryable<Customer>>().Setup(m => m.GetEnumerator()).Returns(data.GetEnumerator());

            var mockContext = new Mock<SelectBoxAPIContext>();
            mockContext.Setup(c => c.Customers).Returns(mockSet.Object);

            var service = new CustomerRepository(mockContext.Object);
            var customers = service.GetCustomers().ToList();

            Assert.AreEqual(3, customers.Count);
            Assert.AreEqual("AAA", customers[0].CustomerName);
            Assert.AreEqual("BBB", customers[1].CustomerName);
            Assert.AreEqual("ZZZ", customers[2].CustomerName);
        }
    }
    
}

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using TestNinja.Fundamentals;
using Assert = NUnit.Framework.Assert;

namespace TestNinja.Tests
{
    [TestFixture]
    public class CustomerControllerTests
    {
        [Test]
        public void GetCustomer_IdIsZero_ReturnNotFound()
        {

            var customerController = new CustomerController();
            var result=  customerController.GetCustomer(0);
            Assert.That(result, Is.InstanceOf<NotFound>());

        }

        [Test]
        public void GetCustomer_IdIsNotZero_ReturnOK()
        {
            var customerController = new CustomerController();
            var result = customerController.GetCustomer(5);
            Assert.That(result, Is.TypeOf<Ok>());
        }
    }
}

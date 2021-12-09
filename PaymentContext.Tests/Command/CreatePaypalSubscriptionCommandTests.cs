using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PaymentContext.Domain.Commands;

namespace PaymentContext.Tests.Command
{
   [TestClass]
    public class CreatePaypalSubscriptionCommandTests
    {
        //RED - GREEN - REFACTOR 
        [TestMethod]
        public void ShouldReturnSucessWhenCreatePaypalSubscriptionCommandIsValid(){
            //Arrange 
            var command = new CreatePaypalSubscriptionCommand();
            //Act //Assert
            Assert.IsTrue(command.IsValid);
        }
   
    }
}
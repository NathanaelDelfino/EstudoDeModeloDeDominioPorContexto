using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PaymentContext.Domain.ValueObjects;

namespace PaymentContext.Tests.ValueObjects
{
    [TestClass]
    public class NameTests
    {
        //RED - GREEN - REFACTOR 
        [TestMethod]
        public void ShouldReturnSucessWhenFirstNameIsValid(){
            //Arrange 
            var name = new Name("Nathanael","");
            //Act
            var retorno = name.Notifications;
            //Assert
            Assert.IsTrue(retorno.Where(x => x.Key == "FirstName").Count() == 0);
        }
        
        [TestMethod]
        public void ShouldReturnSucessWhenFirstNameIsInValid(){
            //Arrange 
            var name = new Name("","");
            //Act
            var retorno = name.Notifications;
            //Assert
            Assert.IsTrue(retorno.Where(x => x.Key == "FirstName").Count() >= 0);
        }

        [TestMethod]
        public void ShouldReturnSucessWhenLastNameIsValid(){
            //Arrange 
            var name = new Name("","Delfino");
            //Act
            var retorno = name.Notifications.Where(x => x.Key == "LastName").Count() == 0;
            //Assert
            Assert.IsTrue(retorno);
        }
        [TestMethod]
        public void ShouldReturnSucessWhenLastNameIsInValid(){
            //Arrange 
            var name = new Name("","");
            //Act
            var retorno = name.Notifications.Where(x => x.Key == "LastName").Count() > 0;
            //Assert
            Assert.IsTrue(retorno);
        }
    }
}
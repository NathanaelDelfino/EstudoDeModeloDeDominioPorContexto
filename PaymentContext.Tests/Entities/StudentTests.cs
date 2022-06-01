using Microsoft.VisualStudio.TestTools.UnitTesting;
using PaymentContext.Domain.Entities;
using PaymentContext.Domain.Enums;
using PaymentContext.Domain.ValueObjects;

namespace PaymentContext.Tests;

[TestClass]
public class StudentTests
{
    [TestMethod]
    public void ShouldReturnsSucessWhereStudentIsValid()
    {
        //Arrange
        var subscription = new Subscription(System.DateTime.Now);
        var name = new Name("Nathanael", "Delfino");
        var document = new Document("00000000000", EDocumentType.CPF);
        var email = new Email("nathan@gmail.com");
        var address = new Address("", "", "", "", "", "", "");
        var student = new Student(name, document, email, address);
        //Act
        var retorno = student.Notifications;
        //Assert
        Assert.IsTrue(retorno.Count == 0);
    }
    [TestMethod]
    public void ShouldReturnsErrorWhereStudentIsValid()
    {
        //Arrange
        var subscription = new Subscription(System.DateTime.Now);
        var name = new Name("", "Delfino");
        var document = new Document("00000000000", EDocumentType.CPF);
        var email = new Email("nathan@gmail.com");
        var address = new Address("", "", "", "", "", "", "");
        var student = new Student(name, document, email, address);
        //Act
        var retorno = student.Notifications;
        //Assert
        Assert.IsFalse(retorno.Count == 0);
    }
}
using PaymentContext.Domain.Commands;
using PaymentContext.Domain.Entities;
using PaymentContext.Domain.Handlers;
using PaymentContext.Domain.ValueObjects;
using PaymentContext.Tests.Mocks;

namespace PaymentContext.Tests.Handlers;

[TestClass]
public class SubscriptionHandlerTests
{
    [TestMethod]
    public void ShouldReturnErrorWhenDocumentExists()
    {
        var handler = new SubscriptionHandler(new FakeStudentRepository(), new FakeEmailService());
        var command = new CreateBoletoSubscriptionCommand();
        command.FirstName = "Bruce";
        command.LastName = "Wayne";
        command.Document = "99999999999";
        command.Email = "hello@balta.io";
        command.BarCode = "123456789";
        command.BoletoNumber = "5645644546564454564";
        command.PaymentNumber = "1235";
        command.PaidDate = DateTime.Now;
        command.ExpireDate = DateTime.Now.AddMonths(1);
        command.Total = 60;
        command.TotalPaid = 60;
        command.Payer = "Wayne Corp";
        command.PayerDocument = "12345678912";
        command.PayerDocumentType = Domain.Enums.EDocumentType.CPF;
        command.PayerEmail = "batman@dc.com";
        command.Street = "rua teste";
        command.Number = "10";
        command.Neighborhood = "Bairro teste";
        command.City = "Gotham City";
        command.State = "NK";
        command.Country = "USA";
        command.ZipCode = "000215458";

        handler.Handle(command);
        Assert.AreEqual(false, handler.Valid);
    }


}
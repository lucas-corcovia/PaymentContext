using PaymentContext.Domain.Entities;
using PaymentContext.Domain.ValueObjects;

namespace PaymentContext.ValueObjects.Tests;

[TestClass]
public class DocumentTests
{
    [TestMethod]
    public void ShouldReturnErrorWhenCNPJIsInvalid()
    {
        var doc = new Document("123", Domain.Enums.EDocumentType.CNPJ);
        Assert.IsTrue(doc.Invalid);
    }

    [TestMethod]
    public void ShouldReturnErrorWhenCNPJIsValid()
    {
        var doc = new Document("71954813000169", Domain.Enums.EDocumentType.CNPJ);
        Assert.IsTrue(doc.Valid);
    }

    [TestMethod]
    public void ShouldReturnErrorWhenCPFIsInvalid()
    {
        var doc = new Document("123", Domain.Enums.EDocumentType.CPF);
        Assert.IsTrue(doc.Invalid);
    }

    [TestMethod]
    public void ShouldReturnErrorWhenCPFIsValid()
    {
        var doc = new Document("51626614067", Domain.Enums.EDocumentType.CPF);
        Assert.IsTrue(doc.Valid);
    }
}
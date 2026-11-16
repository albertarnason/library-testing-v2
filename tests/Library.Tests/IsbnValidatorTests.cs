using Library.Core;

namespace Library.Tests;

[TestClass]
public class IsbnValidatorTests
{
    [TestMethod]
    public void IsValid_GyldigtIsbn13_ReturnererTrue()
    {
        // Arrange
        var isbn = "9780306406157";

        // Act
        var result = IsbnValidator.IsValid(isbn);

        // Assert
        Assert.IsTrue(result);
    }

    [TestMethod]
    public void IsValid_IsbnMedBindestreger_ReturnererTrue()
    {
        // Arrange
        string? isbn = "978-0-306-40615-7";

        // Act
        var result = IsbnValidator.IsValid(isbn);

        // Assert
        Assert.IsTrue(result);
    }

    [TestMethod]
    public void IsValid_ForkertKontrolciffer_ReturnererFalse()
    {
        // Arrange
        string? isbn = "9780306406158";

        // Act
        var result = IsbnValidator.IsValid(isbn);

        // Assert
        Assert.IsFalse(result);
    }

    [TestMethod]
    public void IsValid_ForKortLaengde12Cifre_ReturnererFalse()
    {
        // Arrange
        string? isbn = "978030640615";

        // Act
        var result = IsbnValidator.IsValid(isbn);

        // Assert
        Assert.IsFalse(result);
    }

    [TestMethod]
    public void IsValid_TomStreng_ReturnererFalse()
    {
        // Arrange
        string? isbn = "";

        // Act
        var result = IsbnValidator.IsValid(isbn);

        // Assert
        Assert.IsFalse(result);
    }

    [TestMethod]
    public void IsValid_Null_ReturnererFalse()
    {
        // Arrange
        string? isbn = null;

        // Act
        var result = IsbnValidator.IsValid(isbn);

        // Assert
        Assert.IsFalse(result);
    }

    [TestMethod]
    public void IsValid_BogstavIIsbn_ReturnererFalse()
    {
        // Arrange
        string? isbn = "97803064061X7";

        // Act
        var result = IsbnValidator.IsValid(isbn);

        // Assert
        Assert.IsFalse(result);
    }
}

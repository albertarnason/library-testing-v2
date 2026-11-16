namespace Library.Tests;

[TestClass]
public class CiDemoTests
{
    [TestMethod]
    public void Addition_ToPlusTo_GiverFem()
    {
        // Arrange
        var a = 2;
        var b = 2;

        // Act
        var sum = a + b;

        // Assert
        Assert.AreEqual(5, sum);
    }
}

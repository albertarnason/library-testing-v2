using Library.Core;

namespace Library.Tests;

[TestClass]
public class FeeCalculatorTests
{
    private readonly FeeCalculator _calculator = new();
    private readonly DateTime _due = new(2026, 11, 30);

    [TestMethod]
    public void Calculate_AfleveretTilTiden_Returnerer0()
    {
        decimal fee = _calculator.Calculate(_due, _due);

        Assert.AreEqual(0m, fee);
    }

    [TestMethod]
    public void Calculate_AfleveretFoerTid_Returnerer0()
    {
        var returned = new DateTime(2026, 11, 25);

        decimal fee = _calculator.Calculate(_due, returned);

        Assert.AreEqual(0m, fee);
    }

    [TestMethod]
    public void Calculate_EnDagForSent_Returnerer5()
    {
        var returned = new DateTime(2026, 12, 1);

        decimal fee = _calculator.Calculate(_due, returned);

        Assert.AreEqual(5m, fee);
    }

    [TestMethod]
    public void Calculate_TiDageForSent_Returnerer50()
    {
        var returned = new DateTime(2026, 12, 10);

        decimal fee = _calculator.Calculate(_due, returned);

        Assert.AreEqual(50m, fee);
    }

    [TestMethod]
    public void Calculate_30DageForSent_ReturnererMax100()
    {
        var returned = new DateTime(2026, 12, 30);

        decimal fee = _calculator.Calculate(_due, returned);

        Assert.AreEqual(100m, fee);
    }
}

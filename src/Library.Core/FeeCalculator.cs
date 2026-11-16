namespace Library.Core;

public class FeeCalculator
{
    private const decimal FeePerDay = 5m;

    public decimal Calculate(DateTime due, DateTime returned)
    {
        return returned > due ? FeePerDay : 0m;
    }
}

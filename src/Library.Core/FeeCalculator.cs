namespace Library.Core;

public class FeeCalculator
{
    private const decimal FeePerDay = 5m;
    private const decimal MaxFee = 100m;

    public decimal Calculate(DateTime due, DateTime returned)
    {
        var daysLate = Math.Max(0, (returned.Date - due.Date).Days);
        return Math.Min(MaxFee, daysLate * FeePerDay);
    }
}

namespace Currency.Services
{
    public interface ICurrencyService
    {
        int[] ConvertStringToArray(string input);
        CurrencyCalculation CalculateMaximumProfit(int[] array);
    }
}

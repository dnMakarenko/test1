using System;
using Currency.Services;

namespace Currency.Console
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ICurrencyService currencyService = new CurrencyService();
            bool isValid = false;

            System.Console.WriteLine($"Please, enter integer values separeted by the comma.");
            
            while (!isValid)
            {
                try
                {
                    var currencies = currencyService.ConvertStringToArray(System.Console.ReadLine());
                    var maximumProfit = currencyService.CalculateMaximumProfit(currencies);

                    System.Console.WriteLine($"output: buy at {maximumProfit.BuyIdx} value({maximumProfit.BuyPrice}) and sell at {maximumProfit.SellIdx} value({maximumProfit.SellPrice})  for a maximum profit of {maximumProfit.Profit}");
                    isValid = true;
                }
                catch (Exception e)
                {
                    System.Console.WriteLine(e.Message);
                }
                finally
                { 
                    if(!isValid)
                        System.Console.WriteLine("Please, enter minumum two(2) integer values separeted by the comma."); 
                }
            }
        }
    }
}

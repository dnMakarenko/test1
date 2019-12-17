namespace Currency.Services
{
    public class CurrencyCalculation
    {
        public int BuyPrice { get; set; }
        public int SellPrice { get; set; }
        public int BuyIdx { get; set; }
        public int SellIdx { get; set; }
        public int Profit => SellPrice - BuyPrice;
    }
}

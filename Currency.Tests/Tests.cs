using System;
using NUnit.Framework;
using Currency.Services;

namespace Currency.Tests
{
    public class Tests
    {
        private ICurrencyService _currencyService;

        [SetUp]
        public void Setup()
        {
            _currencyService = new CurrencyService();
        }

        [Test]
        public void ConvertStringToArrayTest()
        {
            string input = " 4, 2, 8, 6, 7, 12, 3, 25, 21, 30, 1 ";
            var array = ConvertStringToArray(input);

            Assert.IsNotNull(array);
            Assert.Pass();
        }

        [Test]
        public void CalculateMaximumProfitSuccessedTest()
        {
            string input = " 4, 2, 8, 6, 7, 12, 3, 25, 21, 30, 1 ";
            var array = ConvertStringToArray(input);

            var maximumProfit = CalculateMaximumProfit(array);

            Assert.AreEqual(28, maximumProfit.Profit);
            Assert.Pass();

        }

        [Test]
        public void CalculateDivideByZeroExceptionTest()
        {
            try
            {
                string input = " 4";
                var array = ConvertStringToArray(input);

                var maximumProfit = CalculateMaximumProfit(array);
            }
            catch (Exception e)
            {
                Assert.IsTrue(typeof(DivideByZeroException) == e.GetType());    
                Assert.Pass();
            }

            Assert.Fail();
        }

        [Test]
        public void ConvertStringToArrayFormatExceptionTest()
        {
            try
            {
                string input = " 4, 2, 8, 6, 7, 12, 3, 25, 21, 30, 1asdasd ";
                var array = ConvertStringToArray(input);
            }
            catch (Exception e)
            {
                Assert.IsTrue(typeof(FormatException) == e.GetType());
                Assert.Pass();
            }
        }

        private int[] ConvertStringToArray(string input)
        {
            var array = _currencyService.ConvertStringToArray(input);

            return array;
        }

        private CurrencyCalculation CalculateMaximumProfit(int[] array)
        {
            var result = _currencyService.CalculateMaximumProfit(array);

            return result;
        }

    }
}
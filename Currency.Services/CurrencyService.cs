using System;
using System.Collections.Generic;
using System.Linq;

namespace Currency.Services
{
    public class CurrencyService : ICurrencyService
    {
        /// <summary>
        /// Converts string to 32-bit integer array
        /// </summary>
        /// <param name="input">Represents string with array that will be converted</param>
        /// <returns>32-bit integer array</returns>
        public int[] ConvertStringToArray(string input)
        {
            try
            {
                var array = input.Split(",").ToList().Select(q => Convert.ToInt32(q)).ToArray();

                if (array.Length <= 1)
                {
                    throw new DivideByZeroException("Can't substract without value. Must have minumum two(2) integer values to substract.");
                }

                return array;
            }
            ///........
            ///........
            ///........
            catch (DivideByZeroException e)
            {
                throw e;
            }
            catch (FormatException e)
            {
                throw e;
            }
            catch (Exception e)
            {
                throw new Exception($"Error while parsing int array. {e.Message}");
            }
        }

        /// <summary>
        /// Calculate the best profit from array
        /// </summary>
        /// <param name="array">Represents 32-bit integer array</param>
        /// <returns>Returns object typeof(CurrencyCalculation) that represents best profit calculated from 32-bit integer array</returns>
        public CurrencyCalculation CalculateMaximumProfit(int[] array)
        {
            try
            {
                var maximumProfitResult = new CurrencyCalculation();
                int maximumProfit = 0;
                for (int first = 0; first < array.Length - 1; first++)
                {
                    for (int second = first + 1; second < array.Length; second++)
                    {
                        int profit = array[second] - array[first];
                        if (profit > maximumProfit)
                        {
                            maximumProfit = profit;
                            maximumProfitResult = new CurrencyCalculation
                            {
                                BuyPrice = array[first],
                                SellPrice = array[second],
                                BuyIdx = first + 1,
                                SellIdx = second + 1
                            };
                        }
                    }
                }

                return maximumProfitResult;
            }
            ///........
            ///........
            ///........
            catch (IndexOutOfRangeException e)
            {
                throw e;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}

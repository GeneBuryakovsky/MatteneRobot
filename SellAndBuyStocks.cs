using System;
using System.Collections.Generic;
using System.Configuration;
using RestSharp;

namespace MatteneRobot
{
    class SellAndBuyStocks
    {
        static void Main(string[] args)
        {
            List<string> stocks = new List<string>();

            stocks = SelectActiveStocks();
            string currentStockPrice = string.Empty;
            string lastSavedStockPrice = string.Empty;
            bool sellStock = false;

            foreach(var stock in stocks)
            {
                lastSavedStockPrice = GetLastSavedStockPrice(stock);
                currentStockPrice = GetCurrentStockPrice(stock);

                ProcessStock processStock = new ProcessStock(stock, lastSavedStockPrice, currentStockPrice);
                sellStock = processStock.DecideToSell(stock, lastSavedStockPrice, currentStockPrice);

                if (sellStock)
                    SellCurrentStock(stock, lastSavedStockPrice, currentStockPrice);
            }
        }

        private static List<string> SelectActiveStocks()
        {
            List<string> stocks = new List<string>();


            return stocks;
        }
        private static string GetLastSavedStockPrice(string stock)
        {
            string price = string.Empty;

            return price;
        }

        private static string GetCurrentStockPrice(string stock)
        {
            string price = string.Empty;
            return price;
        }

        private static string SellCurrentStock(string stock)
        {
            string receipt = string.Empty;

            return receipt;
        }
        
        private static void SellCurrentStock(string stock, string lastPrice, string currentPrice)
        {

        }
    }
}

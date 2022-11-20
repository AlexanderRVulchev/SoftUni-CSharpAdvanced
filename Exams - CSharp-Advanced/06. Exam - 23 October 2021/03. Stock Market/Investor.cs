using System;
using System.Collections.Generic;
using System.Linq;

namespace StockMarket
{
    public class Investor
    {
        public List<Stock> Portfolio { get; set; }
        public string FullName { get; set; }
        public string EmailAddress { get; set; }
        public decimal MoneyToInvest { get; set; }
        public string BrokerName { get; set; }
        public int Count { get { return this.Portfolio.Count; } }

        public Investor(string fullName, string emailAddress, decimal moneyToInvest, string brokerName)
        {
            this.MoneyToInvest = moneyToInvest;
            this.BrokerName = brokerName;
            this.FullName = fullName;
            this.EmailAddress = emailAddress;
            this.Portfolio = new List<Stock>();
        }

        public void BuyStock(Stock stock)
        {
            if (stock.MarketCapitalization > 10_000 && this.MoneyToInvest >= stock.PricePerShare)
            {
                this.MoneyToInvest -= stock.PricePerShare;
                this.Portfolio.Add(stock);
            }
        }

        public string SellStock(string companyName, decimal sellPrice)
        {
            if (!this.Portfolio.Any(s => s.CompanyName == companyName))
                return $"{companyName} does not exist.";

            Stock stockToSell = this.Portfolio.First(s => s.CompanyName == companyName);
            if (sellPrice < stockToSell.PricePerShare)
                return $"Cannot sell {companyName}.";

            this.Portfolio.Remove(stockToSell);
            this.MoneyToInvest += sellPrice;
            return $"{companyName} was sold.";
        }

        public Stock FindStock(string companyName)
            => this.Portfolio.Find(s => s.CompanyName == companyName);

        public Stock FindBiggestCompany()
            => this.Portfolio.OrderByDescending(s => s.MarketCapitalization).FirstOrDefault();

        public string InvestorInformation()
            => $"The investor {this.FullName} with a broker {this.BrokerName} has stocks:" +
               Environment.NewLine +
               string.Join(Environment.NewLine, this.Portfolio);
    }
}

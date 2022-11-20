using System;

namespace StockMarket
{
    public class Stock
    {
        public string CompanyName { get; set; }
        public string Director { get; set; }
        public decimal PricePerShare { get; set; }
        public int TotalNumberOfShares { get; set; }
        public decimal MarketCapitalization { get { return this.PricePerShare * this.TotalNumberOfShares; } }

        public Stock(string companyName, string director, decimal pricePerShare, int totalNumberOfshares)
        {
            this.CompanyName = companyName;
            this.Director = director;
            this.PricePerShare = pricePerShare;
            this.TotalNumberOfShares = totalNumberOfshares;
        }

        public override string ToString()
            => $"Company: {this.CompanyName}" + Environment.NewLine +
               $"Director: {this.Director}" + Environment.NewLine +
               $"Price per share: ${this.PricePerShare}" + Environment.NewLine +
               $"Market capitalization: ${this.MarketCapitalization}";
    }
}

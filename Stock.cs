using System.Diagnostics;
using System.Text;

namespace StockMarket
{
    public class Stock
    {
        private string companyName;
        private string director;
        private decimal pricePerShare;
        private int totalNumberOfShares;
        private decimal marketCapitalization;

        public string CompanyName { get => companyName; set => companyName = value; }
        public string Director { get => director; set => director = value; }
        public decimal PricePerShare { get => pricePerShare; set => pricePerShare = value; }
        public int TotalNumberOfShares { get => totalNumberOfShares; set => totalNumberOfShares = value; }
        public decimal MarketCapitalization { get => marketCapitalization; set => marketCapitalization = value; }

        public Stock(string CompanyName, string Director, decimal PricePerShare, int TotalNumberOfShares)
        {
            CompanyName = companyName;
            Director = director;
            PricePerShare = pricePerShare;
            TotalNumberOfShares = totalNumberOfShares;
            MarketCapitalization = PricePerShare + TotalNumberOfShares;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            {
                sb.Append("Company: " + this.CompanyName)
                  .Append("Director: " + this.Director)
                  .Append("Price per share: $" + this.PricePerShare)
                  .Append("Market capitalization: $" + this.MarketCapitalization);
                  
                  return sb.ToString();
         
            }


        }
    }
  
}

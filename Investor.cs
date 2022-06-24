using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace StockMarket
{
    public class Investor
    {
        private List<Stock> portfolio;
        private string fullName;
        private string emailAddress;
        private decimal moneyToInvest;
        private string brokerName;

        public List<Stock> Portfolio { get => portfolio; set => portfolio = value; }
        public string FullName { get => fullName; set => fullName = value; }
        public string EmailAddress { get => emailAddress; set => emailAddress = value; }
        public decimal MoneyToInvest { get => moneyToInvest; set => moneyToInvest = value; }
        public string BrokerName { get => brokerName; set => brokerName = value; }

        public Investor(string fullName, string emailAddress, decimal moneyToInvest, string brokerName)
        {
            portfolio = Portfolio;
            fullName = FullName;
            emailAddress = EmailAddress;
            moneyToInvest = MoneyToInvest;
            brokerName= BrokerName;
        }

        public int Count()
        {
            int count = this.Portfolio.Count;
            return count;
        }
        public void BuyStock(Stock stock)
        {
            
            if (stock.MarketCapitalization >= 10_000 & moneyToInvest >= 10_000)
            {
                this.portfolio.Add(stock);
                this.moneyToInvest -= stock.PricePerShare;

            }
        }
        public string SellStock(string companyName, decimal sellPrice)
        {
            foreach (var stock in this.portfolio)
            {
                if (stock.CompanyName == companyName)
                {
                    if (sellPrice < stock.PricePerShare)
                    {
                        return "Cannot sell " + companyName + ".";
                    }
                    else
                    {
                        moneyToInvest += sellPrice;
                        this.portfolio.Remove(stock);
                        return companyName + "was sold.";

                    }
                }
            }
            return companyName + "does not exist.";
        }
        public Stock FindStock(string companyName)
        {
            foreach (Stock stock in this.portfolio)
            {
                if (stock.CompanyName == companyName)
                {
                    return stock;
                }
            }
            return null;
        }
        public Stock FindBiggestCompany()
        {
            decimal biggest = 0;
            Stock currStock = null;
            foreach (Stock stock in this.portfolio)
            {
                if (biggest< stock.MarketCapitalization)
                {
                    biggest = stock.MarketCapitalization;
                    currStock = stock;
                }
                return currStock;
            }
            return null;
        }
        public string InvestorInformation() 
        {
            //InvestorInformation
            StringBuilder sb = new StringBuilder();

            sb.Append($"The investor {fullName} with a broker {brokerName} has stocks:");
            foreach (var stock in this.portfolio)
            {
             sb.AppendLine(stock.ToString());
            }
            return sb.ToString();
        }
    }
   



using GameProject.Business.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Business.Concrete
{
    public class SalesManager : ISaleService
    {
        public void Sell(Sales sales, Gamer gamer, Campaign campaign)
        {
            int discount = (int.Parse(sales.Price.ToString()) / 100) * int.Parse(campaign.CampaignDiscount.ToString());
            int price = int.Parse(sales.Price.ToString());
            int sumPrice = price - discount;

            Console.WriteLine("Game name is " + sales.GameName + " via campaign. Was sold to player " + gamer.FirstName);
            Console.WriteLine("Game Price= " + price + " Campaign Price " + discount + " TL");

            Console.WriteLine(price + "-" + discount + " =" + sumPrice + "");
        }
    }
}

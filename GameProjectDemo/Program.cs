using GameProjectDemo.Abstract;
using GameProjectDemo.Entities;
using GameProjectDemo.Concrete;
using System;
using GameProjectDemo.Adapters;

namespace GameProjectDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product game1 = new Game(1, 3, "Call Of Duty", "EA Sports");
            Customer customer1 = new Customer(1, "124115896234", "Muhammed Murat", "Özgür", 2001);
            Campaign campaign1 = new Campaign(1, "Winter", 10);

            BaseSaleManager gameSaleManager = new GameSaleManager();
            CustomerManager customerManager = new CustomerManager(new EGovernmentServiceAdapter());
            CampaignManager campaignManager1 = new CampaignManager();

            gameSaleManager.Sell(game1, customer1, campaign1);

            CampaignManager campaignManager = new CampaignManager();

            gameSaleManager.Sell(new Game(1, 3, "Valorant", "Riot Games"),
                new Customer(1, "22362248965", "Behzat Çözer", "Özgür", 2003),
                new Campaign(1, "Autumn", 35));

            customerManager.Add(customer1);

            campaignManager1.Add(campaign1);


        }
    }
}

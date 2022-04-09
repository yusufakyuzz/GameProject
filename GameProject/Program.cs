// See https://aka.ms/new-console-template for more information
using GameProject.Business.Concrete;
using GameProject.Entities;
using Kimlik;

GamerManager gamerManager = new GamerManager();
CampaignManager campaignManager = new CampaignManager();
SalesManager salesManager = new SalesManager();


Gamer gamer = new Gamer { Id = 1, NationallyId = "12345678901", FirstName = "Yusuf", LastName = "Akyüz", BirthYear = "1992" };
Campaign campaign = new Campaign { Id = 1, CampaignName = "Bahar Kampanyası", CampaignDiscount = 15 };
Sales sales = new Sales { Id = 1, GameName = "GTA V", Price = 350 };


gamerManager.Add(gamer);
gamerManager.Delete(gamer);
gamerManager.Update(gamer);
campaignManager.Add(campaign);
sales.Sell(sales, gamer, campaign);

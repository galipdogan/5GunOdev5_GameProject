using System;
using _5GunOdev5_GameProject.Abstract;
using _5GunOdev5_GameProject.Concrete;
using _5GunOdev5_GameProject.Entities;

namespace _5GunOdev5_GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new GamerCheckManager());

            //Yeni Oyuncu tanımlama
            Gamer gamer1 = new Gamer
            {
                Id = 1, FirstName = "Galip", LastName = "Doğan", NationalityId = "11111111111",
                BirthDay = new DateTime(1986, 11, 4)
            };
            //Yeni Oyuncu Ekleme

            gamerManager.Add(gamer1);

            //Yeni Oyun tanımlama
            Game game1 = new Game();
            game1.Id = 1;
            game1.GameName = "Oyun1";

            //Yeni Kampanya tanımlama
            Campaign campaign1 = new Campaign();
            campaign1.CampaignName = "Yeni Kampanya";
            campaign1.CapmpaignDiscount = 25;
            
            //Oyun Ekleme
            GameManager gameManager = new GameManager();
            gameManager.Add(game1);

            //Kampanya Ekleme
            CampaignManager campaignManager = new CampaignManager();
            campaignManager.Add(campaign1);

            //Satış yapıldı
            SalesManager salesManager = new SalesManager();
            salesManager.Add(gamer1,game1,campaign1);





        }
    }
}

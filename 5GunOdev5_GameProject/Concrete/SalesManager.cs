using System;
using System.Collections.Generic;
using System.Text;
using _5GunOdev5_GameProject.Abstract;
using _5GunOdev5_GameProject.Entities;

namespace _5GunOdev5_GameProject.Concrete
{
   public class SalesManager:ISalesService
    {
		public void Add(Gamer gamer, Game game, Campaign campaign)
        {
            Console.WriteLine("Oyun Eklendi Oyun : " + game.GameName + " Kişi : " + gamer.FirstName + " " + gamer.LastName + " Kampanya : " + campaign.CampaignName);
        }

        public void Delete(Gamer gamer, Game game, Campaign campaign)
        {
            Console.WriteLine("Oyun Silindi Oyun : " + game.GameName + " Kişi : " + gamer.FirstName + " " + gamer.LastName + " Kampanya : " + campaign.CampaignName);
        }

        public void Update(Gamer gamer, Game game, Campaign campaign)
        {
            Console.WriteLine("Oyun Güncellendi Oyun : " + game.GameName + " Kişi : " + gamer.FirstName + " " + gamer.LastName + " Kampanya : " + campaign.CampaignName);
        }
	}
}

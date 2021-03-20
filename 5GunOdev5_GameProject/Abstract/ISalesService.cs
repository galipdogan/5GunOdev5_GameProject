using System;
using System.Collections.Generic;
using System.Text;
using _5GunOdev5_GameProject.Entities;

namespace _5GunOdev5_GameProject.Abstract
{
    interface ISalesService:IEntity
    {
        void Add(Gamer gamer, Game game, Campaign campaign)
        {
            Console.WriteLine("Oyun Eklendi Oyun : " + game.GameName + "Kişi : " + gamer.FirstName  + gamer.LastName + " Kampanya : " + campaign.CampaignName);
        }

        void Delete(Gamer gamer, Game game, Campaign campaign)
        {
            Console.WriteLine("Oyun Silindi Oyun : " + game.GameName + "Kişi : " + gamer.FirstName +  gamer.LastName + " Kampanya : " + campaign.CampaignName);
        }

        void Update(Gamer gamer, Game game, Campaign campaign)
        {
            Console.WriteLine("Oyun GüncellendiOyun : " + game.GameName + "Kişi : " + gamer.FirstName +  gamer.LastName + " Kampanya : " + campaign.CampaignName);
        }
    }
}

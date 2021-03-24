using System;
using System.Collections.Generic;
using System.Text;
using _5GunOdev5_GameProject.Abstract;
using _5GunOdev5_GameProject.Entities;

namespace _5GunOdev5_GameProject.Concrete
{
    public class CampaignManager:ICampaignService
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + " isimli yeni kampanya eklendi.");

        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + " isimli kampanya silindi.");

        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + " isimli kampanya güncellendi.");
        }
    }
}

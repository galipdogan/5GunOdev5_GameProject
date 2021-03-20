using System;
using System.Collections.Generic;
using System.Text;
using _5GunOdev5_GameProject.Abstract;

namespace _5GunOdev5_GameProject.Entities
{
   public class Campaign:IEntity
    {
        public int Id { get; set; }
        public string CampaignName { get; set; }
        public double CapmpaignDiscount { get; set; }
    }
}

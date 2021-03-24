using System;
using System.Collections.Generic;
using System.Text;
using _5GunOdev5_GameProject.Abstract;
using _5GunOdev5_GameProject.Entities;
using MernisServiceReference;

namespace _5GunOdev5_GameProject.Adapters
{
  public  class MernisServiceAdapter:IGamerCheckService 
    {
        public bool CheckIfRealPerson(Gamer gamer)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient();
            client.TCKimlikNoDogrulaAsync(Convert.ToInt64(gamer.NationalityId) , gamer.FirstName, gamer.LastName, gamer.BirthDay.Year);
        }
    }
}

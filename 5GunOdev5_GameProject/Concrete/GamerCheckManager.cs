using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Text;
using _5GunOdev5_GameProject.Abstract;
using _5GunOdev5_GameProject.Entities;
using MernisServiceReference;

namespace _5GunOdev5_GameProject.Concrete
{
    public class GamerCheckManager : IGamerCheckService
    {
        public bool CheckIfRealPerson(Gamer gamer)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
            return client.TCKimlikNoDogrulaAsync(gamer.NationalityId, gamer.FirstName.ToUpper(),
                gamer.LastName.ToUpper(),
                gamer.BirthDay.Year).Result.Body.TCKimlikNoDogrulaResult;
        }

    }
}
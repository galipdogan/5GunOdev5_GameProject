using System;
using System.Collections.Generic;
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
            return true;
        }
    }
}

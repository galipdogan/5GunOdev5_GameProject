using System;
using System.Collections.Generic;
using System.Text;
using _5GunOdev5_GameProject.Entities;

namespace _5GunOdev5_GameProject.Abstract
{
    public interface IGamerService
    {
        public void Add(Gamer gamer);
        public void Update(Gamer gamer);
        public void Delete(Gamer gamer);


    }
}

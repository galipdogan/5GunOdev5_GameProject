using System;
using System.Collections.Generic;
using System.Text;
using _5GunOdev5_GameProject.Entities;

namespace _5GunOdev5_GameProject.Abstract
{
    public abstract class BaseCheckGamer:IGamerService
    {
        public virtual void Add(Gamer gamer)
        {
            Console.WriteLine("Eklendi" + gamer.FirstName);
        }

        public virtual void Update(Gamer gamer)
        {
            Console.WriteLine("Güncellendi" + gamer.FirstName);
        }

        public virtual void Delete(Gamer gamer)
        {
            Console.WriteLine("Silindi" + gamer.FirstName);
        }
    }
}

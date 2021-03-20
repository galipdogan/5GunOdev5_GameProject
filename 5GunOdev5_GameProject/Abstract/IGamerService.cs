using System;
using System.Collections.Generic;
using System.Text;
using _5GunOdev5_GameProject.Entities;

namespace _5GunOdev5_GameProject.Abstract
{
    public interface IGamerService
    {
        public void Add(Gamer gamer)
        {
            Console.WriteLine("Yeni Oyuncu Eklendi : " + gamer.FirstName);
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Oyuncu Güncellendi : " + gamer.FirstName);
        }
        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Oyuncu Silindi : " + gamer.FirstName);
        }

    }
}

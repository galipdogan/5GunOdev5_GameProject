using System;
using _5GunOdev5_GameProject.Abstract;
using _5GunOdev5_GameProject.Entities;

namespace _5GunOdev5_GameProject.Concrete
{
  public class GamerManager
    {
      
        public void Add(Gamer gamer)
        {
            Console.WriteLine("Oyuncu Kaydedildi..." + gamer.FirstName);
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Oyuncu Güncellendi..." + gamer.FirstName);
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Oyuncu Silindi..." + gamer.FirstName);
        }
    }
}

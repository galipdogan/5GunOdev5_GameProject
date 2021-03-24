using System;
using _5GunOdev5_GameProject.Abstract;
using _5GunOdev5_GameProject.Entities;

namespace _5GunOdev5_GameProject.Concrete
{
    public class GamerManager : IGamerService
    {
        private IGamerCheckService _checkService;

        public GamerManager(IGamerCheckService checkService)
        {
            _checkService = checkService;
        }


        public void Add(Gamer gamer)
        {
            if (_checkService.CheckIfRealPerson(gamer))
            {
                Console.WriteLine("Oyuncu Eklendi..." + gamer.FirstName);
            }
            else
            {
                Console.WriteLine("Doğrulama Hatası : " +gamer.FirstName);
            }
            
            
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

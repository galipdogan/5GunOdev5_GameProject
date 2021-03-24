using System;
using System.Collections.Generic;
using System.Text;
using _5GunOdev5_GameProject.Abstract;
using _5GunOdev5_GameProject.Entities;

namespace _5GunOdev5_GameProject.Concrete
{
    public class GameManager : IGameService
    {

        public void Add(Game game)
        {
            Console.WriteLine("Oyun Kaydedildi..." + game.GameName);
        }

        public void Update(Game game)
        {
            Console.WriteLine("Oyun Güncellendi..." + game.GameName);
        }

        public void Delete(Game game)
        {
            Console.WriteLine("Oyun Silindi..." + game.GameName);
        }
    }
}

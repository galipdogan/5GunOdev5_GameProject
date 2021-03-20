using System;
using System.Collections.Generic;
using System.Text;
using _5GunOdev5_GameProject.Entities;

namespace _5GunOdev5_GameProject.Abstract
{
   public interface IGameService
   {
       public void Add(Game game)
       {
           Console.WriteLine("Yeni Oyun Eklendi : " + game.GameName);
        }

       public void Update(Game game)
       {
           Console.WriteLine("Oyun Güncelle : " + game.GameName);
        }

       public void Delete(Game game)
       {
           Console.WriteLine("Oyun Silindi : " + game.GameName);
        }


   }
}

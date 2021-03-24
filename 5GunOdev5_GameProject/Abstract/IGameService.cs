using System;
using System.Collections.Generic;
using System.Text;
using _5GunOdev5_GameProject.Entities;

namespace _5GunOdev5_GameProject.Abstract
{
   public interface IGameService
   {
       public void Add(Game game);
       public void Update(Game game);
       public void Delete(Game game);



   }
}

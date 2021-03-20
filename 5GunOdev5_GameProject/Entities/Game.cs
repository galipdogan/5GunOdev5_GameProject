using System;
using System.Collections.Generic;
using System.Text;
using _5GunOdev5_GameProject.Abstract;

namespace _5GunOdev5_GameProject.Entities
{
   public class Game:IEntity
    {
        public int Id { get; set; }
        public string GameName { get; set; }
        public double GamePrice { get; set; }
    }
}

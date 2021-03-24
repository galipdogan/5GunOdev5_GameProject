using System;
using System.Collections.Generic;
using System.Text;
using _5GunOdev5_GameProject.Entities;

namespace _5GunOdev5_GameProject.Abstract
{
    public interface ISalesService : IEntity
    {
        public void Add(Gamer gamer, Game game, Campaign campaign);
        public void Delete(Gamer gamer, Game game, Campaign campaign);
        public void Update(Gamer gamer, Game game, Campaign campaign);

    }
}

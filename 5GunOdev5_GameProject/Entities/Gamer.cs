using System;
using _5GunOdev5_GameProject.Abstract;

namespace _5GunOdev5_GameProject.Entities
{
    public class Gamer:IEntity
    {
        public int Id { get; set; }
        public string NationalityId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDay { get; set; }
        
    }
}
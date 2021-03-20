using System;
using System.Collections.Generic;
using System.Text;
using _5GunOdev5_GameProject.Abstract;

namespace _5GunOdev5_GameProject.Entities
{
    class Sales:IEntity
    {
        public int Id { get; set; }
        public DateTime SaleDate { get; set; }
    }
}

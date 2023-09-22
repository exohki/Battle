using System;
using WCTC_Battle.Models;

namespace WCTC_Battle.Models
{
    public class Bow : IWeapon
    {
        public Bow()
        {
            Name = "Bow";
            Power = 3; 
        }

        public string Name { get; set; }
        public int Power { get; set; }
    }
}
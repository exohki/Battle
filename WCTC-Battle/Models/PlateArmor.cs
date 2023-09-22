using System;
namespace WCTC_Battle.Models
{
    public class PlateArmor : IArmor
    {
        public PlateArmor()
        {
            Name = "Plate Armor";
            Defense = 10; 
        }

        public string Name { get; set; }
        public int Defense { get; set; }
    }
}
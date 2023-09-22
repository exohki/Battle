using System;
using WCTC_Battle.Models;

namespace WCTC_Battle.Models
{
    public class Fighter : ICombatant
    {
        private IArmor _armor;
        private IWeapon _weapon;

        public string Name { get; set; }

        public Fighter(IArmor armor, IWeapon weapon)
        {
            _armor = armor;
            _weapon = weapon;
            Name = "Fighter Fred";
        }

        public void Attack(Enemy enemy)
        {
            if (_weapon.Power > enemy.Leather.Defense)
            {
                Console.WriteLine($"{this.Name} attacks {enemy.Name} with a {_weapon.Name}");
            }
            else
            {
                Console.WriteLine($"{enemy.Name} blocks the attack by {this.Name} with his {_armor.Name}");
            }
        }

        public void EquipWeapon(IWeapon weapon)
        {
            _weapon = weapon; 
            Console.WriteLine($"{this.Name} equips a new weapon: {_weapon.Name}");
        }
    }
}

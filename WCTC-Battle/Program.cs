using System;
using Microsoft.Extensions.DependencyInjection;
using WCTC_Battle.Models;

namespace WCTC_Battle
{
    class Program
    {
        static void Main(string[] args)
        {
            Enemy enemy = new Enemy();
            enemy.Name = "Angry Ant";
            enemy.Leather.Defense = 5;
            enemy.Sword.Power = 5;


            // DEPENDENCY INJECTION
            var serviceProvider = new ServiceCollection()
                .AddSingleton<IArmor, Leather>()
                .AddSingleton<IArmor, PlateArmor>()
                .AddSingleton<IWeapon, Sword>()
                .AddSingleton<IWeapon, Bow>()
                .AddSingleton<ICombatant, Fighter>()
                .BuildServiceProvider();

            var fighter = serviceProvider.GetService<ICombatant>();

            fighter.Attack(enemy);

            var bow = serviceProvider.GetService<IWeapon>();
            fighter.EquipWeapon(bow);

            fighter.Attack(enemy);

        }
    }
}

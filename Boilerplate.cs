using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static RPG.ToolBaseTypes;
using static RPG.Attributes;
namespace RPG
{
    internal class BoilerPlate()
    {
        public class ModifyWeapon()
        {
            rarityValues rarity;
            Weapon weapon;
            public void modifyWeaponBasedOnRarity(Weapon weapon)
            {
                rarity = weapon.Rarity;
                if (rarity == rarityValues.Common)
                {
                    weapon.DamageFloor = Math.Round(weapon.DamageFloor *= 0.75, MidpointRounding.AwayFromZero);
                    weapon.DamageCeiling = Math.Round(weapon.DamageCeiling *= 0.75, MidpointRounding.AwayFromZero);
                    weapon.Durability = Math.Round(weapon.Durability *= 0.5, MidpointRounding.AwayFromZero);
                }
                else if(rarity == rarityValues.Uncommon)
                {
                    weapon.DamageFloor = Math.Round(weapon.DamageFloor *= 1.5, MidpointRounding.AwayFromZero);
                    weapon.DamageCeiling = Math.Round(weapon.DamageCeiling *= 1.25, MidpointRounding.AwayFromZero);
                    weapon.Durability = Math.Round(weapon.Durability *= 1, MidpointRounding.AwayFromZero);
                }
                else if (rarity == rarityValues.Rare)
                {
                    weapon.DamageFloor = Math.Round(weapon.DamageFloor *= 3, MidpointRounding.AwayFromZero);
                    weapon.DamageCeiling = Math.Round(weapon.DamageCeiling *= 2.5, MidpointRounding.AwayFromZero);
                    weapon.Durability = Math.Round(weapon.Durability *= 1.5, MidpointRounding.AwayFromZero);
                }
                else if (rarity == rarityValues.Epic)
                {
                    weapon.DamageFloor = Math.Round(weapon.DamageFloor *= 4, MidpointRounding.AwayFromZero);
                    weapon.DamageCeiling = Math.Round(weapon.DamageCeiling *= 3.5, MidpointRounding.AwayFromZero);
                    weapon.Durability = Math.Round(weapon.Durability *= 2, MidpointRounding.AwayFromZero);
                }
                else if (rarity == rarityValues.Pernishka)
                {
                    weapon.DamageFloor = Math.Round(weapon.DamageFloor *= 6+20, MidpointRounding.AwayFromZero);
                    weapon.DamageCeiling = Math.Round(weapon.DamageCeiling *= 5 + 40, MidpointRounding.AwayFromZero);
                    weapon.Durability = Math.Round(weapon.Durability *= 10, MidpointRounding.AwayFromZero);
                }
            }
            public void GenerateWeapon(Weapon weapon)
            {
                weapon.createRarity();
                weapon.createWeapon();
                weapon.createName();
                Console.WriteLine($"{weapon.name} Rarity: {weapon.Rarity}");
                Console.WriteLine($"{weapon.name} Damage: {weapon.DamageFloor} - {weapon.DamageCeiling}");
                Console.WriteLine($"{weapon.name} Durability: {weapon.Durability}");
                Console.WriteLine($"{weapon.name} Can Behead: {weapon.CanBehead}");
                Console.WriteLine($"{weapon.name} Can Stun: {weapon.CanStun}");
            }
        }
    }
}

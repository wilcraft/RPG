using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static RPG.Attributes;
using static RPG.BoilerPlate;
namespace RPG
{
    internal class ToolBaseTypes()
    {
        public class Weapon
        {
            Random rand = new Random();
            internal string name = "[PLACEHOLDER]";
            private double damageFloor = 0;
            private double damageCeiling = 0;
            private double durability = 0;
            private bool canBehead = false;
            private bool isBlunt = false;
            private bool isSharp = false;
            private bool canStun = false;
            private rarityValues rarity;
            private int sumofWeight = 0;
            private int rollCeiling = 0;
            private int target = 0;

            public double DamageFloor { get => damageFloor; set => damageFloor = value; }
            public double DamageCeiling { get => damageCeiling; set => damageCeiling = value; }
            public double Durability { get => durability; set => durability = value; }
            public rarityValues Rarity { get => rarity; set => rarity = value; }
            public int SumofWeight { get => sumofWeight; set => sumofWeight = value; }
            public int RollCeiling { get => rollCeiling; set => rollCeiling = value; }
            public int Target { get => target; set => target = value; }
            public bool CanBehead { get => canBehead; set => canBehead = value; }
            public bool IsBlunt { get => isBlunt; set => isBlunt = value; }
            public bool IsSharp { get => isSharp; set => isSharp = value; }
            public bool CanStun { get => canStun; set => canStun = value; }

            public virtual void generateWeapon()
            {
                DamageFloor = rand.Next(11, 25);
                DamageCeiling = rand.Next(25, 90);
                Durability = 100;
            }
            public virtual void generateRarity()
            {
                foreach (var rarityWeight in Enum.GetValues<rarityValues>())
                {
                    SumofWeight += (int)rarityWeight;
                }

                Target = rand.Next(1, SumofWeight);

                foreach (var item in Enum.GetValues<rarityValues>())
                {
                    RollCeiling += (int)item;
                    if (Target <= RollCeiling)
                    {
                        Rarity = item;
                        Console.WriteLine($"Target Value: {Target}");
                        Console.WriteLine($"Ceiling Value: {RollCeiling}");
                        Console.WriteLine($"Target Rarity: {Rarity}");
                        break;
                    }
                }
            }
            public virtual void generateName()
            {
                if (Rarity != rarityValues.Common)
                {
                    name = String.Concat(Enum.GetValues<Prefixes>()[rand.Next(0, Enum.GetValues<Prefixes>().Length)], " ",
                        name,
                        " of ",
                        Enum.GetValues<Suffixes>()[rand.Next(0, Enum.GetValues<Suffixes>().Length)]);

                }
            }

        }

        public class Axe : Weapon
        {
            Random rand = new Random();
            modifyWeapon mod = new modifyWeapon();
            public override void generateWeapon()
            {
                name = "Axe";
                DamageFloor = rand.Next(14, 48);
                DamageCeiling = rand.Next((int)(DamageFloor+1), (int)((DamageFloor + rand.Next(1,10)) * 3));
                Durability = rand.Next(15, 50);
                CanBehead = true;
                IsSharp = true;
                Weapon Axe = this;
                mod.modifyWeaponBasedOnRarity(Axe);
            }
        }
        public class Club : Weapon
        {
            Random rand = new Random();
            modifyWeapon mod = new modifyWeapon();

            public override void generateWeapon()
            {
                name = "Club";
                DamageFloor = rand.Next(20, 30);
                DamageCeiling = rand.Next(((int)DamageFloor + 1),(int)((DamageFloor + rand.Next(10,15)) * 2));
                Durability = rand.Next(30, 60);
                IsBlunt = true;
                CanStun = true;
                Weapon Club = this;
                mod.modifyWeaponBasedOnRarity(Club);
            }
        }

    }
}

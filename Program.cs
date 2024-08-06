using System.Linq;
using static RPG.ToolBaseTypes;
namespace RPG
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isrunning = true;
            while (isrunning)
            {
                var input = Console.ReadLine().ToUpper();
                if(input != "X")
                {
                    if (input == "1")
                    {
                            Weapon axe = new Axe();
                            axe.generateRarity();
                            axe.generateWeapon();
                            axe.generateName();
                            Console.WriteLine($"{axe.name} Damage : {axe.DamageFloor} - {axe.DamageCeiling}");
                            Console.WriteLine($"{axe.name} Durability : {axe.Durability}");
                            Console.WriteLine($"{axe.name} Can Behead: {axe.CanBehead}");
                    }
                    if(input == "2")
                    {
                        Weapon club = new Club();
                        club.generateRarity();
                        club.generateWeapon();
                        club.generateName();
                        Console.WriteLine($"{club.name} Damage : {club.DamageFloor} - {club.DamageCeiling}");
                        Console.WriteLine($"{club.name} Durability : {club.Durability}");
                        Console.WriteLine($"{club.name} Can Stun: {club.CanStun}");
                    }
                }
                else
                {
                    isrunning = false;
                }
            }
        }
    }

}

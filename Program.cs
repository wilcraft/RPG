using System.Linq;
using static RPG.ToolBaseTypes;
using static RPG.BoilerPlate;
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
                ModifyWeapon mod = new ModifyWeapon();
                if(input != "X")
                {
                    if (input == "1")
                    {
                            Weapon axe = new Axe();
                            mod.GenerateWeapon(axe);
                            
                    }
                    if(input == "2")
                    {
                        Weapon club = new Club();
                        mod.GenerateWeapon(club);
                    }
                    if(input == "3")
                    {
                        Weapon Sword = new Sword();
                        mod.GenerateWeapon(Sword);
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

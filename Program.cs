using System.Linq;

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
                            Console.WriteLine($"{axe.name} Damage : {axe.damageFloor} - {axe.damageCeiling}");
                            Console.WriteLine($"{axe.name} Durability : {axe.Durability}");
                    }
                }
                else
                {
                    isrunning = false;
                }
            }
        }
    }
    enum Rarity
    {
        Common = 900,
        Uncommon = 700,
        Rare = 500,
        Epic = 300,
        Pernishka = 50
    }
    class Weapon
    {
        Random rand = new Random();
        internal string name = "TEMPORARY !!!NAME!!!";
        internal string[] adjectives =
        {
            "Aggresive ", "Ambitious ", "Eager ", "Zealous ", "Large "
        };
        internal int damageFloor = 0;
        internal int damageCeiling = 0;
        internal int Durability = 0;
        internal string rarity;
        internal int rarityKey;
        internal int sumofWeight = 0;
        internal int rollBottom = 0;
        internal int target = 0;
        internal Dictionary<int, string> dictRarity = new Dictionary<int, string> {
                        { 100, "Common" },
            { 50, "Uncommon" },
            { 25, "Rare"},
            { 10, "Epic"},
            { 1, "Pernishka"}
        };

        public virtual void generateWeapon()
        {
            damageFloor = rand.Next(11, 25);
            damageCeiling = rand.Next(25, 90);
            Durability = 100;
        }
        public virtual void generateRarity()
        {
            sumofWeight = dictRarity.Keys.Sum();
            target = rand.Next(1, sumofWeight);
            foreach (KeyValuePair<int, string> item in dictRarity)
            {
                rollBottom += item.Key;
                if (target <= rollBottom)
                {
                    rarity = item.Value;
                    Console.WriteLine($"Target Value: {target}");
                    Console.WriteLine($"Floor Value: {rollBottom}");
                    Console.WriteLine($"Target Rarity: {rarity}");
                    break;
                }
            }
        }
        public virtual void generateName()
        {
            if (rarity == "Common" || rarity == "Uncommon")
            {
                name = String.Concat(adjectives[rand.Next(0, 4)], name);
            } else if(rarity == "Rare" || rarity == "Epic")
            {
                name = String.Concat(adjectives[rand.Next(0, 4)], name);
                name = String.Concat(name, " of " ,adjectives[rand.Next(0,4)]);
            }
        }
    }

    class Axe : Weapon, Rarity
    {
        public bool canBehead = true;
        Random rand = new Random();
        public override void generateWeapon()
        {
            base.generateWeapon();
            name = "Axe";
            damageFloor = rand.Next(14, 48);
            damageCeiling = rand.Next(49, 112);
            Durability = 50;
        }
        public override void generateRarity()
        {
            base.generateRarity();
        }
    }
}

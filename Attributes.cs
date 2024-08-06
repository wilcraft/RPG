using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG
{
    public class Attributes()
    {
        public enum rarityValues
        {
            Common = 900,
            Uncommon = 700,
            Rare = 500,
            Epic = 300,
            Pernishka = 50
        }
        public enum Prefixes
        {
            Aggresive,
            Ambitious,
            Eager,
            Zealous,
            Large,
            Frugal,
            Poor,
            Dull,
        }
        public enum Suffixes
        {
            Flickering,
            Blazing,
            Clumsiness,
            Brilliance,
            Amplification
        }
        private List<string> AxeTypes = new List<string>
        {
            "Broad Axe",
            "Splitting Maul",
            "Felling Axe",
            "Double Axe"
        };
        private List<string> ClubTypes = new List<string>
        {
            "Wooden Club",
            "Cracked Club",
            "Stone Club",
        };
        private List<string> SwordTypes = new List<string>
        {
            "Longsword",
            "Shortsword",
            "Two-Hander",
            "Scimitar",
            "Saber"
        };

        public List<string> getSwordTypes { get => SwordTypes; set => SwordTypes = value; }
        public List<string> getClubTypes { get => ClubTypes; set => ClubTypes = value; }
        public List<string> getAxeTypes { get => AxeTypes; set => AxeTypes = value; }
        
    }

}

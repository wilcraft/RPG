using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG
{
    internal class Attributes()
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
    }

}

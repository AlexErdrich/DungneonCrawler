using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tables
{
    public sealed class Player : Character
    {

        public Race CharacterRace { get; set; }

        public Weapon EquippedWeapon { get; set; }
        public Player(string name, int ac, int cHealth, int maxHealth, int cMana, int maxMana, int cExp, int nExp, decimal monies, int str, int con, int dex, int intel, int wis, int cha, Race characterRace, Weapon equippedWeapon) : base(name, ac, cHealth, maxHealth, cMana, maxMana, cExp, nExp, monies, str, con, dex, intel, wis, cha)
        {
        }
        

    }//class
}//namespace

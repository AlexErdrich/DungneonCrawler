using System.Reflection.Metadata;
using System.Threading.Tasks.Dataflow;

namespace tables
{
    public class Monster : Character
    {
        public bool Flying { get; set; }



        public Monster(string name, int ac, int cHealth, int maxHealth, int cMana, int maxMana, int cExp, int nExp, decimal monies, int str, int con, int dex, int intel, int wis, int cha, bool flying, Weapons equippedWeapon) : base(name, ac, cHealth, maxHealth, cMana, maxMana, cExp, nExp, monies, str, con, dex, intel, wis, cha, equippedWeapon)
        {
            Flying = flying;
        }


        public override bool hit()
        {
            if (Flying)
            {
                Random rng = new Random(); int attack = rng.Next(1, 21);
                if (attack >= AC + 4)
                { return true; }
            }
            return false;

        }
        public Monster()
        {

        }

    }//class
}//name
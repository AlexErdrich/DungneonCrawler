using System.Reflection.Metadata;

namespace tables
{
    public class Monster : Character
    {
        public bool Flying { get; set; }



        public Monster(string name, int ac, int cHealth, int maxHealth, int cMana, int maxMana, int cExp, int nExp, decimal monies, int str, int con, int dex, int intel, int wis, int cha, bool flying, Weapon equippedWeapon) : base(name, ac, cHealth, maxHealth, cMana, maxMana, cExp, nExp, monies, str, con, dex, intel, wis, cha, equippedWeapon)
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

        // public enum BossMonster {GelatinousCube, Balor, Chimera, Dragon, RickAstley, Mimic}
        //public enum NormMonster{Orc, Minotaur, Gnolls, Worg, Ahriman, DireWolf, Yeti, Dryad, Treant}
        //public enum StrongMonster{Necromancer, Vampire, Ogre, Owlbear, Spectre}
        //public enum WeakMonster {Goblin, Slime, Skeleton, Imp, Rat, Bat}

        #region MonsterStats
        Weapon bite = new Weapon();
        #region Normal Monster

        public static Monster SpawnNormEnemy()
        {
            Monster orc = new Monster("Orc", 12, 10, 10, 5, 5, 0, 0, 0, 14, 14, 10, 8, 8, 6, false, Weapon.Club);
            Monster minotaur = new Monster("Minotaur", 14, 70, 70, 0, 0, 0, 0, 0, 18, 16, 11, 6, 16, 9, false, Weapon.GreatClub);
            Monster gnoll = new Monster("Gnoll", 15, 22, 22, 0, 0, 0, 0, 0, 14, 11, 12, 6, 10, 7, false, Weapon.Spear);
            Monster worg = new Monster("Worg", 13, 26, 26, 0, 0, 0, 0, 0, 16, 13, 13, 7, 11, 8, false, Weapon.Bite);
            Monster ahriman = new Monster("Ahriman", 12, 15, 15, 0, 0, 0, 0, 0, 10, 10, 14, 16, 11, 7, true, Weapon.Magic);
            Monster direwolf = new Monster("Dire Wolf", 14, 20, 20, 0, 0, 0, 0, 0, 12, 14, 14, 8, 10, 10, false, Weapon.Bite);
            Monster yeti = new Monster("Yeti", 11, 30, 30, 0, 0, 0, 0, 0, 16, 14, 10, 8, 8, 10, false, Weapon.Claw);
            Monster dyrad = new Monster("Dryad", 14, 20, 20, 0, 0, 0, 0, 0, 12, 10, 14, 10, 12, 16, false, Weapon.Vine);
            Monster treant = new Monster("Treant", 16, 30, 30, 0, 0, 0, 0, 0, 14, 16, 10, 8, 12, 8, false, Weapon.Vine);
        }
        #endregion
        #region Weak Monster

        public static Monster SpawnWeakEnemy()
        {
            Monster goblin = new Monster("Goblin", 12, 12, 12, 0, 0, 0, 0, 0, 12, 8, 10, 8, 8, 8, false, Weapon.Dagger);

        }
        #endregion

        #endregion
    }//class
}//name
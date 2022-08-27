using System.Reflection.Metadata;
using System.Threading.Tasks.Dataflow;

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

        //public enum BossMonster {GelatinousCube, Balor, Chimera, Dragon, RickAstley, Mimic}
        //public enum NormMonster{Orc, Minotaur, Gnolls, Worg, Ahriman, DireWolf, Yeti, Dryad, Treant}
        //public enum StrongMonster{Necromancer, Vampire, Ogre, Owlbear, Spectre}
        //public enum WeakMonster {Goblin, Slime, Skeleton, Imp, Rat, Bat}

        #region MonsterStats
        
        #region Weak Monster

        public static Monster SpawnWeakEnemy()
        {
            Monster goblin = new Monster("Goblin", 12, 12, 12, 0, 0, 0, 0, 0, 12, 8, 10, 8, 8, 8, false, Weapon.Dagger);
            Monster slime = new Monster("Slime", 12, 10, 10, 0, 0, 0, 0, 0, 10, 10, 10, 14, 6, 14, false, Weapon.Magic);
            Monster skeleton = new Monster("Skeleton", 14, 8, 8, 0, 0, 0, 0, 0, 12, 8, 10, 8, 8, 8, false, Weapon.Shortsword);
            Monster imp = new Monster("Imp", 12, 10, 10, 0, 0, 0, 0, 0, 8, 8, 12, 14, 12, 10, true, Weapon.Magic);
            Monster rat = new Monster("Rat", 14, 12, 12, 0, 0, 0, 0, 0, 8, 10, 12, 8, 8, 8, false, Weapon.Bite);
            Monster bat = new Monster("Bat", 14, 4, 4, 0, 0, 0, 0, 0, 10, 10, 12, 8, 8, 8, true, Weapon.Bite);

            List<Monster> spawnWeakEnemy = new List<Monster>()
            {
                goblin, slime, skeleton, imp, rat, bat
            };
            return spawnWeakEnemy[new Random().Next(spawnWeakEnemy.Count)];
        }
        #endregion
        #region Normal Monster

        public static Monster SpawnNormEnemy()
        {
            Monster orc = new Monster("Orc", 12, 10, 10, 5, 5, 0, 0, 0, 14, 14, 10, 8, 8, 6, false, Weapon.Club);
            Monster minotaur = new Monster("Minotaur", 14, 70, 70, 0, 0, 0, 0, 0, 18, 16, 11, 6, 16, 9, false, Weapon.Greataxe);
            Monster gnoll = new Monster("Gnoll", 15, 22, 22, 0, 0, 0, 0, 0, 14, 11, 12, 6, 10, 7, false, Weapon.Spear);
            Monster worg = new Monster("Worg", 13, 26, 26, 0, 0, 0, 0, 0, 16, 13, 13, 7, 11, 8, false, Weapon.Bite);
            Monster ahriman = new Monster("Ahriman", 12, 15, 15, 0, 0, 0, 0, 0, 10, 10, 14, 16, 11, 7, true, Weapon.Magic);
            Monster direwolf = new Monster("Dire Wolf", 14, 20, 20, 0, 0, 0, 0, 0, 12, 14, 14, 8, 10, 10, false, Weapon.Bite);
            Monster yeti = new Monster("Yeti", 11, 30, 30, 0, 0, 0, 0, 0, 16, 14, 10, 8, 8, 10, false, Weapon.Claw);
            Monster dyrad = new Monster("Dryad", 14, 20, 20, 0, 0, 0, 0, 0, 12, 10, 14, 10, 12, 16, false, Weapon.Vine);
            Monster treant = new Monster("Treant", 16, 30, 30, 0, 0, 0, 0, 0, 14, 16, 10, 8, 12, 8, false, Weapon.Vine);

            List<Monster> spawnNormMonster = new List<Monster>()
            {
                orc, minotaur, gnoll, worg, ahriman, direwolf, yeti, dyrad, treant
            };
            return spawnNormMonster[new Random().Next(spawnNormMonster.Count)];
        }
        #endregion
        #region Strong Monster
        public static Monster SpawnStrongEnemy()
        {
            Monster vampire = new Monster("Vampire", 12, 40, 40, 0, 0, 0, 0, 0, 14, 12, 14, 16, 12, 18, true, Weapon.Longsword);
            Monster ogre = new Monster("Orge", 14, 55, 55, 0, 0, 0, 0, 0, 16, 16, 10, 8, 10, 8, false, Weapon.GreatClub);
            Monster owlbear = new Monster("Owlbear", 15, 35, 35, 0, 0, 0, 0, 0, 16, 16, 12, 10, 10, 12, false, Weapon.Claw);
            Monster spectre = new Monster("Spectre", 14, 20, 20, 0, 0, 0, 0, 0, 12, 10, 14, 16, 10, 10, true, Weapon.Magic);

            List<Monster> spawnStrongEnemy = new List<Monster>()
            {
                vampire,ogre,owlbear,spectre
            };
            return spawnStrongEnemy[new Random().Next(spawnStrongEnemy.Count)];
        }
        #endregion
        #region Boss Monster
        public static Monster SpawnBossEnemy()
        {
            Monster gelatinousCube = new Monster("Gelatinous Cube", 12, 120, 120, 0, 0, 0, 0, 0, 12, 12, 14, 8, 8, 6, false, Weapon.Magic);
            Monster mimic = new Monster("Mimic", 14, 30, 30, 0, 0, 0, 0, 0, 12, 16, 10, 18, 16, 20, false, Weapon.Bite);
            Monster balor = new Monster("Balor", 16, 40, 40, 0, 0, 0, 0, 0, 16, 16, 14, 14, 12, 12, true, Weapon.Greatsword);
            Monster chimera = new Monster("Chimera", 14, 50, 50, 0, 0, 0, 0, 0, 16, 16, 12, 10, 10, 10, true, Weapon.Magic);
            Monster dragon = new Monster("Dragon", 14,60,60,0,0,0,0,0,18,18,14,18,12,12,true, Weapon.Magic);
            Monster rickAstley = new Monster("Rick Astley",10,150,150,0,0,0,0,0,10,10,10,10,10,16,false,Weapon.Rick);
            
            List<Monster> bossEnemy = new List<Monster>()
            {
                gelatinousCube, mimic, balor, chimera, dragon, rickAstley
            };
            return bossEnemy[new Random().Next(bossEnemy.Count)];
            
        }
        #endregion
        #endregion
    }//class
}//name
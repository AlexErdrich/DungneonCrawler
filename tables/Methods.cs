using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace tables
{
    public class Methods
    {
        public static string getRoom()
        {

            string[] rooms =
             {
               "As you enter the room, ", "The air in the room is smoky, ", "A draft blow throughout the room, ",
            };
            string[] rooms2 =
             {
               "the floor boards creak with your every step. ", "a thick smell of urine permeates the air. ","chiming can be heard as bones rattle from the rafters. ", "the rotted and dried remains of three humans lie strewn in the room. ","the body of a dwarf, dead for several weeks, lies upon the floor, it's head crushed in and it's body stripped of everything. ", "twenty iron hooks and pegs have been hammered into one wall at a height of four to six feet off the floor. Laying along one wall is a partially intact medium sized humanoid skeleton. "
           };
            string[] rooms3 =
             {
                $"You suddenly spot a monster that looks to be eating the remains of the last adventurer.",
            };
            string desc1 = rooms[new Random().Next(rooms.Length)];
            string desc2 = rooms2[new Random().Next(rooms2.Length)];
            string desc3 = rooms3[new Random().Next(rooms3.Length)];

            return desc1 + desc2 + desc3;

        }
        public static List<Weapons> Wpn()
        {
            #region WeaponStats+
            Weapons club = new Weapons("Club", "A blunt object used to Whack things with. ", 4, 2, 4, 1, DamageType.Blunt, Weapon.Club, false);
            Weapons dagger = new Weapons("Dagger", "A sharp point thing. ", 6, 3, 4, 1, DamageType.Pierce, Weapon.Dagger, false);
            Weapons greatclub = new Weapons("Great Club", "A large club seemingly made from a tree branch. ", 18, 9, 8, 1, DamageType.Blunt, Weapon.GreatClub, false);
            Weapons handaxe = new Weapons("Handaxe", "Your a now a member of the hachet gang. ", 4, 2, 6, 1, DamageType.Slash, Weapon.Handaxe, true);
            Weapons javelin = new Weapons("Javelin", "A short spear that can be thrown. ", 6, 3, 6, 1, DamageType.Pierce, Weapon.Javelin, true);
            Weapons lighthammer = new Weapons("Light Hammer", "Your simple hammer you can find in any toolbox. ", 4, 2, 4, 1, DamageType.Blunt, Weapon.LightHammer, true);
            Weapons mace = new Weapons("Mace", "A traditional blunt device, often used to Whack things. ", 8, 4, 6, 1, DamageType.Blunt, Weapon.Mace, false);
            Weapons quaterstaff = new Weapons("Quaterstaff", "The old man walking stick the doubles as a beating stick. ", 4, 2, 6, 1, DamageType.Blunt, Weapon.Quaterstaff, false);
            Weapons sickle = new Weapons("Sickle", "The small farming implement when you can't find the frying pan. ", 6, 3, 4, 1, DamageType.Slash, Weapon.Sickle, false);
            Weapons spear = new Weapons("Spear", "The go to weapon when you want to poke something while keeping them further than arm length. ", 8, 4, 1, 6, DamageType.Pierce, Weapon.Spear, true);
            Weapons lightCrossbow = new Weapons("Light Crossbow", "A small crossbow, can be loaded quickly. ", 10, 5, 8, 1, DamageType.Pierce, Weapon.LightCrossbow, true);
            Weapons shortbow = new Weapons("Shortbow", "A small bow that looks more like a toy than a weapon. ", 10, 5, 6, 1, DamageType.Pierce, Weapon.Shortbow, true);
            Weapons battleaxe = new Weapons("Battleaxe", "A larger axe than a hatchet. very sharp. much wow. ", 10, 5, 8, 1, DamageType.Slash, Weapon.Battleaxe, false);
            Weapons flail = new Weapons("Flail", "A blunt weapon with a ball, chain, and handle. ", 8, 4, 8, 1, DamageType.Blunt, Weapon.Flail, false);
            Weapons glaive = new Weapons("Glaive", "When you just want a blade on a stick. ", 8, 4, 10, 1, DamageType.Slash, Weapon.Glaive, false);
            Weapons greataxe = new Weapons("Greataxe", "Big'ol axe for big'ol things. ", 12, 6, 12, 1, DamageType.Slash, Weapon.Greataxe, false);
            Weapons greatsword = new Weapons("Greatsword", "When you need a big blade to cut more things as once. ", 12, 6, 12, 2, DamageType.Slash, Weapon.Greatsword, false);
            Weapons longsword = new Weapons("Longsword", "The standard sword, that you can ignore. ", 8, 4, 8, 1, DamageType.Slash, Weapon.Longsword, false);
            Weapons maul = new Weapons("Maul", "I big ball on a stick used to smack things with. ", 12, 6, 12, 2, DamageType.Blunt, Weapon.Maul, false);
            Weapons morningstar = new Weapons("Morningstar", "Not to be confused with the Eveningstar. ", 8, 2, 8, 1, DamageType.Pierce, Weapon.Morningstar, false);
            Weapons pike = new Weapons("Pike", "The heaviest of pokes. ", 12, 6, 10, 1, DamageType.Pierce, Weapon.Pike, false);
            Weapons rapier = new Weapons("Rapier", "A quick poker. ", 6, 3, 8, 1, DamageType.Pierce, Weapon.Rapier, false);
            Weapons scimitar = new Weapons("Scimitar", "Quick cuts from a light weight weapon. ", 6, 3, 6, 1, DamageType.Slash, Weapon.Scimitar, false);
            Weapons shortsword = new Weapons("Shortsword", "The traditional sword for most situations. ", 6, 3, 6, 1, DamageType.Pierce, Weapon.Shortsword, false);
            Weapons trident = new Weapons("Trident", "When you can't fine a good stick to roast the winers on a campfire substitute. ", 6, 3, 6, 1, DamageType.Pierce, Weapon.Trident, true);
            Weapons warpick = new Weapons("Warpick", "The pickaxe made for war. ", 8, 4, 8, 1, DamageType.Pierce, Weapon.Warpick, false);
            Weapons warhammer = new Weapons("Warhammer", "The hammer made for war. ", 8, 4, 8, 1, DamageType.Blunt, Weapon.Warhammer, false);
            Weapons whip = new Weapons("Whip", "It puts the whip, in coolwhip. ", 4, 2, 4, 1, DamageType.Slash, Weapon.Whip, false);
            Weapons handCrossbow = new Weapons("Hand Crossbow", "A hand held crossbow that is easy to use. ", 4, 2, 6, 1, DamageType.Pierce, Weapon.HandCrossbow, true);
            Weapons heavyCrossbow = new Weapons("Heavy Crossbow", "A crossbow to heavy to use in normal combat. ", 12, 6, 10, 1, DamageType.Pierce, Weapon.HeavyCrossbow, true);
            Weapons longbow = new Weapons("Longbow", "The bow that will reach out and touch you. ", 10, 5, 8, 1, DamageType.Pierce, Weapon.Longbow, true);
            Weapons vine = new Weapons("Vines", "The vines that soem creature use to attack. ", 10, 5, 8, 1, DamageType.Slash, Weapon.Vine, false);
            Weapons bite = new Weapons("Bite", "That moment you relize you didn't bring a better weapon. ", 0, 0, 6, 1, DamageType.Pierce, Weapon.Bite, false);
            Weapons magic = new Weapons("Magic", "When in doubt hit them with a magic missile. ", 0, 0, 8, 1, DamageType.Blunt, Weapon.Magic, true);
            Weapons claw = new Weapons("Claw", "When your teeth are just not cutting it. ", 0, 0, 8, 1, DamageType.Slash, Weapon.Claw, false);
            Weapons rick = new Weapons("Rick", "The man, the Myth, the legend. ", 0, 0, 1, 1, DamageType.Blunt, Weapon.Rick, true);

            #endregion

            List<Weapons> wpns = new List<Weapons>()
            {
                club,dagger,greatclub,handaxe,javelin,lightCrossbow,//0,1,2,3,4,5
                lighthammer,mace,quaterstaff,sickle,spear,shortbow,//6,7,8,9,10,11
                battleaxe,flail,glaive,greataxe,greatsword,longsword,//12,13,14,15,16,17
                maul,morningstar,pike,rapier,scimitar,shortsword,trident,//18,19,20,21,22,23,24
                warhammer,warpick,whip,handCrossbow,heavyCrossbow,longbow,vine,//25,26,27,28,29,30,31
                bite,magic,claw,rick//32,33,34,35

            };
            return wpns;
        }

        #region MonsterStats

        #region Weak Monster

        public static Monster SpawnWeakEnemy()
        {

            Monster goblin = new Monster("Goblin", 12, 12, 12, 0, 0, 0, 0, 0, 12, 8, 10, 8, 8, 8, false, Methods.Wpn()[1]);
            Monster slime = new Monster("Slime", 12, 10, 10, 0, 0, 0, 0, 0, 10, 10, 10, 14, 6, 14, false, Methods.Wpn()[33]);
            Monster skeleton = new Monster("Skeleton", 14, 8, 8, 0, 0, 0, 0, 0, 12, 8, 10, 8, 8, 8, false, Methods.Wpn()[23]);
            Monster imp = new Monster("Imp", 12, 10, 10, 0, 0, 0, 0, 0, 8, 8, 12, 14, 12, 10, true, Methods.Wpn()[33]);
            Monster rat = new Monster("Rat", 14, 12, 12, 0, 0, 0, 0, 0, 8, 10, 12, 8, 8, 8, false, Methods.Wpn()[32]);
            Monster bat = new Monster("Bat", 14, 4, 4, 0, 0, 0, 0, 0, 10, 10, 12, 8, 8, 8, true, Methods.Wpn()[32]);

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
            Monster orc = new Monster("Orc", 12, 10, 10, 5, 5, 0, 0, 0, 14, 14, 10, 8, 8, 6, false, Methods.Wpn()[0]);
            Monster minotaur = new Monster("Minotaur", 14, 70, 70, 0, 0, 0, 0, 0, 18, 16, 11, 6, 16, 9, false, Methods.Wpn()[15]);
            Monster gnoll = new Monster("Gnoll", 15, 22, 22, 0, 0, 0, 0, 0, 14, 11, 12, 6, 10, 7, false, Methods.Wpn()[10]);
            Monster worg = new Monster("Worg", 13, 26, 26, 0, 0, 0, 0, 0, 16, 13, 13, 7, 11, 8, false, Methods.Wpn()[32]);
            Monster ahriman = new Monster("Ahriman", 12, 15, 15, 0, 0, 0, 0, 0, 10, 10, 14, 16, 11, 7, true ,Methods.Wpn()[33]);
            Monster direwolf = new Monster("Dire Wolf", 14, 20, 20, 0, 0, 0, 0, 0, 12, 14, 14, 8, 10, 10, false ,Methods.Wpn()[32]);
            Monster yeti = new Monster("Yeti", 11, 30, 30, 0, 0, 0, 0, 0, 16, 14, 10, 8, 8, 10, false, Methods.Wpn()[34]);
            Monster dyrad = new Monster("Dryad", 14, 20, 20, 0, 0, 0, 0, 0, 12, 10, 14, 10, 12, 16, false, Methods.Wpn()[31]);
            Monster treant = new Monster("Treant", 16, 30, 30, 0, 0, 0, 0, 0, 14, 16, 10, 8, 12, 8, false, Methods.Wpn()[31]);

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
            Monster vampire = new Monster("Vampire", 12, 40, 40, 0, 0, 0, 0, 0, 14, 12, 14, 16, 12, 18, true, Methods.Wpn()[17]);
            Monster ogre = new Monster("Orge", 14, 55, 55, 0, 0, 0, 0, 0, 16, 16, 10, 8, 10, 8, false, Methods.Wpn()[2]);
            Monster owlbear = new Monster("Owlbear", 15, 35, 35, 0, 0, 0, 0, 0, 16, 16, 12, 10, 10, 12, false, Methods.Wpn()[34]);
            Monster spectre = new Monster("Spectre", 14, 20, 20, 0, 0, 0, 0, 0, 12, 10, 14, 16, 10, 10, true, Methods.Wpn()[33]);

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
            Monster gelatinousCube = new Monster("Gelatinous Cube", 12, 120, 120, 0, 0, 0, 0, 0, 12, 12, 14, 8, 8, 6, false, Methods.Wpn()[33]);
            Monster mimic = new Monster("Mimic", 14, 30, 30, 0, 0, 0, 0, 0, 12, 16, 10, 18, 16, 20, false, Methods.Wpn()[32]);
            Monster balor = new Monster("Balor", 16, 40, 40, 0, 0, 0, 0, 0, 16, 16, 14, 14, 12, 12, true, Methods.Wpn()[16]);
            Monster chimera = new Monster("Chimera", 14, 50, 50, 0, 0, 0, 0, 0, 16, 16, 12, 10, 10, 10, true, Methods.Wpn()[33]);
            Monster dragon = new Monster("Dragon", 14, 60, 60, 0, 0, 0, 0, 0, 18, 18, 14, 18, 12, 12, true, Methods.Wpn()[33]);
            Monster rickAstley = new Monster("Rick Astley", 10, 150, 150, 0, 0, 0, 0, 0, 10, 10, 10, 10, 10, 16, false, Methods.Wpn()[35]);

            List<Monster> bossEnemy = new List<Monster>()
            {
                gelatinousCube, mimic, balor, chimera, dragon, rickAstley
           };
            return bossEnemy[new Random().Next(bossEnemy.Count)];

        }
        #endregion
        #endregion

        #region Player Base stats



        #endregion

        #region Combat?

        public static void DoAttack(Character attacker, Character defender)
        {
            //get a random number from 1-100 as our dice roll.
          
            Thread.Sleep(300);//1000 is one second

            if (attacker.hit())
            {
                //we hit!
                //calculate the damage and save it to a variable!
                int damageDealt = attacker.injury((Weapons)attacker.EquippedWeapon);

                defender.CHealth -= damageDealt;

                //write the result to the screen
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"{attacker.Name} hit {defender.Name} for {damageDealt} damage!");
                Console.ResetColor();
            }//end if
            else
            {
                //attack missed!
                Console.WriteLine($"{attacker.Name} missed!");
            }//end else
        }//end DoAttack()

        public static void DoBattle(Player player, Monster monster)
        {
            //player attacks first
            DoAttack(player, monster);
            //monster attacks second, if they're alive
            if (monster.CHealth > 0)
            {
                DoAttack(monster, player);
            }
            #endregion
        }
    }
}//name space
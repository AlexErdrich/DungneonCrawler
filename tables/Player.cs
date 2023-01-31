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
        public Job Job { get; set; }


        public Player(string name, int ac, int maxHealth, int cHealth, int maxMana, int cMana, int nExp, int cExp, decimal monies, int str, int con, int dex, int intel, int wis, int cha, Race characterRace, Weapons equippedWeapon, Job job) : base(name, ac, cHealth, maxHealth, cMana, maxMana, cExp, nExp, monies, str, con, dex, intel, wis, cha, equippedWeapon)
        {
            CharacterRace = characterRace;
            Job = job;


            #region Racemods

            switch (CharacterRace)
            {
                case Race.Human: Strength += 1; Dexterity += 1; Constitution += 1; Wisdom += 1; Intelligence += 1; Charisma += 1;
                    break;
                case Race.Gnome: Intelligence += 2; Wisdom += 1;
                    break;
                case Race.Halfing: Dexterity += 2; Charisma += 1;
                    break;
                case Race.Elf: Dexterity += 2; Wisdom += 1;
                    break;
                case Race.HalfElf: Charisma +=2; Wisdom += 1;
                    break;
                case Race.HalfOrc: Strength += 2; Constitution += 1;
                    break;
                case Race.Dwarf: Constitution += 2; Wisdom += 1;
                    break;
                case Race.Tiefling:Charisma += 2; Intelligence += 1;
                    break;
                case Race.Dragonborn: Strength += 2; Charisma += 1;
                    break;
                default:
                    break;
            }
            #endregion


            #region Class Mods

            switch (Job)
            {
                case Job.Warrior: Strength += 4; Constitution += 4; Dexterity += 2;
                    break;
                case Job.Ranger: Strength += 2; Constitution += 3; Dexterity += 4;
                    break;
                case Job.Mage: Intelligence += 4; Constitution += 2; Wisdom += 4;
                    break;
                case Job.Priest: Charisma += 4; Constitution += 2; Wisdom += 4;
                    break;
                default:
                    break;
            }
            #endregion


        }



    }//class
}//namespace

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tables
{
    public sealed class Weapons : Items
    {

        public DamageType DmgType { get; set; }

        public Weapon Weapon1 { get; set; }
        public bool Ranged { get; set; }

        public Weapons(string itemName, string description, decimal wCost, decimal reSellCost, int minDamage, int maxDamge, DamageType dmgType, Weapon weapon, bool ranged) : base(itemName, description, wCost, reSellCost, minDamage, maxDamge)
        {
            Weapon1 = weapon;
            DmgType = dmgType;
            Ranged = ranged;
        }
        public static Weapons Wpn()
        {
            Weapons club = new Weapons("Club", "A blunt object used to Whack things with. ", 4, 2, 1, 4, DamageType.Blunt, Weapon.Club, false);
            Weapons dagger = new Weapons("Dagger", "A sharp point thing. ", 6, 3, 1, 4, DamageType.Pierce, Weapon.Dagger, false);
            Weapons greatclub = new Weapons("Great Club", "A large club seemingly made from a tree branch. ", 18, 9, 1, 8, DamageType.Blunt, Weapon.GreatClub, false);
            Weapons handaxe = new Weapons("Handaxe", "Your a now a member of the hachet gang. ", 4, 2, 1, 6, DamageType.Slash, Weapon.Handaxe, true);
            Weapons javelin = new Weapons("Javelin", "A short spear that can be thrown. ", 6, 3, 1, 6, DamageType.Pierce, Weapon.Javelin, true);
            Weapons lighthammer = new Weapons("Light Hammer", "Your simple hammer you can find in any toolbox. ", 4, 2, 1, 4, DamageType.Blunt, Weapon.LightHammer, true);
            Weapons mace = new Weapons("Mace", "A traditional blunt device, often used to Whack things. ", 8, 4, 1, 6, DamageType.Blunt, Weapon.Mace, false);
            Weapons quaterstaff = new Weapons("Quaterstaff", "The old man walking stick the doubles as a beating stick. ", 4, 2, 1, 6, DamageType.Blunt, Weapon.Quaterstaff, false);
            Weapons sickle = new Weapons("Sickle", "The small farming implement when you can't find the frying pan. ", 6, 3, 1, 4, DamageType.Slash, Weapon.Sickle, false);
            Weapons spear = new Weapons("Spear", "The go to weapon when you want to poke something while keeping them further than arm length. ", 8, 4, 1, 6, DamageType.Pierce, Weapon.Spear, true);
            Weapons lightCrossbow = new Weapons("Light Crossbow", "A small crossbow, can be loaded quickly. ", 10, 5, 1, 8, DamageType.Pierce, Weapon.LightCrossbow, true);
            Weapons shortbow = new Weapons("Shortbow", "A small bow that looks more like a toy than a weapon. ", 10, 5, 1, 6, DamageType.Pierce, Weapon.Shortbow, true);

            List<Weapons> wpns = new List<Weapons>()
            {
                club,dagger,greatclub,handaxe,javelin,lightCrossbow,lighthammer,mace,quaterstaff,sickle,spear,shortbow
            };
            return wpns;
        }
    }
}

//Club, Dagger, GreatClub, Handaxe, Javelin, LightHammer, Mace, Quaterstaff, Sickle, Spear, LightCrossbow, Shortbow, Sling, Battleaxe, Flail, Glaive, Greataxe,  Greatsword, Longsword, Maul, Morningstar, Pike, Rapier, Scimitar, Shortsword, Trident, Warpick, Warhammer, Whip, HandCrossbow, HeavyCrossbow, Longbow, Vine, Bite, Magic, Claw, Rick
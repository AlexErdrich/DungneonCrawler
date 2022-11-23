using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
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
        #region WeaponStats+

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
            Weapons battleaxe = new Weapons("Battleaxe", "A larger axe than a hatchet. very sharp. much wow. ", 10, 5, 1, 8, DamageType.Slash, Weapon.Battleaxe, false);
            Weapons flail = new Weapons("Flail", "A blunt weapon with a ball, chain, and handle. ", 8, 4, 1, 8, DamageType.Blunt, Weapon.Flail, false);
            Weapons glaive = new Weapons("Glaive", "When you just want a blade on a stick. ", 8, 4, 1, 10, DamageType.Slash, Weapon.Glaive, false);
            Weapons greataxe = new Weapons("Greataxe", "Big'ol axe for big'ol things. ", 12, 6, 1, 12, DamageType.Slash, Weapon.Greataxe, false);
            Weapons greatsword = new Weapons("Greatsword", "When you need a big blade to cut more things as once. ", 12, 6, 2, 12, DamageType.Slash, Weapon.Greatsword, false);
            Weapons longsword = new Weapons("Longsword", "The standard sword, that you can ignore. ", 8, 4, 1, 8, DamageType.Slash, Weapon.Longsword, false);
            Weapons maul = new Weapons("Maul", "I big ball on a stick used to smack things with. ", 12, 6, 2, 12, DamageType.Blunt, Weapon.Maul, false);
            Weapons morningstar = new Weapons("Morningstar", "Not to be confused with the Eveningstar. ", 8, 2, 1, 8, DamageType.Pierce, Weapon.Morningstar, false);
            Weapons pike = new Weapons("Pike", "The heaviest of pokes. ", 12, 6, 1, 10, DamageType.Pierce, Weapon.Pike, false);
            Weapons rapier = new Weapons("Rapier", "A quick poker. ", 6, 3, 1, 8, DamageType.Pierce, Weapon.Rapier, false);
            Weapons scimitar = new Weapons("Scimitar", "Quick cuts from a light weight weapon. ", 6, 3, 1, 6, DamageType.Slash, Weapon.Scimitar, false);
            Weapons shortsword = new Weapons("Shortsword", "The traditional sword for most situations. ", 6, 3, 1, 6, DamageType.Pierce, Weapon.Shortsword, false);
            Weapons trident = new Weapons("Trident", "When you can't fine a good stick to roast the winers on a campfire substitute. ", 6, 3, 1, 6, DamageType.Pierce, Weapon.Trident, true);
            Weapons warpick = new Weapons("Warpick", "The pickaxe made for war. ", 8, 4, 1, 8, DamageType.Pierce, Weapon.Warpick, false);
            Weapons warhammer = new Weapons("Warhammer", "The hammer made for war. ", 8, 4, 1, 8, DamageType.Blunt, Weapon.Warhammer, false);
            Weapons whip = new Weapons("Whip", "It puts the whip, in coolwhip. ", 4, 2, 1, 4, DamageType.Slash, Weapon.Whip, false);
            Weapons handCrossbow = new Weapons("Hand Crossbow", "A hand held crossbow that is easy to use. ", 4, 2, 1, 6, DamageType.Pierce, Weapon.HandCrossbow, true);
            Weapons heavyCrossbow = new Weapons("Heavy Crossbow", "A crossbow to heavy to use in normal combat. ", 12, 6, 1, 10, DamageType.Pierce, Weapon.HeavyCrossbow, true);
            Weapons longbow = new Weapons("Longbow", "The bow that will reach out and touch you. ", 10, 5, 1, 8, DamageType.Pierce, Weapon.Longbow, true);
            Weapons vine = new Weapons("Vines", "The vines that soem creature use to attack. ", 10, 5, 1, 8, DamageType.Slash, Weapon.Vine, false);
            Weapons bite = new Weapons("Bite", "That moment you relize you didn't bring a better weapon. ", 0, 0, 1, 6, DamageType.Pierce, Weapon.Bite, false);
            Weapons magic = new Weapons("Magic", "When in doubt hit them with a magic missile. ", 0, 0, 1, 8, DamageType.Blunt, Weapon.Magic, true);
            Weapons claw = new Weapons("Claw", "When your teeth are just not cutting it. ", 0,0,1,8,DamageType.Slash, Weapon.Claw, false);
            Weapons rick = new Weapons("Rick", "The man, the Myth, the legend. ", 0, 0, 1, 1, DamageType.Blunt, Weapon.Rick, true);
        #endregion

            List<Weapons> wpns = new List<Weapons>()
            {
                club,dagger,greatclub,handaxe,javelin,lightCrossbow,
                lighthammer,mace,quaterstaff,sickle,spear,shortbow,
                battleaxe,flail,glaive,greataxe,greatsword,longsword,
                maul, morningstar,pike,rapier,scimitar,shortsword,trident,
                warhammer,warpick,whip,handCrossbow,heavyCrossbow,longbow,vine,
                bite, magic, claw,rick

            };
            return wpns;
        }
    }

}


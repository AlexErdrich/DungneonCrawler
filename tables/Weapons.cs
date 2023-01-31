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

        public Weapons(string itemName, string description, decimal wCost, decimal reSellCost, int maxDamge,int minDamage,  DamageType dmgType, Weapon weapon, bool ranged) : base(itemName, description, wCost, reSellCost, minDamage, maxDamge)
        {
            Weapon1 = weapon;
            DmgType = dmgType;
            Ranged = ranged;
        }
        

        
    }

}


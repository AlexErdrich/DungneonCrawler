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

        public Weapon weapon { get; set; }

        public static Weapon wpn() { }
    }
}

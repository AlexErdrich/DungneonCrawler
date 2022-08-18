namespace tables
{
    public class Items
    {

        //Fields (private datatype _camelCase;)
        private int _itemName;
        private int _damageType;
        private int _minDamage;
        private int _maxDamage;
        private decimal _wCost;
        private string _description;

        //Props (public datatype PascalCaseOfCamelCase)

        public int ItemName { get { return _itemName; } set { _itemName = value; } }
        public int DamageType { get { return _damageType; } set { _damageType = value; } }
        public string Description { get { return _description; } set { _description = value; } }
        public int MinDamage { get { return _minDamage; } set { { if (_minDamage <= _maxDamage) { _minDamage = value; } else { _minDamage = _maxDamage; } } } }
        public int MaxDamage { get { return _maxDamage; } set { _maxDamage = value; } }
        public decimal WCost { get { return _wCost; } set { _wCost = value; } }



        
        //Constructors (public class(props)) (ctor + tab + tab for default)


        public Items(string description, decimal wCost, decimal reSellCost, int damageType, int minDamage, int maxDamge, int itemName)
        {
            ItemName = itemName;
            WCost = wCost;
            DamageType = damageType;
            MinDamage = minDamage;
            MaxDamage = maxDamge;
            Description = description;

        }
        public Items() { }

        //Methods

        public int healing() { Random rng = new Random(); int healing =  rng.Next(MinDamage, MaxDamage +1 ); return healing;}

        public int damage() { Random rng = new Random(); int damage = rng.Next(MinDamage, MaxDamage + 1); return damage;}

        public decimal price() { decimal sprice = WCost / 2;return sprice;}       


    }
}

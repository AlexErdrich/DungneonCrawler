namespace tables
{
    public class Items
    {

        //Fields (private datatype _camelCase;)

        private int _minDamage;
        private int _maxDamage;


        //Props (public datatype PascalCaseOfCamelCase)

        public string ItemName { get; set; }     
        public string Description { get; set; }
        public int MinDamage { get { return _minDamage; } set { { if (_minDamage <= _maxDamage) { _minDamage = value; } else { _minDamage = _maxDamage; } } } }
        public int MaxDamage { get; set; }
        public decimal WCost { get; set; }



        
        //Constructors (public class(props)) (ctor + tab + tab for default)


        public Items(string itemName,string description, decimal wCost, decimal reSellCost, int minDamage, int maxDamge )
        {
            ItemName = itemName;
            WCost = wCost;            
            MinDamage = minDamage;
            MaxDamage = maxDamge;
            Description = description;

        }
        public Items() { }

        //Methods

        
        public int alterHealth() { Random rng = new Random(); int damage = rng.Next(MinDamage, MaxDamage + 1); return damage;}

        public decimal price() { decimal sprice = WCost / 2;return sprice;}       

    }//class
}//name
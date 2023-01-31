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
        public int MinDamage { get { return _minDamage; } set { { if (_minDamage <= _maxDamage) { _minDamage = value; } else { _minDamage = _maxDamage -1; } } } }
        public int MaxDamage { get; set; }
        public decimal WCost { get; set; }



        
        //Constructors (public class(props)) (ctor + tab + tab for default)


        public Items(string itemName,string description, decimal wCost, decimal reSellCost, int maxDamge, int minDamage)
        {
            ItemName = itemName;
            WCost = wCost;            
            MaxDamage = maxDamge; 
            MinDamage = minDamage;            
            Description = description;

        }
        public Items() { }

        //Methods

        
        public int alterHealth() { Random rng = new Random(); int damage = rng.Next(MaxDamage,MinDamage); return damage;}

        public decimal price() { decimal sprice = WCost / 2;return sprice;}       

    }//class
}//name
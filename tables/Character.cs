namespace tables
{
    public class Character
    {
        //NAME
        //HEALTH
        //MANA
        //EXP
        //MONEY



        //Fields (private datatype _camelCase;)
        private string _name;
        private int _armorClass;
        private int _currentHealth;
        private int _maxHealth;
        private int _currentMana;
        private int _maxMana;
        private int _currentExp;
        private int _neededExp;
        private decimal _monies;
        private int _class;



        //Props (public datatype PascalCaseOfCamelCase)
        public string Name { get { return _name; } set { _name = value; } }
        public int AC { get { return _armorClass; } set { _armorClass = value; } }
        public int CHealth { get { return _currentHealth; } set { if (value > MaxHealth) { _currentHealth = MaxHealth; } else { _currentHealth = value; } } }
        public int MaxHealth { get { return _maxHealth; } set { _maxHealth = value; } }
        public int CMana { get { return _currentMana; } set { _maxMana = value; } }
        public int MaxMana { get { return _maxMana; } set { _maxMana = value; } }

        public int CExp { get { return _currentExp; } set { _currentExp = value; } }
        public int NExp { get { return _neededExp; } set { _neededExp = value; } }
        public decimal Monies { get { return _monies; } set { _monies = value; } }
        public int Class { get { return _class; } set { _class = value; } }



        //Constructors (public class(props)) (ctor + tab + tab for default)
        public Character(string name, int ac, int cHealth, int maxHealth, int cMana, int maxMana, int cExp, int nExp, decimal monies, int job)
        {
            Name = name;
            AC = ac;
            CHealth = cHealth;
            MaxHealth = maxHealth;
            CMana = cMana;
            MaxMana = maxMana;
            CExp = cExp;
            NExp = nExp;
            Monies = monies;
            Class = job;
        }
        public Character() { }

        //Methods     
        public bool hit()
        {
            Random rng = new Random(); int attack = rng.Next(1, 21); if (attack >= AC) { return true; } else { return false; }
        }
        public int injury(Items weapon) { int Health = CHealth - weapon.damage(); return Health; }

    }
}  
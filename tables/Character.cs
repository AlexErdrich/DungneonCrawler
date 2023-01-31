namespace tables
{
    public abstract class Character
    {
      
        //Fields (private datatype _camelCase;)
        private int _currentHealth;     
        private int _currentMana;    
        private decimal _monies;
       

        public int MyProperty { get; set; }

        //Props (public datatype PascalCaseOfCamelCase)
        public string Name { get; set; }
        public int AC { get; set; }
        public int MaxHealth { get; set;  }  
        public int CHealth { get { return _currentHealth; } set { if (value > MaxHealth) { _currentHealth = MaxHealth; } else { _currentHealth = value; } } }
        public int MaxMana { get; set; }
        public int CMana { get { return _currentMana; } set { if (value > MaxMana) { _currentMana = MaxMana; } else { _currentMana = value; } } }
        public int CExp { get;  set;}
        public int NExp { get; set; }
        public decimal Monies { get { return _monies; } set { _monies = value; } }
        public int Strength { get; set; }
        public int Dexterity { get; set; }
        public int Constitution { get; set; }
        public int Wisdom { get; set; }
        public int Intelligence { get; set; }
        public int Charisma { get; set; }
        public int[] StatMod { get; }
        public Weapons EquippedWeapon { get; set; }




        //Constructors (public class(props)) (ctor + tab + tab for default)
        public Character(string name, int ac, int cHealth, int maxHealth, int cMana, int maxMana, int cExp, int nExp, decimal monies, int str, int con, int dex, int intel, int wis, int cha, Weapons equippedWeapon)
        {
            Name = name;
            AC = ac;  
            MaxHealth = maxHealth;
            CHealth = cHealth;
            MaxMana = maxMana;
            CMana = cMana;
            NExp = nExp;
            CExp = cExp;
            Monies = monies;
            Strength = str;
            Constitution = con;
            Wisdom = wis;
            Charisma = cha;
            Dexterity = dex;
            Intelligence = intel;
            #region
            int[] statmod = { str, con, dex, intel, wis, cha };
            for (int stat = 0; stat < statmod.Length; stat++)
            {
                if (statmod[stat] < 2) { statmod[stat] = -5; }
                else if (statmod[stat] < 4) { statmod[stat] = -4; }
                else if (statmod[stat] < 6) { statmod[stat] = -3; }
                else if (statmod[stat] < 8) { statmod[stat] = -2; }
                else if (statmod[stat] < 10) { statmod[stat] = -1; }
                else if (statmod[stat] < 12) { statmod[stat] = 0; }
                else if (statmod[stat] < 14) { statmod[stat] = +1; }
                else if (statmod[stat] < 16) { statmod[stat] = +2; }
                else if (statmod[stat] < 18) { statmod[stat] = +3; }
                else if (statmod[stat] < 20) { statmod[stat] = +4; }
                else { statmod[stat] = +5; }
            }
            #endregion
            StatMod = statmod;
            EquippedWeapon = equippedWeapon;
        }

        public  Character() { }

        //Methods     
        public virtual bool hit()
        {
            Random rng = new Random(); int attack = rng.Next(1, 21); if (attack >= AC) { return true; } else { return false; }
        }
        public int injury(Items weapon) { int Health = CHealth - weapon.alterHealth(); return Health; }

        public override string ToString()
        {
            return $@"
*******INFO******
{Name}

----
Life: {CHealth} of {MaxHealth}
Mana: {CMana} of {MaxMana}


--- Stat Scores
Str: {Strength} Con: {Constitution} Dex: {Dexterity} 

Int: {Intelligence} Wis: {Wisdom} Cha: {Charisma}

----Items
Equipped Weapon: {EquippedWeapon}

Money: {Monies}

";
        }


    }
}  
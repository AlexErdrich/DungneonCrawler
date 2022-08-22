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
        public int CHealth { get { return _currentHealth; } set { if (value > MaxHealth) { _currentHealth = MaxHealth; } else { _currentHealth = value; } } }
        public int MaxHealth { get; set;  }
        public int CMana { get { return _currentMana; } set { if (value > MaxMana) { _currentMana = MaxMana; } else { _currentMana = value; } } }
        public int MaxMana { get; set; }
        public int CExp { get;  set;}
        public int NExp { get; set; }
        public decimal Monies { get { return _monies; } set { _monies = value; } }
        public int Strength { get; set; }
        public int Dexterity { get; set; }
        public int Constitution { get; set; }
        public int Wisdom { get; set; }
        public int Intelligence { get; set; }
        public int Charisma { get; set; }



        //Constructors (public class(props)) (ctor + tab + tab for default)
        public Character(string name, int ac, int cHealth, int maxHealth, int cMana, int maxMana, int cExp, int nExp, decimal monies, , int str, int con, int dex, int intel, int wis, int cha)
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
            Strength = str;
            Constitution = con;
            Wisdom = wis;
            Charisma = cha;
            Dexterity = dex;
            Intelligence = intel;
            int[] statmod = {str, con, dex, intel, wis, cha};
            for (int stat = 0; stat < statmod.Length; stat++)
            {
                if (statmod[stat] >= 0 && statmod[stat] < 2){ statmod[stat] = -5; }
                else if (statmod[stat] >= 2 && statmod[stat] < 4) { statmod[stat] = -4; }
                else if (statmod[stat] >= 4 && statmod[stat] < 6) { statmod[stat] = -3; }
                else if (statmod[stat] >= 6 && statmod[stat] < 8) { statmod[stat] = -2; }
                else if (statmod[stat] >= 8 && statmod[stat] < 10) { statmod[stat] = -1; }
                else if (statmod[stat] >= 10 && statmod[stat] < 12) { statmod[stat] = 0; }
                else if (statmod[stat] >= 12 && statmod[stat] < 14) { statmod[stat] = +1; }
                else if (statmod[stat] >= 14 && statmod[stat] < 16) { statmod[stat] = +2; }
                else if (statmod[stat] >= 16 && statmod[stat] < 18) { statmod[stat] = +3; }
                else if (statmod[stat] >= 18 && statmod[stat] < 20) { statmod[stat] = +4; }
                else if (statmod[stat] >= 20) { statmod[stat] = +5; }
            }
         
        }
        
        public Character() { }

        //Methods     
        public bool hit()
        {
            Random rng = new Random(); int attack = rng.Next(1, 21); if (attack >= AC) { return true; } else { return false; }
        }
        public int injury(Items weapon) { int Health = CHealth - weapon.damage(); return Health; }


         
        // 0-1 (-5) 2-3 (-4) 4-5 (-3) 6-7 (-2) 8-9 (-1) 10-11 (0) 12-13 (+1) 14-15 (+2) 16-17 (+3) 18-19 (+4) 20 (+5)
    }
}  
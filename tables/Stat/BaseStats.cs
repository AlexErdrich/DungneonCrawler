using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tables.Stat
{
    public class BaseStats
    {
        public float BaseValue;


        public float Value { get { if (isDirty || BaseValue != lastBaseValue) { lastBaseValue = BaseValue; _value = CalculateFinalValue(); isDirty = false; } return _value; } }

        protected bool isDirty = true;
        protected float _value;
        protected float lastBaseValue = float.MinValue;

        protected readonly List<StatMods> moddedStats;

        public BaseStats()
        {
            moddedStats = new List<StatMods>();
        }
        public BaseStats(float baseValue) : this()
        {
            BaseValue = baseValue;
        }
        public virtual void AddModifier(StatMods mod)
        {
            isDirty = true;
            moddedStats.Add(mod);
            moddedStats.Sort();
        }

        protected virtual int ComparedModifierOrder(StatMods a, StatMods b)
        {
            if (a.Order < b.Order)
                return -1;
            else if (a.Order > b.Order)
                return 1;
            return 0;
        }

        public virtual bool RemoveModifier(StatMods mod) { if (moddedStats.Remove(mod)) {isDirty = true; return true;} return false; }

        public virtual bool RemoveSourceModifier(object source)
        {
            bool didremove = false;
            for (int i = moddedStats.Count -1; i >= 0; i--)
            {
                if (moddedStats[i].Source == source)
                {
                    isDirty = true;
                    didremove = true;
                    moddedStats.RemoveAt(i);
                }
            }
            return didremove;
        }

        protected virtual float CalculateFinalValue()
        {
            float finalValue = BaseValue;
            float sumPrecentAdd = 0;
            for (int i = 0; i < moddedStats.Count; i++)
            {
                StatMods mod = moddedStats[i];

                if (mod.Type == StatModType.Flat)
                {
                    finalValue += mod.Value;
                }
                else if (mod.Type == StatModType.PercentAdd)
                {
                    sumPrecentAdd += mod.Value;

                    if (i +1 >= moddedStats.Count || moddedStats[i +1].Type != StatModType.PercentAdd)
                    {
                        finalValue *= -1 + sumPrecentAdd;
                        sumPrecentAdd = 0;
                    }
                }
                else if (mod.Type == StatModType.PercentMult)
                {
                    finalValue *= 1 + mod.Value;
                }


            }

            return (float)Math.Round(finalValue, 2);
        }


    }//end
}//end

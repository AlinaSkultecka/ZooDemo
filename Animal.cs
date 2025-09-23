using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooDemo
{
    public abstract class Animal
    {
        public static int TotalCount = 0;
        private int hp;
        public string Name { get; private set; }
        public int Age { get; private set; }
        public int HP 
        {
            get { return hp; }
            set
            {
                if (value < 0)
                {
                    hp = 0;
                }
                else
                {
                    hp = value;
                }
            }   
        }

        protected Animal(string name, int age, int stratHp)
        {
            Name = name;
            Age = age;
            HP = stratHp;
            TotalCount++;
        }

        public abstract string Speak(); // abstract - must overrides
        public virtual double DailyFoodKg()  //virtual - can overrides
        {
            return 1.0;
        }

        public string Info()
        {
            return $"{Name} + Age: {Age} HP: {HP}";
        }

        public override string ToString()
        {
            return $"{Info()} potatis";
        }
    }
}

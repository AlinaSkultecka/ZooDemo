using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooDemo
{
    public enum DietType
    {
        Herbivore,
        Carnivore,
        Omnivore
    }
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
                else if (value > MaxHP)
                {
                    hp = MaxHP;
                }
                else
                {
                    hp = value;
                }
            }   
        }
        public int MaxHP { get; private set; }
        public DietType Diet { get; protected set; } // protected set - can be set in derived classes


        protected Animal(string name, int age, int startHp, int maxHp)
        {
            Name = name;
            Age = age;
            HP = startHp;
            MaxHP = maxHp;
            TotalCount++;
        }

        public abstract string Speak(); // abstract - must overrides
        public virtual double DailyFoodKg()  //virtual - can overrides
        {
            return 1.0;
        }

        public string Info()
        {
            return $"{Name} + Age: {Age} HP: {HP} MaxHP: {MaxHP} Diet: {Diet}";
        }

        public override string ToString()
        {
            return $"{Info()}, by using ToString";
        }

        public int Birthday()
        {
            Age++;
            return Age;
        }

        
    }
}

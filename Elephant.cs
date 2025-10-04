using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooDemo
{
    public class Elephant : Animal, ITrick, ICanRun
    {
        public static int Count = 0;
        public Elephant(string name, int age, int startHp, int maxHp) : base(name, age, startHp, maxHp)
        {
            Diet = DietType.Herbivore;
            DietMultiplier = 20.0;
            Count++;
        }

        public string DoTrick()
        {
            return "Eating peanuts";
        }

        public override string Speak()
        {
            return "Tuuuu Tuuuu";
        }

        // Elephant eats even more than the base rule suggests:
        public override double DailyFoodKg()  
        {
            return base.DailyFoodKg() * 2.0; // double the base amount
        }

        public double RunSpeedKmh()
        {
            return 20.5;
        }

    }
}

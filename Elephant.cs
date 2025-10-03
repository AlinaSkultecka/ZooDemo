using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooDemo
{
    public class Elephant : Animal, ITrick, ICanRun
    {
        public Elephant(string name, int age, int startHp, int maxHp) : base(name, age, startHp, maxHp)
        {
            Diet = DietType.Herbivore;
        }

        public string DoTrick()
        {
            return "Eating peanuts";
        }

        public override string Speak()
        {
            return "Tuuuu Tuuuu";
        }

        public override double DailyFoodKg()
        {
            return 25.0;
        }

        public double RunSpeedKmh()
        {
            return 20.5;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooDemo
{
    public class Lion : Animal, ICanRun
    {
        public Lion(string name, int age, int startHp, int maxHp) : base(name, age, startHp, maxHp)
        {
            Diet = DietType.Carnivore;
        }

        public override string Speak()   //string must return string
        {
            return "Rooaar";
        }
        public override double DailyFoodKg()
        {
            return 7.5;
        }

        public double RunSpeedKmh()
        {
            return 80.5;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooDemo
{
    public class Elephant : Animal, ITrick
    {
        public Elephant(string name, int age, int stratHp) : base(name, age, stratHp)
        {
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
    }
}

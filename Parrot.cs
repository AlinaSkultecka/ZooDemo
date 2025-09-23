using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooDemo
{
    public class Parrot : Animal, ITrick
    {
        // 1. inheritanse from Aminal +
        // 2. impliment constructor +
        // 3. impliment abstract methods +
        // 4. override the virtual
        public Parrot(string name, int age, int stratHp) : base(name, age, stratHp)
        {
        }

        public override string Speak()
        {
            return "kra kra";
        }

        public override double DailyFoodKg()
        {
            return 0.2;
        }

        public string DoTrick()
        {
            return "Visslar en melodi";
        }
    }
}

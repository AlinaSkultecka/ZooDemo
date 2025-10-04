using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooDemo
{
    public class Parrot : Animal, ITrick, IFly
    {
        // 1. inheritanse from Aminal +
        // 2. impliment constructor +
        // 3. impliment abstract methods +
        // 4. override the virtual
        public static int Count = 0;
        public Parrot(string name, int age, int startHp, int maxHp) : base(name, age, startHp, maxHp)
        {
            Diet = DietType.Herbivore;
            DietMultiplier = 0.2;
            Count++;
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
            return "Twitter a song";
        }

        public double FlySpeedKmh()
        {
            return 20.5;
        }
    }
}

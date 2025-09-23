using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooDemo
{
    public class Zoo
    {
        private List<Animal> animals = new List<Animal> (); 
        public void Add (Animal animal)
            { animals.Add (animal); }

        public void ListAll()
        {
            if (animals.Count == 0) 
            {
                Console.WriteLine("No animals");
                return;
            }

            Console.WriteLine("=== Animals in the list ===");
            for (int i = 0; i < animals.Count; i++)
            {
                Animal a = animals[i];
                Console.WriteLine($"({i + 1}). {a.Info()}");
            }
        }

        
        public void AllSpeak() 
        {
            Console.WriteLine("=== Everyone is saying something ===");
            foreach (Animal a in animals)
            {
                Console.WriteLine($"{a.Name}: {a.Speak}");
            } 
        }
        public void ShowFeedingPlan()
        {
            Console.WriteLine(" === Food plan (Kg/day) ===");
            foreach(Animal a in animals)
            {
                Console.WriteLine($"{a.Name}:{a.DailyFoodKg()} kg");
            }
        }

        public void ShowTrick()
        {
            Console.WriteLine(" === Triks === ");
            foreach(Animal a in animals)
            {
                ITrick t = a as ITrick;

                if (t != null)
                {
                    Console.WriteLine($"{a.Name} do {t.DoTrick()}");
                }
                else
                {
                    Console.WriteLine($"{a.Name} does not do tricks");
                }
            }
        }

        public void TotalFoodKG()
        {
            double total = 0;
            foreach (Animal a in animals)
            {
                total += a.DailyFoodKg();
            }
            Console.WriteLine("The total eaten amount of food per day is " + total);

        }

        public void ShowSpeed()
        {
            Console.WriteLine($" === Animal Speed === ");
            foreach (Animal a in animals)
            {
                ICanRun r = a as ICanRun;
                if (r != null)
                {
                    Console.WriteLine($"{a.Name} speed: {r.RunSpeedKmh()}");
                } else
                {
                    Console.WriteLine($"{a.Name} does not run");
                }
            }
        }
    }
}

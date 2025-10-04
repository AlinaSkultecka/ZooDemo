using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

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
                Console.WriteLine(a);    //use verride ToString()
            }
        }

        
        public void AllSpeak() 
        {
            Console.WriteLine("=== Everyone is saying something ===");
            foreach (Animal a in animals)
            {
                Console.WriteLine($"{a.Name}: {a.Speak()}");
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
            Console.WriteLine(" === Tricks === ");
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
            Console.WriteLine($"The total eaten amount of food per day is + {total} kg");

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

        public void ShowRunnersSorted()
        {
            var runners = new List<(Animal animal, double speed)>();

            foreach (Animal a in animals)
            {
                if (a is ICanRun runner)
                {
                    runners.Add((a, runner.RunSpeedKmh()));
                }
            }

            runners.Sort((x, y) => y.speed.CompareTo(x.speed)); // fastest first

            Console.WriteLine("=== Running animals sorted by speed ===");
            foreach (var (animal, speed) in runners)
            {
                Console.WriteLine($"{animal.Name} runs at {speed} km/h");
            }
        }



        public void Heal(string name)
        {
            Animal an = null;
            foreach (Animal animal in animals)
            {
                if (animal.Name == name)
                {
                    an = animal;
                    break; // stop when found
                }
            }
            if (an != null)
            {
                an.HP = an.MaxHP;
                Console.WriteLine($"{an.Name} is healed and now has {an.HP} HP");
            }
            else
            {
                Console.WriteLine($"No animal with the name {name} was found.");
            }
        }

        public void DemageAnimal(string name, int damage)
        {
            Animal an = null;

            foreach (Animal animal in animals)
            {
                if (animal.Name == name)
                {
                    an = animal;
                    break; // stop when found
                }
            }

            if (an != null)
            {
                an.HP -= damage;
                Console.WriteLine($"{an.Name} got {damage} damage and now has {an.HP} HP left");
            }
            else
            {
                Console.WriteLine($"No animal with the name {name} was found.");
            }
        }


        public Animal? FindByName(string name)
        {
            foreach (Animal animal in animals)
            {
                if (animal.Name == name)
                {
                    return animal;   // found! return immediately
                }
            }
            return null;             // reached the end, nothing found
        }

        public void PrintFoundByNameInfo(string name)
        {
            Animal? animal = FindByName(name);

            if (animal != null)
            {
                Console.WriteLine("Animal found:");
                Console.WriteLine(animal.Info());
            }
            else
            {
                Console.WriteLine($"No animal with the name {name} was found.");
            }
        }

        public void ListByDiet(DietType diet)
            {
            Console.WriteLine($"Animals with diet {diet}");
            foreach (Animal a in animals)
            {
                if (a.Diet == diet)
                {
                    Console.WriteLine($" {a.Name}'s diet: {diet}");
                }
            }
        }

        public void ShowFlights()
        {
            Console.WriteLine($" === Flying Animals === ");
            foreach (Animal a in animals)
            {
                IFly f = a as IFly;
                if (f != null)
                {
                    Console.WriteLine($"{a.Name} speed: {f.FlySpeedKmh()}");
                }
                else
                {
                    Console.WriteLine($"{a.Name} does not fly");
                }
            }
        }

        public void ShowSpeciesCount()
        {
            Console.WriteLine($" === Species Count === ");
            Console.WriteLine($"Lions: {Lion.Count}");
            Console.WriteLine($"Parrots: {Parrot.Count}");
            Console.WriteLine($"Elephants: {Elephant.Count}");
        }

        public void ShowReport()
        {
            Console.WriteLine("=== Zoo Report ===");
            foreach (Animal a in animals)
            {
                Console.WriteLine(a.GetReportLine());
            }
        }

    }
}

namespace ZooDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
          Zoo zoo = new Zoo();

            // Added new animals
            Animal Simba = new Lion("Simba", 10, 100, 500);
            Animal Zazoo = new Parrot("Zazoo", 1, 40, 100);
            Animal Maria = new Elephant ("Maria", 12, 100, 450);

            zoo.Add(Simba);
            zoo.Add(Zazoo);
            zoo.Add(Maria);

            Console.WriteLine("Hello, Zoo!");
            Console.WriteLine("Total amount of animals is " + Animal.TotalCount);
;
            Console.WriteLine("");
            zoo.ShowSpeciesCount();

            Console.WriteLine("");
            zoo.ListAll();
            
            Console.WriteLine("");
            zoo.ShowFeedingPlan();

            Console.WriteLine("");
            zoo.TotalFoodKG();

            Console.WriteLine("");
            zoo.AllSpeak();

            Console.WriteLine("");
            zoo.ShowTrick();

            Console.WriteLine("");
            zoo.ShowSpeed();
            zoo.ShowRunnersSorted();


            Console.WriteLine("\n=== Fight ===");
            Console.WriteLine("Simba got into a fight");
            zoo.DemageAnimal("Simba", 50);
            zoo.Heal("Simba");

            Console.WriteLine("\n=== Birhtday ===");
            Console.WriteLine($"Simba's age is {Simba.Age}");
            int newAge = Simba.Birthday();  // newAge now holds 11
            Console.WriteLine($"Simba's new age is {newAge} after his bithday");      // prints 11

            Console.WriteLine("\n=== ToString ===");
            Console.WriteLine(Simba.ToString());
;
            Console.WriteLine("\n=== Finding an animal ===");
            zoo.PrintFoundByNameInfo("Maria");
            zoo.PrintFoundByNameInfo("Bob");

            Console.WriteLine("\n=== List of animal's diet ===");
            zoo.ListByDiet(DietType.Carnivore);
            zoo.ListByDiet(DietType.Herbivore);

            Console.WriteLine("");
            zoo.ShowFlights();

            Console.WriteLine("");
            Console.WriteLine(Simba.GetReportLine());

            zoo.ShowReport();
        }
    }
}

namespace ZooDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
          Zoo zoo = new Zoo();

            Animal Simba = new Lion("Simba", 10, 100);
            Animal Zazoo = new Parrot("Zazoo", 1, 40);
            Animal Maria = new Elephant ("Maria", 12, 100);


            zoo.Add(Simba);
            zoo.Add(Zazoo);
            zoo.Add(Maria);

            Console.WriteLine("Total amount of animals is " + Animal.TotalCount);

            zoo.ListAll();
            zoo.ShowFeedingPlan();
            zoo.AllSpeak();

            zoo.ShowTrick();
            zoo.TotalFoodKG();

            zoo.ShowSpeed();
        }
    }
}

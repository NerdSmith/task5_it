

using task5_it;

namespace Program
{
    class Program
    {
        public static void Main(string[] args)
        {
            Costume c = new Costume("Tshirt", 50);
            c.addLabel("StoneIsland");
            c.WearOut(8);
            c.WearOut(8);
            c.WearOut(8);
            Console.WriteLine(c.ToString());
        }
    }
}
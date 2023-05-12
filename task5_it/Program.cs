

using task5_it;

namespace Program
{
    class Program
    {
        public static void Main(string[] args)
        {
            List<IFiber> list = new List<IFiber>();
            list.Add(new Costume("Tshirt", 50));
            list.Add(new Costume("Pants", 60));
            list.Add(new Costume("Sweater", 30));

            foreach (IFiber item in list)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}
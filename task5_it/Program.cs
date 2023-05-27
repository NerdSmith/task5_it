

using task5_it;

namespace Program
{
    class Program
    {
        public static void Main(string[] args)
        {
            List<IFiber> list = new List<IFiber>();
            Costume c = new Costume("Costume#312", 50);
            Dress d = new Dress("Dress#5652", 60);
            Short sh = new Short("Short#378", 20);
            list.Add(c);
            list.Add(d);
            list.Add(sh);
            
            foreach (IFiber item in list)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}
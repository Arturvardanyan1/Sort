using System.Globalization;

namespace ConsoleApp29
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RandomClass randomClass = new RandomClass();
            Console.WriteLine("Random List Sort ");
            randomClass.RandomList();
            Console.WriteLine();
            Console.ReadKey();
            Console.WriteLine("Random Array Sort ");
            randomClass.RandomArr();
            Console.WriteLine();
            Console.ReadKey();
            Console.WriteLine("Random Queue Sort ");
            randomClass.RandomQueue();
            Console.ReadKey();
            Console.WriteLine("Random Steck Sort");
            randomClass.RandomSteck();

           
        }
    }
}


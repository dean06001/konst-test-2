using System;
namespace konst_test_2
{
    class Program
    {
        static void Main()
        {
            Person p = new Person();
            Console.Write("Skriv namn: ");
            p.Namn = Console.ReadLine();
            Console.Write("Skriv efternamn: ");
            p.Efternamn = Console.ReadLine();
            Console.WriteLine(p.Namn);
            Console.WriteLine(p.Efternamn);
            Console.ReadLine();
        }
    }
}
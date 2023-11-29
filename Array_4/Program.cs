// See https://aka.ms/new-console-template for more information
using System;
namespace array_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] namn = new string[5];
            Console.WriteLine("Skriv in namn nmr 1: ");
            namn[0] = Console.ReadLine();
            Console.WriteLine("Skriv in namn nmr 2: ");
            namn[1] = Console.ReadLine();
            Console.WriteLine("Skriv in namn nmr 3: ");
            namn[2] = Console.ReadLine();
            Console.WriteLine("Skriv in namn nmr 4: ");
            namn[3] = Console.ReadLine();
            Console.WriteLine("Skriv in namn nmr 5: ");
            namn[4] = Console.ReadLine();
            Console.WriteLine("--------------------------------------------------------------------------");
            int[] ålder = new int[5];
            Console.WriteLine("Skriv in " + namn[0] + " ålder: ");
            ålder[0] = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Skriv in " + namn[1] + " ålder: ");
            ålder[1] = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Skriv in " + namn[2] + " ålder: ");
            ålder[2] = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Skriv in " + namn[3] + " ålder: ");
            ålder[3] = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Skriv in " + namn[4] + " ålder: ");
            ålder[4] = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Vänta lite medans talen kalkuleras");
            Thread.Sleep(1500);
            Console.Clear();

            int medelålder = (ålder[0] + ålder[1] + ålder[2] + ålder[3] + ålder[4])/5;
            Console.WriteLine("Medelålder: " + medelålder);
            int maxålder = 0;
            for (int i = 1; i < ålder.Length; i++)
            {
                if (ålder[i] > ålder[maxålder])
                {
                    maxålder = i;
                }
            }
            Console.WriteLine("Den äldsta personen är: " + namn[maxålder] + " Åldern är: " + ålder[maxålder]);
        }
    }
}
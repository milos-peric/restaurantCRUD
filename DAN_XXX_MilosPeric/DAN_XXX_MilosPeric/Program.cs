using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAN_XXX_MilosPeric
{
    class Program
    {
        public delegate int MyDelegateRandomGenerator();
        public delegate void MyDelegateCaseHandler(int num);
        static void Main(string[] args)
        {

            Console.WriteLine("\nPritisnite ili drzite spejs za generisanje random broja od 1 do 150");
            ConsoleKeyInfo cki;
            Utility util = new Utility();
            MyDelegateRandomGenerator myDelRandGen = util.RandomGenerator;
            MyDelegateCaseHandler myDelCaseHandl = util.RandomCase;
            int broj = 0;
            do
            {
                cki = Console.ReadKey(true);
                if (cki.Key == ConsoleKey.Spacebar)
                {
                    broj = myDelRandGen();
                    Console.WriteLine(broj);
                }
                if (cki.Key == ConsoleKey.Enter)
                {
                    myDelCaseHandl(broj);
                }
            } while (cki.Key != ConsoleKey.X);
            Console.ReadKey();
        }
    }
}

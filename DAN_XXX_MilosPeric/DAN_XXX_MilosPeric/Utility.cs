using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAN_XXX_MilosPeric
{
    class Utility
    {
        Random random = new Random();
        int broj = 0;

        public int RandomGenerator()
        {
            broj = random.Next(1, 151);
            return broj;
        }

        public void RandomCase(int number)
        {
            Console.WriteLine("Pritisnut Enter. Broj {0} je snimljen.", number);
            if (number < 75)
            {
                Console.WriteLine($"Broj < 75 => {2}^{number} = {(long)Math.Pow(2, number):N0}");
            }
            else if (number > 75)
            {
                Console.WriteLine("Broj > 75 => {0} * {0} = {1:N0}", number, number * number);
            }
            else if (number == 75)
            {
                Console.WriteLine("Broj = 75 => Generisan novi broj {0}", RandomGenerator());
            }
        }
    }
}

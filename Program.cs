using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szamrendszerek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int szam = 0;
            Console.WriteLine("Írj be egy 10-es számrendszerben lévő számot: ");
            szam = Convert.ToInt32(Console.ReadLine());

            while (szam <= 0)
            {
                if (szam % 2 == 0)
                {
                    
                    szam <= 1;
                }

                else
                {

                }
            }
            Console.WriteLine(); ;
        }
    }
}

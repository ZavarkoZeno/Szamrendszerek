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
            Console.WriteLine("Adjon meg egy 10-es számrendszerbeli számot: ");
            szam = Convert.ToInt32(Console.ReadLine());

            while (szam % 2 == 0)
            {

            }
        }
    }
}

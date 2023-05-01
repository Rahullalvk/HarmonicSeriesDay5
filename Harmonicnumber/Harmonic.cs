using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harmonicnumber
{
    internal class Harmonic
    {
        public static void Displayharmonic()
        {
            double har = 0.0;
            Console.WriteLine("Enter a number");
            int N = Convert.ToInt32(Console.ReadLine());
             {
                for (int i = 1; i < N; i++)
                {

                    Console.Write("1/" + i + "+");
                   
                }
            }
        }
    }
}

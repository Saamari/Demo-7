using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numbers
{
    class Program
    {
        int k;
        double d;
        static void Main(string[] args)
        {
            int n;
            double d;
            bool integers = true;
            bool doubles = true;
            string lines;

 
            string line = null;
            System.IO.StreamWriter outputIntegers  = new System.IO.StreamWriter(@"d:\INT");
            System.IO.StreamWriter outputDouble = new System.IO.StreamWriter(@"d:\Double");

            do
            {
                Console.Write("Give A number");
                line = Console.ReadLine();

                if( integers)
                {
                    
                }

                outputIntegers.WriteLine(line);
                outputDouble.WriteLine(line);
            } while (line.Length != 0);
            //suljetaan tiedosto
            outputIntegers.Close();
            outputDouble.Close();







        }
    }
}

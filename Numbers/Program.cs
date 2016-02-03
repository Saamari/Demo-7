using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numbers
{
    class Program
    {


        static void Main(string[] args)
        {



            string line = null;
            int integer;
            double desim;
            System.IO.StreamWriter outputIntegers = new System.IO.StreamWriter(@"d:\INT.txt");
            System.IO.StreamWriter outputDouble = new System.IO.StreamWriter(@"d:\Double.txt");

            do
            {
                Console.WriteLine("Give A number");
                line = Console.ReadLine();

                bool parsed = int.TryParse(line, out integer);

                if (!parsed)
                {
                    double.TryParse(line, out desim);
                    outputDouble.WriteLine(desim);
                }

                else
                {
                    outputIntegers.WriteLine(integer);
                }

              
            } while (line.Length != 0);
            //suljetaan tiedosto
            outputIntegers.Close();
            outputDouble.Close();

            try
            {
                using (StreamReader sr = new StreamReader(@"d:\INT.txt"))
                using (StreamReader sr1 = new StreamReader(@"d:\Double.txt"))
                {
                    String line2 = sr.ReadToEnd();
                    String line3 = sr1.ReadToEnd();
                    Console.WriteLine("Integers " + line2);
                    Console.WriteLine("Double " + line3);
                }

             }
            catch (Exception e)
            {
                Console.WriteLine("ERROR");
            }
    }
    }
}
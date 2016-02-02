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
            string line = null;
            System.IO.StreamWriter outputFile = new System.IO.StreamWriter(@"d:\T2");

            // kysytään käyttäjältä rivejä
            do
            {
                Console.Write("Give A number");
                line = Console.ReadLine();

                



                outputFile.WriteLine(line);
            } while (line.Length != 0);
            //suljetaan tiedosto
            outputFile.Close();
            


        }
    }
}

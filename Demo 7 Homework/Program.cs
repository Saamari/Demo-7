using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Demo_7_Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string line = null;
            System.IO.StreamWriter outputFile = new System.IO.StreamWriter(@"d:\T1");
            
            // kysytään käyttäjältä rivejä
            do
            {
                Console.Write("Give A number");
                line = Console.ReadLine();

                outputFile.WriteLine(line);
            } while (line.Length != 0);
            //suljetaan tiedosto
            outputFile.Close();

            try {
                string text = File.ReadAllText(@"d:\T1");
                Console.WriteLine(text);
            }catch (FileNotFoundException)
            {
                Console.WriteLine(" File not found!!");
            }
        }        




        }
    }


using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Tv_program
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Television> tv = new List<Television>();
            tv.Add(new Television { Name = "Avara Luonto ", Channel = "YLE 1 ", Start = "11.30", End = "12.30", Info = "Luonto ohjelma " });
            tv.Add(new Television { Name = "Pikku kakkonen ", Channel = "Yle 2", Start = "17.00", End = "17.25", Info = "Lasten ohjelma" });
            tv.Add(new Television { Name = "Emmerdale", Channel = "Mtv3", Start = "18.00", End = "18.30", Info = "draama kakkaa" });

            Stream writeMultipleStream = new FileStream("MyTvshows.bin", FileMode.Create, FileAccess.Write, FileShare.None);
            IFormatter formatter = new BinaryFormatter();
            formatter.Serialize(writeMultipleStream, tv);

            writeMultipleStream.Close();

            Stream opeMultipleStream = new FileStream("MyTvshows.bin", FileMode.Open, FileAccess.Read, FileShare.Read);
            List<Television> readTv = (List<Television>)formatter.Deserialize(opeMultipleStream);

            opeMultipleStream.Close();

            foreach(Television t in readTv)
            {
                Console.WriteLine("Tv today   {0} {1}  {2}  {3}  {4}", t.Name , t.Channel , t.Start, t.End , t.Info);
            }
        }
    }
}

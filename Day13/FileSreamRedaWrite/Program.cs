using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileSreamRedaWrite
{
    class Program
    {
        static string file = @"D:\UST_Training\Day13\FileSreamRedaWrite\poem.txt";
        static void Main()
        {
            Write();
           Read();

        }
        static void Write()
        {
            StreamWriter filestream= new StreamWriter(file);
            filestream.WriteLine("Example of filestream");
            filestream.WriteLine("Another example of writing");
            filestream.Close();
        }
        static void Read()
        {
            StreamReader fileStream= new StreamReader(file);
            string s = null;
            while (s = fileStream.ReadLine() != null)
            {
                Console.WriteLine(s);
          
        }
    }
}

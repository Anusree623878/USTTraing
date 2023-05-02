using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IODemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DirectoryInfo dir1 = new DirectoryInfo(".");
            DirectoryInfo dr1 = new DirectoryInfo(@"D:\UST_Training\Day12\IODemo\workingDirectory");
            DirectoryInfo dr2 = new DirectoryInfo(@"D:\UST_Training\Day12\IODemo\workingDirectory\TEST");
            dr2.Create();

            
        }
    }
}

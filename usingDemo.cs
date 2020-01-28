using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace usingDemo
{
    class usingDemo
    {
        public static void Main()
        {
            //Setting path to text file
            string path = @"D:\Karthik\MyFile1.txt";
            //Checking if file exists
            if (!File.Exists(path))
            {
                // Create a file to write to.
                //Demonstartion of using 
                using (StreamWriter sw = File.CreateText(path))
                {
                    //Writing data to File.
                    sw.WriteLine("Hello");
                    sw.WriteLine("And");
                    sw.WriteLine("Welcome");
                }
            }

            // Open the file to read from.
            using (StreamReader sr = File.OpenText(path))
            {
                string s;
                while ((s = sr.ReadLine()) != null)
                {
                    //Displaying contents of file on Console.
                    Console.WriteLine(s);
                    Console.ReadLine();
                }
            }
        }
    }
}

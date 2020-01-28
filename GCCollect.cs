using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCCollect
{
    //Main class
    class Program
    {
        static void Main(string[] args)
        {
            //Object creation for GCTEST class
            GCTest test;
            for(int i = 0; i < 1000; i++)
            {
                test = new GCTest();//Creating 1000 objects for Test Class to use up memory.
            }
            //Displaying actual memory used by the program.
            Console.WriteLine("Before GC.Collect is called: "+GC.GetTotalMemory(false));
            //Garbage Collection
            GC.Collect();
            //Displaying memory used by the program after garbage collection.
            Console.WriteLine("After GC.Collect is called: "+GC.GetTotalMemory(true));
            Console.ReadLine();
        }
    }
    //Test Class
    class GCTest{
        //array initialization
        int[] TestArray = new int[10000];
    }
}

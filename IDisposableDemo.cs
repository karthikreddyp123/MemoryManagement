using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace IDisposableDemo
{   //Test class implementing IDisposable Interface
    class IDisposableDemo:IDisposable
    {
        //Setting path to text file
        private static string path = @"D:\Karthik\MyFile1.txt";
        private StreamReader sr;
        //Method to write Read data from afile.
        public void DisposeDemo()
        { 
        // Open the file to read from.
            sr = File.OpenText(path);
            string s;
            while ((s = sr.ReadLine()) != null)
            {
                //Displaying contents of file on console.
                Console.WriteLine(s);
            }   
        }

        #region IDisposable Support
        //setting up a flag so that disposing is done only once.
        private bool disposedValue = false; 

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    //Disposing object of stream Reader.
                    sr.Close();
                    Console.WriteLine("Object is disposed.");
                }
            //setting up flag to true
            disposedValue = true;
            }
        }

         //Destructor impelentation
         ~IDisposableDemo()
         {
            //Destructor
           Dispose(false);
         }
        //Impementation of dispose method
        public void Dispose()
        {
            Dispose(true);
            //To make sure that Destructor is not executed once dispose method is called.
            GC.SuppressFinalize(this);
        }
        public static void Main()
        {
            //Object creation for main class
            IDisposableDemo p = new IDisposableDemo();
            //Calling DisposeDemo method
            p.DisposeDemo();
            //Calling Dispose method.
            p.Dispose();
            Console.ReadLine();
        }
        #endregion
    }
}

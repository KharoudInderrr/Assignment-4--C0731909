using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Assignment_4__C0731909
{

    // Student id : C0731909     Student name - Inderjeet Singh
    //Student id: C0726115       Student name - Robin bhatia
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Downloading file");
            Download();
            Console.ReadLine();

        }


        static void Download()
        {
            Task.Run(() => {
                
                    Thread.Sleep(3000);
                    Console.WriteLine("Download  Complete");
                });
            
    }
    }
}

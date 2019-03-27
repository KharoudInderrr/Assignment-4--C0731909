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


        static async  void Download()
        {
            await Network.Download();
            Console.WriteLine("Download Complete");
    }
    }
    //imaginary external network library

    class Network
    {
        static public Task Download()
        {
            return Task.Run(() => Thread.Sleep(3000));
        }
    }
}


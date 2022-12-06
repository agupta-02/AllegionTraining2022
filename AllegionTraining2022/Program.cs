using AllegionUtility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllegionTraining2022
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Greetings grt = new Greetings();

            Console.WriteLine("Hello World");

            grt.SayHelloQA();

            grt.SayHelloDev();

            //grt.SayHelloLines(4, "Hello");
        }
    }
}

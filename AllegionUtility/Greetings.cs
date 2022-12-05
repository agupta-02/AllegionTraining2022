using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllegionUtility
{
    public class Greetings
    {
        public void SayHelloQA() { Console.WriteLine("Welcome to QA"); }

        public void SayHelloDev() { Console.WriteLine("Welcome to Development"); }

        public void SayHelloLines(int count, string message)
        {
            for(int i = 0; i < count; i++)
            {
                Console.WriteLine(message);
            }
        }
    }
}

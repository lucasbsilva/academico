using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumRandon
{
    class Program
    {
        static void Main(string[] args)
        {
            Random randNum = new Random();
            Console.WriteLine(randNum.Next(10, 1000));
            Console.ReadKey();
        }
    }
}

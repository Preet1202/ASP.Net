using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool Equal = calculator.areEqual<String>("1", "1");
            if(Equal)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
        }
    }

    public class calculator
    {
        public static bool areEqual<T>(T a,T b)
        {
            return a.Equals(b);
        }
    }
}

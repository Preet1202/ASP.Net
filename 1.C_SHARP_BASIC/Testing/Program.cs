using System;

namespace Tutlane
{
    public class SampleClass
    {
        public void GMethod<T>(T a, T b)
        {
            Console.WriteLine("Param1: {0}", a);
            Console.WriteLine("Param2: {0}", b);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("****Generics Method Example****");
            SampleClass s = new SampleClass();
            s.GMethod<int>(1, 2);
            s.GMethod("Suresh Dasari", "Hyderabad");
            Console.ReadLine();
        }
    }
}
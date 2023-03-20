using System;

namespace Singleton
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Library l1=Library.GetInstance();
            Library l2=Library.GetInstance();
            Console.WriteLine("Hello World!");
        }
    }
}

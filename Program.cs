using System;

namespace InterfaceImplementation
{
    class Program
    {
        static void Main(string[] args)
        {
            Focus focus = new();
            Console.WriteLine(focus.brandName().ToString());
            Console.WriteLine(focus.standardColor().ToString());

            NewFocus focus1 = new();
            
        }
    }
}

using System;

namespace OPP_Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            Pen pencil = new Pen();
            pencil.Write(123);
            Console.WriteLine($"The brand of the pen is: {pencil.Brand}");
            Console.WriteLine($"The colour of the pen is: {pencil.InkColor}");
            Console.WriteLine($"Whether the pen has lid: {pencil.InkColor}");
            Console.WriteLine($"The current ink level in mL is : {pencil.MaxInk} mL");
            Console.WriteLine($"The current ink percentage left : {pencil.InkLevel} %");

        }
    }
}

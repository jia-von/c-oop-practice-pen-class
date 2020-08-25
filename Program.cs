using System;

namespace OPP_Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            Pen pencil = new Pen();
            pencil.Write();
            Console.WriteLine(pencil.InkLevel);

        }
    }
}

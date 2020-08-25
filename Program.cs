using System;

namespace OPP_Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            Pen pencil = new Pen();

            Console.WriteLine($"{pencil.HasLid} \n" + $"{pencil.Brand} \n" + $"{pencil.InkColor} \n" + $"{pencil.InkLevel} \n" + $"{pencil.MaxInk} \n");
        }
    }
}

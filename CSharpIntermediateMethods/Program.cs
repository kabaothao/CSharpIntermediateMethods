// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using System;

namespace CSharpIntermediateMethods // Note: actual namespace depends on the project name.
{   
    internal class Program
    {
        static void Main(string[] args)
        {
            var point = new Point(10, 20);
            point.Move(null);
            Console.WriteLine("Point is at ({0}, {1})", point.X, point.Y);

            point.Move(100, 200);
            Console.WriteLine("Point is at ({0}, {1})", point.X, point.Y);



        }
    }
}
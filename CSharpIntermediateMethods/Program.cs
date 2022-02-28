// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using System;

namespace CSharpIntermediateMethods // Note: actual namespace depends on the project name.
{   
    public static class Program
    {   


        static void Main(string[] args)
        {

            //var number = int.Parse("abc");
            int number;
            var result = int.TryParse("abc", out number); //tryparse does not throw an exception and that the reason it returns a boolean
            if (result)
                Console.WriteLine(number);
            else
                Console.WriteLine("Conversion failed");


        }



        static void UseParams()
        {
            var calculator = new Calculator();
            Console.WriteLine(calculator.Add(1, 2));
            Console.WriteLine(calculator.Add(1, 2, 3));
            Console.WriteLine(calculator.Add(1, 2, 3, 4));
            Console.WriteLine(calculator.Add(new int[] { 1, 2, 3, 4, 5 }));
        }

        static void UsePoints()
        {
            try
            {
                var point = new Point(10, 20);
                point.Move(new Point(40,60));
                Console.WriteLine("Point is at ({0}, {1})", point.X, point.Y);

                point.Move(100, 200);
                Console.WriteLine("Point is at ({0}, {1})", point.X, point.Y);
            }
            catch (Exception)
            {

                Console.WriteLine("An unexpected error occured");
            }

        }




    }
}


/*
A concept that goes hand-in-hand with the signature of a method is overloading.

So basically overloading means having a method with the same name but different signatures.



Agenda:
1. Signature of Methods
2. Methods Overloading
3. Params modifier
2. Ref modifier
3. Out modifier

 */
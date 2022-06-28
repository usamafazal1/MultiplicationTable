using System;

namespace QuestionNo6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number you want the multiplication table for: ");
            
            //ask for the input of the number and store it in an integer type variable
            int n = Convert.ToInt32(Console.ReadLine());         
            for (int i = 0; i < n+1; i++)
            {
                Console.WriteLine("{0} * {1}", i, n);
                Console.WriteLine("equals " + i * n);
                Console.WriteLine();
            }
        }
    }
}

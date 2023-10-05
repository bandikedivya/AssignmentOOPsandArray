using System;

namespace ArraySum
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare and initialize an array
            int[] numbers = { 1, 2, 3, 4, 5, 6 };

            // Variable to store the sum
            int sum = 0;

            // Calculate the sum of all elements in the array
            foreach (int num in numbers)
            {
                sum += num;
            }

            // Print the array elements
            Console.Write("Array Elements: ");
            foreach (int num in numbers)
            {
                Console.Write(num + " ");
            }

            // Print the sum
            Console.WriteLine("\nSum of all elements in the array: " + sum);
            Console.Read();
        }
    }
}

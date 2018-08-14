using System;
using System.Collections.Generic;

namespace ArraysAndLists
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a one-dimensional Array of strings. 
            // Ask the user to select an index of the Array 
            // and then display the string at that index on the screen
            string[] str = new String[] { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten" };
            Console.WriteLine("Enter the index of element you wish to print to screen: ");
            
            int index = Convert.ToInt16( Console.ReadLine() );
            while ( index < 0 || index >= str.Length )
            {
                // Add in a message that displays when the user selects an index that doesn’t exist.
                Console.WriteLine("Index out of bounds. Please try again.");
                index += 1;
                index = Convert.ToInt16(Console.ReadLine());                
            }
            Console.WriteLine("Value of the index you picked: " + str[index]);

            // Create a one-dimensional Array of integers. Ask the user to select an index 
            // of the Array and then display the integer at that index on the screen
            int[] intArray = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Console.WriteLine("==========================================================");
            Console.WriteLine("Enter the index of element you wish to print to screen: ");
            int ind = Convert.ToInt16(Console.ReadLine());
            while (ind < 0 || ind >= str.Length)
            {
                Console.WriteLine("Index out of bounds. Please try again.");
                ind += 1;
                ind = Convert.ToInt16(Console.ReadLine());
            }
            Console.WriteLine("Value of the index you picked: " + intArray[ind]);

            // Create a List of strings. Ask the user to select an index of the 
            // List and then display the content at that index on the screen.
            Console.WriteLine("==========================================================");
            // Create list:
            int counter = 0;
            List<string> list = new List<string>();
            while (counter < str.Length)
            {
                list.Add(str[counter]);
                counter++;
            }

            Console.WriteLine("Enter the index of list element you wish to print to screen: ");

            index = Convert.ToInt16(Console.ReadLine());
            
            while (index < 0 || index >= list.Count)
            {
                // Add in a message that displays when the user selects an index that doesn’t exist.
                Console.WriteLine("Index out of bounds. Please try again.");
                index += 1;
                index = Convert.ToInt16(Console.ReadLine());
            }
            Console.WriteLine("Element in the list at the index you picked: " + list[index]);
        }
    }
}

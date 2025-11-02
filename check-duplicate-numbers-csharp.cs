using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    // Method to check if the array contains any duplicate numbers
    static bool ContainsDuplicate(int[] nums)
    {
        Array.Sort(nums); // Sort the array to make duplicates adjacent
        for (int i = 0; i < nums.Length - 1; i++)
        {
            if (nums[i] == nums[i + 1]) // Compare current element with the next
                return true; // Duplicate found
        }
        return false; // No duplicates found
    }

    static void Main()
    {
        // ⭐ Program introduction for the user
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("=========================================");
        Console.WriteLine("Duplicate Number Checker Program");
        Console.WriteLine("=========================================");
        Console.ResetColor();
        Console.WriteLine("This program lets you enter a list of numbers,");
        Console.WriteLine("then checks if there are any duplicates in the list.\n");

        // List to store user-entered numbers
        List<int> numbers = new List<int>();
        Console.WriteLine("Enter numbers one by one (type 'done' to finish'):");

        // Loop to read numbers from user
        while (true)
        {
            string input = Console.ReadLine();

            if (input.ToLower() == "done")
                break; // Stop input when user types 'done'

            if (int.TryParse(input, out int number)) // Validate input is an integer
                numbers.Add(number); // Add valid number to the list
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid input! Please enter a valid integer.");
                Console.ResetColor();
                continue; // Ask for input again
            }
        }

        // Check if user entered no numbers
        if (numbers.Count == 0)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("No numbers were entered. Exiting program.");
            Console.ResetColor();
            return; // Exit the program safely
        }

        // Call method to check for duplicates
        bool result = ContainsDuplicate(numbers.ToArray());

        // Display result to the user
        Console.WriteLine("Contains duplicate? " + result);
    }
}

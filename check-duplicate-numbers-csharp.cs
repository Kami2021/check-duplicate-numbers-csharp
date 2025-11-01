using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static bool ContainsDuplicate(int[] nums)
    {
        Array.Sort(nums);
        for (int i = 0; i < nums.Length - 1; i++)
        {
            if (nums[i] == nums[i + 1])
                return true;
        }
        return false;
    }

    static void Main()
    {
        List<int> numbers = new List<int>();
        Console.WriteLine("Enter numbers one by one (type 'done' to finish):");

        while (true)
        {
            string input = Console.ReadLine();

            if (input.ToLower() == "done")
                break; // Stop when the user types 'done'

            if (int.TryParse(input, out int number))
            {
                numbers.Add(number);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("❌ Invalid input! Please enter a valid integer.");
                Console.ResetColor();
                continue; // Ask again
            }
        }

        bool result = ContainsDuplicate(numbers.ToArray());
        Console.WriteLine("Contains duplicate? " + result);
    }
}

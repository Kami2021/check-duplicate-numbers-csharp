

# 🧮 Duplicate Number Checker (C# Console App)

A simple **C# console program** that allows users to input numbers and checks whether the list contains **any duplicate values**.  
It provides input validation (only integers are allowed) and gives clear feedback if the input is invalid.

---

## 📋 Features

✅ Accepts numbers one by one from the user  
✅ Detects duplicate numbers efficiently  
✅ Handles invalid input gracefully  
✅ Shows meaningful output messages  

---

## 📘 Full Source Code

```csharp
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

````

---

## 🧠 How It Works

The program follows these main steps:

1. **User Input**
   The program repeatedly asks the user to enter numbers.

   * If the user types a number → it gets added to a list.
   * If the user types anything invalid → it shows an error in red and asks again.
   * Typing `done` ends the input process.

2. **Duplicate Check**
   The method `ContainsDuplicate()` checks whether any number appears more than once.

3. **Output**
   Finally, it prints either:

   ```
   Contains duplicate? True
   ```

   or

   ```
   Contains duplicate? False
   ```

---

## 💻 Example Run

```
Enter numbers one by one (type 'done' to finish'):
1
2
3
1
done
Contains duplicate? True
```

If you enter something invalid:

```
Enter numbers one by one (type 'done' to finish'):
5
ten
Invalid input! Please enter a valid integer.
6
done
Contains duplicate? False
```

---

## 🧩 Code Explanation

### 1. `using System; using System.Collections.Generic; using System.Linq;`

These lines import essential C# libraries:

* `System` — for console operations
* `Collections.Generic` — for using lists
* `Linq` — not strictly necessary here, but useful for array/list manipulation

---

### 2. `static bool ContainsDuplicate(int[] nums)`

This method:

1. Sorts the numbers using `Array.Sort(nums)`.
2. Loops through the array, comparing each element with the next one.
3. If any two adjacent elements are equal → returns `true`.
4. If no duplicates are found → returns `false`.

This approach works because in a **sorted array**, all duplicates will be **next to each other**.

✅ **Justification:**
Sorting the array first reduces the problem to a single pass comparison.
This is an efficient and clean solution for checking duplicates.

---

### 3. `static void Main()`

This is the **entry point** of the program.

* It creates a list to store numbers.
* Continuously reads input using `Console.ReadLine()`.
* Converts valid input into integers using `int.TryParse()`.
* Handles invalid inputs gracefully using colored messages.
* When the user types `done`, the program stops taking input and calls `ContainsDuplicate()` to check the result.

---

## ⚙️ How to Run

1. Open **Visual Studio** or **Visual Studio Code**.
2. Create a new **Console App (.NET)** project.
3. Replace the default `Program.cs` content with the provided code.
4. Run the program (press **F5** or use **dotnet run** in terminal).

---

## 🧾 Example Output Screens

**Case 1 — With duplicates:**

```
Input:  [1, 2, 3, 1]
Output: Contains duplicate? True
```

**Case 2 — Without duplicates:**

```
Input:  [1, 2, 3, 4]
Output: Contains duplicate? False
```

**Case 3 — Invalid input:**

```
Input:  3, 7, apple
Output: Invalid input! Please enter a valid integer.
```

---


## 📚 Justification of the Solution

This approach is justified because:

* Sorting brings duplicates together, making detection straightforward.
* No extra data structures (like sets or dictionaries) are needed, saving memory.
* The code is beginner-friendly, readable, and logically clear.
* It gracefully handles all invalid inputs — crucial for real-world robustness.




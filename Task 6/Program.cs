using System;

class Program
{
    static void Main(string[] args)
    {
        // Enter marks
        Console.Write("Enter marks: ");
        string marksInput = Console.ReadLine();

        // Enter total marks
        Console.Write("Enter total: ");
        string totalInput = Console.ReadLine();

        /* 
         * TryParse converts the user input (string) into an integer.
         * If conversion succeeds → it returns true and stores the value in 'marks' or 'total'.
         * If it fails (user enters letters or symbols) → it returns false.
         */
        bool isMarksValid = int.TryParse(marksInput, out int marks);
        bool isTotalValid = int.TryParse(totalInput, out int total);

        // If user entered invalid data, stop the program.
        if (!isMarksValid || !isTotalValid)
        {
            Console.WriteLine("Invalid input! Please enter integers only.");
            return;
        }

        // At this stage:
        // - marks has a valid integer value
        // - total has a valid integer value
        // But BOTH are integers (int type)

        /* 
         * WRONG CALCULATION 
         * marks / total performs INTEGER DIVISION.
         * This drops the decimal part.
         * 
         * Examples:
         * 45 / 100 = 0      (not 0.45)
         * 7 / 8 = 0         (not 0.875)
         * 
         * Because of integer division, the value becomes 0 BEFORE converting to double.
         */
        double wrongPercentage = marks / total * 100;
        // Check the value of 'wrongPercentage' here.
        // You will see incorrect result (mostly 0).
        // The error happened due to integer division.
        Console.WriteLine($"Incorrect Percentage (due to integer division): {wrongPercentage}");

        /* 
         * CORRECT CALCULATION:
         * Convert one value to double to force floating-point division.
         * This gives the correct percentage.
         */
        double correctPercentage = (double)marks / total * 100;
        Console.WriteLine($"Correct Percentage: {correctPercentage}");
    }
}

// ------------------------------------------------------------------------------------------------
// Training ~ A training program for new joinees at Metamation, Batch- July 2025.
// Copyright (c) Metamation India.
// ------------------------------------------------------------------
// Program.cs
// Program on T11.1 branch.
// ------------------------------------------------------------------------------------------------
using static System.Console;

namespace Training25;

internal class Program {
   static void Main () {
      int num;
      // First 25 Armstrong numbers are handled as it takes longer time to compute beyond the 25 numbers
      Write ("Enter a number(n) between 1 and 25 to find the nth Armstrong number: ");
      while (!int.TryParse (ReadLine (), out num) || num is < 1 or > 25) Write ("Enter a valid input: ");
      (int counter, int firstNum) = (0, 0);
      while (true) {
         if (IsArmstrong (firstNum++) && ++counter == num) {
            string suffix = (num % 10) switch {
               1 when num is not 11 => "st",
               2 when num is not 12 => "nd",
               3 when num is not 13 => "rd",
               _ => "th"
            };
            WriteLine ($"The {num}{suffix} Armstrong number is {firstNum - 1}");
            break;
         }
      }
   }

   // Checks if a number is an Armstrong number
   static bool IsArmstrong (int num) {
      if (num < 10) return true;
      int digits = (int)Math.Log10 (num) + 1;
      return num == Total (num, digits);

      // Calculates the sum of the digits raised to the power of number of digits
      static int Total (int num, int digits)
         => (num is not 0) ? (int)Math.Pow (num % 10, digits) + Total (num / 10, digits) : 0;
   }
}

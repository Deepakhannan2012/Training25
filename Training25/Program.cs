// ------------------------------------------------------------------------------------------------
// Training ~ A training program for new joinees at Metamation, Batch- July 2025.
// Copyright (c) Metamation India.
// ------------------------------------------------------------------
// Program.cs
// Program on T11 branch.
// ------------------------------------------------------------------------------------------------
using static System.Console;

namespace Training25;

internal class Program {
   static void Main () {
      int num;
      Write ("Enter a number to check if it is an Armstrong number: ");
      while (!int.TryParse (ReadLine (), out num) || num < 1) Write ("Enter a valid input: ");
      WriteLine ($"{num} {(IsArmstrong (num) ? "is" : "is not")} an Armstrong number");
   }

   // Checks if the input is an Armstrong number
   static bool IsArmstrong (int num) {
      int digits = (int)Math.Log10 (num) + 1;
      return num == Total (num, digits);

      // Calculate the sum of the digits raised to the power of number of digits
      static int Total (int num, int digits)
         => (num is not 0) ? (int)Math.Pow (num % 10, digits) + Total (num / 10, digits) : 0;
   }
}

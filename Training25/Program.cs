// ------------------------------------------------------------------------------------------------
// Training ~ A training program for new joinees at Metamation, Batch- July 2025.
// Copyright (c) Metamation India.
// ------------------------------------------------------------------
// Program.cs
// Program on T06 branch.
// ------------------------------------------------------------------------------------------------
using static System.Console;

namespace Training25;
internal class Program {
   static void Main (string[] args) {
      int num;
      Write ("Enter a number to find its Digital Root: ");
      while (!int.TryParse (ReadLine (), out num)) Write ("Enter a valid input: ");
      Write ($"The digital root of {num} is {DigiRoot (Math.Abs (num))}.");
   }

   // Returns the digital root of the input
   static int DigiRoot (int num) {
      int sum = (num > 9) ? num % 10 + DigiRoot (num / 10) : num;
      return sum > 9 ? DigiRoot (sum) : sum;
   }
}
// ------------------------------------------------------------------------------------------------
// Training ~ A training program for new joinees at Metamation, Batch- July 2025.
// Copyright (c) Metamation India.
// ------------------------------------------------------------------
// Program.cs
// Program on Test1 branch.
// ------------------------------------------------------------------------------------------------
using static System.Console;

namespace Training25;

internal class Program {
   static void Main () {
      Write ("Enter the number the separate the even and odd digits: ");
      while (!int.TryParse (ReadLine (), out num) || num < 1) Write ("Enter a valid input: ");
      WriteLine ($"The sorted number is: {DigitSorter ()}");
   }

   // Separates the even and odd digits from a number and sorts them individually
   static string DigitSorter () {
      int[] numArray = new int[(int)Math.Log10 (num) + 1];
      (int startIndex, int endIndex) = (0, 0);
      while (num > 0) {
         int digit = num % 10;
         numArray[(digit % 2 is 0) ? startIndex++ : ^++endIndex] = digit;
         num /= 10;
      }
      Array.Sort (numArray, 0, startIndex);
      Array.Sort (numArray, numArray.Length - endIndex, endIndex);
      return string.Join ("", numArray);
   }

   static int num;
}

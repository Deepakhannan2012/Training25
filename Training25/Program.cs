// ------------------------------------------------------------------------------------------------
// Training ~ A training program for new joinees at Metamation, Batch- July 2025.
// Copyright (c) Metamation India.
// ------------------------------------------------------------------
// Program.cs
// Program on T14 branch.
// ------------------------------------------------------------------------------------------------
using static System.Console;

namespace Training25;

internal class Program {
   static void Main (string[] args) {
      Write ("Enter a positive number to find its smallest transform: ");
      while (!int.TryParse (ReadLine (), out sInput) || sInput < 1) Write ("Invalid input ! Enter a valid number: ");
      WriteLine ($"The smallest number of changes required is {SmallTransform ()}.");
   }

   // Returns the smallest transform
   static int SmallTransform () {
      int[] numArray = new int[sInput.ToString ().Length];
      int index = 0;
      while (sInput is not 0) {
         numArray[index++] = sInput % 10;
         sInput /= 10;
      }
      int minValue = int.MaxValue;
      foreach (var item in numArray) {
         int temp = 0;
         foreach (var item1 in numArray)
            temp += Math.Abs (item1 - item);
         if (temp < minValue) minValue = temp;
      }
      return minValue;
   }

   static int sInput;
}

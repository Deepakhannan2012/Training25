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
   static void Main () {
      int num;
      Write ("Enter a positive number to find its smallest transform: ");
      while (!int.TryParse (ReadLine (), out num) || num < 1) Write ("Invalid input ! Enter a valid number: ");
      (int minChanges, string finalNum) = SmallestTransform (num);
      WriteLine ($"Transformed number: {finalNum}\nMinimum no. of changes: {minChanges}");
   }

   // Returns a tuple with the smallest number of changes required to transform digits and the number it transforms to
   static (int, string) SmallestTransform (int num) {
      int length = (int)Math.Log10 (num) + 1;
      int[] numArray = new int[length];
      int index = 0;
      while (num is not 0) {
         numArray[index++] = num % 10;
         num /= 10;
      }
      (int minChanges, int finalDigit) = (int.MaxValue, 0);
      foreach (var item in numArray) {
         int temp = 0;
         foreach (var item1 in numArray) temp += Math.Abs (item1 - item);
         if (temp < minChanges) (minChanges, finalDigit) = (temp, item);
      }
      return (minChanges, new string ((char)(finalDigit + '0'), length));
   }
}

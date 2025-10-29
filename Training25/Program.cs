// ------------------------------------------------------------------------------------------------
// Training ~ A training program for new joinees at Metamation, Batch- July 2025.
// Copyright (c) Metamation India.
// ------------------------------------------------------------------
// Program.cs
// Program on Test2 branch.
// ------------------------------------------------------------------------------------------------
using System.Text;
using static System.Console;

namespace Training25;

internal class Program {
   static void Main () {
      Write ("Enter the number to find its corresponding column (1 - 16384): ");
      while (!int.TryParse (ReadLine (), out num) || num is < 1 or > 16384) Write ("Enter a valid input: ");
      WriteLine ($"The corresponding Excel column for {num} is {NumtoColumn ()}");
   }

   // Returns the corresponding Excel column for the given number
   static StringBuilder NumtoColumn () {
      char[] columns = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray ();
      StringBuilder sb = new ();
      while (num > 0) {
         sb.Insert (0, columns[(num - 1) % 26]);
         num = (num - 1) / 26;
      }
      return sb;
   }

   static int num;
}

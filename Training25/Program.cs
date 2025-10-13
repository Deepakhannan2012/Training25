// ------------------------------------------------------------------------------------------------
// Training ~ A training program for new joinees at Metamation, Batch- July 2025.
// Copyright (c) Metamation India.
// ------------------------------------------------------------------
// Program.cs
// Program on T07 branch.
// ------------------------------------------------------------------------------------------------
using static System.Console;

namespace Training25;
internal class Program {
   static void Main (string[] args) {
      int rowNum;
      Write ("Enter the number of rows for the Pascal triangle: ");
      while ((!int.TryParse (ReadLine (), out rowNum)) || rowNum < 1) Write ("Enter a valid input: ");
      for (int i = 0; i < rowNum; i++) {
         Write (new string (' ', rowNum - i));
         for (int j = 0; j <= i; j++) Write ($"{Factorial (i) / (Factorial (j) * Factorial (i - j))} "); WriteLine ("");
      }

      // Returns the factorial of the input parameter
      static int Factorial (int num) => num is not 0 ? num * Factorial (num - 1) : 1;
   }
}
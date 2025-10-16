// ------------------------------------------------------------------------------------------------
// Training ~ A training program for new joinees at Metamation, Batch- July 2025.
// Copyright (c) Metamation India.
// ------------------------------------------------------------------
// Program.cs
// Program on T07 branch.
// ------------------------------------------------------------------------------------------------
using System.Text;
using static System.Console;

namespace Training25;
internal class Program {
   static void Main (string[] args) {
      // The input is taken till 19, as Pascal Triangles with more than 19 rows, wraps in the console window
      Write ("Enter the number of rows for the Pascal triangle (1 - 19): ");
      while ((!int.TryParse (ReadLine (), out sRowNum)) || sRowNum is < 1 or > 19) Write ("Enter a valid input: ");
      for (int i = 0; i < sRowNum; i++) {
         int current = 1;
         StringBuilder sb = new ();
         for (int j = 0; j <= i; j++) {
            sb.Append ($"{PadCenter (current.ToString (), MaxNumLen ())} ");
            current = current * (i - j) / (j + 1);
         }
         WriteLine (PadCenter (sb.ToString (), WindowWidth));
      }
   }

   // Aligns the text to center it within the specified width
   static string PadCenter (string text, int width) => text.PadLeft ((text.Length + width) / 2);

   // Calculates the length of the largest number in a Pascal's triangle
   static int MaxNumLen () {
      int current = 1;
      for (int i = 1; i <= sRowNum / 2; i++) current = current * (sRowNum - i + 1) / i;
      return current.ToString ().Length + 2;
   }

   static int sRowNum;
}

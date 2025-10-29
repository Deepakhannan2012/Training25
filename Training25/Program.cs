// ------------------------------------------------------------------------------------------------
// Training ~ A training program for new joinees at Metamation, Batch- July 2025.
// Copyright (c) Metamation India.
// ------------------------------------------------------------------
// Program.cs
// Program on Test3 branch.
// ------------------------------------------------------------------------------------------------
using static System.Console;

namespace Training25;

internal class Program {
   static void Main () {
      WriteLine ("Enter the row values separated by 1 whitespace.");
      GetInputMatrix (out int[][] matrix);
      (string yesNo, string result) = CheckMagic (matrix) ? ("Yes", "is") : ("No", "is not");
      WriteLine ($"{yesNo}, the given matrix {result} a magic square");
   }

   // Gets the input matrix from the user
   static void GetInputMatrix (out int[][] matrix) {
      matrix = new int[3][];
      for (int i = 0; i < 3; i++) {
         Write ($"Enter the numbers of row - {i + 1}: ");
         string input = "";
         while (true) {
            input = ReadLine ()?.Trim () ?? "";
            if (input.Length is 5 && !input.Any (char.IsLetter)) break;
            Write ("Please enter valid numbers in the valid format! ");
         }
         matrix[i] = Array.ConvertAll (input!.Split (' '), int.Parse);
      }
   }

   // Checks if the given matrix is a magic square
   static bool CheckMagic (int[][] matrix) {
      int total = matrix[0][0] + matrix[0][1] + matrix[0][2];
      // Row check
      for (int i = 1; i < 3; i++)
         if (matrix[i][0] + matrix[i][1] + matrix[i][2] != total) return false;
      // Column check
      for (int i = 0; i < 3; i++)
         if (matrix[0][i] + matrix[1][i] + matrix[2][i] != total) return false;
      // Diagonal check
      if (matrix[0][0] + matrix[1][1] + matrix[2][2] != total) return false;
      if (matrix[0][2] + matrix[1][1] + matrix[2][0] != total) return false;
      return true;
   }
}

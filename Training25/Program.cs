// ------------------------------------------------------------------------------------------------
// Training ~ A training program for new joinees at Metamation, Batch- July 2025.
// Copyright (c) Metamation India.
// ------------------------------------------------------------------
// Program.cs
// Program on T10 branch.
// ------------------------------------------------------------------------------------------------
using System.Text;
using static System.Console;

namespace Training25;

internal class Program {
   static void Main (string[] args) {
      while (true) {
         Write ("Enter the string to be reversed: ");
         sInput = ReadLine ()?.Trim () ?? "";
         if (!string.IsNullOrWhiteSpace (sInput)) break;
         WriteLine ("Input cannot be empty !");
      }
      WriteLine ($"Reversed string: {Reverse ()}");
   }

   static string Reverse () {
      string revString = new ([.. sInput.Replace (" ", "")]);
      int revIndex = 1, inputLen = sInput.Length;
      char[] output = new char[inputLen];
      for (int i = 0; i < inputLen; i++) {
         char currentChar = sInput[i];
         output[i] = currentChar switch {
            ' ' => ' ',
            _ when char.IsUpper (currentChar) => char.ToUpper (revString[^revIndex++]),
            _ => char.ToLower (revString[^revIndex++])
         };
      }
      return new string (output);
   }

   static string sInput = "";
}

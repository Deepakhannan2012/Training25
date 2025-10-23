// ------------------------------------------------------------------------------------------------
// Training ~ A training program for new joinees at Metamation, Batch- July 2025.
// Copyright (c) Metamation India.
// ------------------------------------------------------------------
// Program.cs
// Program on T09 branch.
// ------------------------------------------------------------------------------------------------
using System.Text;
using static System.Console;

namespace Training25;
internal class Program {
   static void Main (string[] args) {
      Write ("Enter a lowercase string to reduce: ");
      while (true) {
         sInput = ReadLine ()?.ToLower ().Trim () ?? "";
         if (sInput.All (char.IsLetter)) break;
         Write ("Invalid input. Please enter only letters: ");
      }
      string output = ReducedString ();
      WriteLine ($"The reduced form is {(output.Length is 0 ? "an empty string" : output)}.");
   }

   // Returns the reduced form of the input string
   static string ReducedString () {
      StringBuilder sb = new ();
      for (int i = 0; i < sInput.Length;) {
         if (i < sInput.Length - 1 && sInput[i] == sInput[i + 1]) i += 2;
         else { sb.Append (sInput[i]); i++; }
      }
      return sb.ToString ();
   }

   static string sInput = "";
}
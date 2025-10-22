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
      Write ("Enter a string to reduce: ");
      sInput = ReadLine () ?? "";
      string output = ReducedString().Length is 0 ? "an empty string" : ReducedString ();
      WriteLine ($"The reduced form is {output}.");
   }

   // Returns the reduced form of the input string
   static string ReducedString () {
      StringBuilder sb = new ();
      char[] myArray = sInput.ToLower().ToCharArray ();
      for (int i = 0; i < myArray.Length;) {
         if (i < myArray.Length - 1 && myArray[i] == myArray[i + 1]) i += 2;
         else { sb.Append (myArray[i]); i++; }
      }
      return sb.ToString ();
   }

   static string sInput = "";
}
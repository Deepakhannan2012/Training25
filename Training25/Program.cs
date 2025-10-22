// ------------------------------------------------------------------------------------------------
// Training ~ A training program for new joinees at Metamation, Batch- July 2025.
// Copyright (c) Metamation India.
// ------------------------------------------------------------------
// Program.cs
// Program on T08 branch.
// ------------------------------------------------------------------------------------------------
using System.Text;
using static System.Console;

namespace Training25;
internal class Program {
   static void Main (string[] args) {
      string input;
      char[] splChar = ['!', '@', '#', '$', '%', '^', '&', '*', '(', ')', '+', '-'];
      while (true) {
         Write ("Enter a new password: ");
         input = ReadLine () ?? "";
         StringBuilder sb = new ();
         if (!(input.Length >= 6)) sb.AppendLine ("* Atleast 6 characters");
         if (!input.Any (char.IsDigit)) sb.AppendLine ("* A digit");
         if (!input.Any (char.IsLower)) sb.AppendLine ("* A lowercase English character");
         if (!input.Any (char.IsUpper)) sb.AppendLine ("* An uppercase English character");
         if (!input.Any (c => splChar.Contains (c))) sb.AppendLine ("* A special character");
         if (sb.Length is 0) {
            WriteLine ("Strong password !"); break;
         } else WriteLine ($"Weak password.\nIt must meet the following criteria:\n{sb} ");
      }
   }
}
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
      while (true) {
         Write ("Enter a new password: ");
         sInput = ReadLine () ?? "";
         string result = ErrorMsg ();
         if (result.Length is 0) { WriteLine ("Strong password !"); break; }
         WriteLine ($"Weak password.\nIt must meet the following criteria:\n{result}");
      }
   }

   // Returns error message for missing criteria
   static string ErrorMsg () {
      string splChar = "!@#$%^&*()+-";
      EChar flags = EChar.None;
      EChar eAll = EChar.Length | EChar.Digit | EChar.Lower | EChar.Upper | EChar.Spl;
      if (sInput.Length >= 6) flags |= EChar.Length;
      foreach (char c in sInput) {
         flags |= c switch {
            _ when char.IsDigit (c) => EChar.Digit,
            _ when char.IsLower (c) => EChar.Lower,
            _ when char.IsUpper (c) => EChar.Upper,
            _ when splChar.Contains (c) => EChar.Spl,
            _ => EChar.None
         };
         if (flags == eAll) return "";
      }
      StringBuilder sb = new ();
      (EChar, string)[] errorMsg = [
         (EChar.Length, "* Atleast 6 characters"), (EChar.Digit, "* A digit"), (EChar.Spl, "* A special character"),
         (EChar.Lower, "* A lowercase English character"), (EChar.Upper, "* An uppercase English character")
      ];
      foreach (var (criteria, error) in errorMsg)
         if ((flags & criteria) is 0) sb.AppendLine (error);
      return sb.ToString ();
   }

   enum EChar { None = 0, Length = 1, Digit = 2, Lower = 4, Upper = 8, Spl = 16 }

   static string sInput = "";
}
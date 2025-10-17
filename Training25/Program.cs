// ------------------------------------------------------------------------------------------------
// Training ~ A training program for new joinees at Metamation, Batch- July 2025.
// Copyright (c) Metamation India.
// ------------------------------------------------------------------
// Program.cs
// Program on T08 branch.
// ------------------------------------------------------------------------------------------------
using static System.Console;

namespace Training25;
internal class Program {
   static void Main (string[] args) {
      while (true) {
         Write ("Enter a new password: ");
         sInput = ReadLine () ?? "";
         if (Check ()) { WriteLine ("Strong Password !"); break; } else WriteLine ("Try again !\n");
      }
   }

   // Checks if the password is strong or not
   static bool Check () {
      char[] splChar = { '!', '@', '#', '$', '%', '^', '&', '*', '(', ')' };
      bool isDigit = sInput.Any (char.IsDigit), isUp = sInput.Any (char.IsUpper), isLow = sInput.Any (char.IsLower),
           isSpl = sInput.Any (c => splChar.Contains (c)), isLen = sInput.Length >= 6;
      var errorList = new List<(bool cond, string mess)> { ( isLen, "a minimum of 6 characters !" ),
                                                           ( isDigit, "a digit !" ),
                                                           ( isLow, "an lowercase English letter !" ),
                                                           ( isUp, "an uppercase English letter !" ),
                                                           ( isSpl, "a special character !" ) };
      foreach (var (cond, mess) in errorList) if (!cond) WriteLine ($"It must contain {mess}");
      return (isLen && isDigit && isLow && isUp && isSpl);
   }

   static string sInput = "";
}


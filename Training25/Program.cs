// ------------------------------------------------------------------------------------------------
// Training ~ A training program for new joinees at Metamation, Batch- July 2025.
// Copyright (c) Metamation India.
// ------------------------------------------------------------------
// Program.cs
// Program on T03 branch.
// ------------------------------------------------------------------------------------------------
using static System.Console;

namespace Training25;
internal class Program {
   static void Main (string[] args) {
      sNum1 = GetNum ("first"); sNum2 = GetNum ("second");
      (int lcm, int gcd) = (sNum1, sNum2) switch {
         (0, 0) => (0, 0),
         (_, 0) or (0, _) => (0, int.Max (sNum1, sNum2)),
         _ => LCMAndGCD ()
      };
      Write ($"LCM: {lcm}\nGCD: {gcd}");
   }

   // Returns the LCM and GCD of two numbers
   static (int lcm, int gcd) LCMAndGCD () {
      (int temp1, int temp2) = (sNum1, sNum2);
      while (temp2 is not 0) (temp1, temp2) = (temp2, temp1 % temp2);
      return (sNum1 * sNum2 / temp1, temp1);
   }

   // Gets a valid integer input from the user
   static int GetNum (string count) {
      int num;
      Write ($"Enter the {count} number: ");
      while (!int.TryParse (ReadLine (), out num)) Write ("Enter a valid input: ");
      return Math.Abs (num);
   }

   static int sNum1, sNum2;
}


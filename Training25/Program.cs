// ------------------------------------------------------------------------------------------------
// Training ~ A training program for new joinees at Metamation, Batch- July 2025.
// Copyright (c) Metamation India.
// ------------------------------------------------------------------
// Program.cs
// Program on T03 branch.
// ------------------------------------------------------------------------------------------------
using static System.Console;

namespace Training25 {
   internal class Program {
      static void Main (string[] args) {
         Write ("Enter the first number: ");
         while (!int.TryParse (ReadLine (), out sNum1)) WriteLine ("Enter a valid input !");
         Write ("Enter the second number: ");
         while (!int.TryParse (ReadLine (), out sNum2)) WriteLine ("Enter a valid input !");
         WriteLine ($"LCM: {Lcm ()}\nGCD: {Gcd ()}");
      }

      // Returns the LCM of two numbers
      static int Lcm () => (sNum1 * sNum2) / Gcd ();

      // Returns the GCD of two numbers
      static int Gcd () {
         int gcd, temp1 = int.Max (sNum1, sNum2), temp2 = int.Min (sNum1, sNum2);
         do {
            gcd = temp1 % temp2; temp1 = temp2; temp2 = gcd;
         } while (gcd is not 0);
         return temp1;
      }

      static int sNum1, sNum2;
   }
}

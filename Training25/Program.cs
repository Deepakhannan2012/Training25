// ------------------------------------------------------------------------------------------------
// Training ~ A training program for new joinees at Metamation, Batch- July 2025.
// Copyright (c) Metamation India.
// ------------------------------------------------------------------
// Program.cs
// Program on main branch.
// ------------------------------------------------------------------------------------------------
namespace Training25 {
   internal class Program {
      static void Main (string[] args) {
         do {
            Console.Write ("Enter the first number: ");
            sIsValid = int.TryParse (Console.ReadLine (), out sMyNum1);
         } while (!sIsValid);
         do {
            Console.Write ("Enter the second number: ");
            sIsValid = int.TryParse (Console.ReadLine (), out sMyNum2);
         } while (!sIsValid);
         Console.WriteLine ("LCM: " + Lcm ());
         if (sMyNum1 == 0 && sMyNum2 == 0) Console.WriteLine ("GCD: Does not exist !");
         else Console.WriteLine ("GCD: " + Gcd ());
      }

      static int Lcm () {
         if (sMyNum1 == 0 || sMyNum2 == 0) return 0;
         return (sMyNum1 * sMyNum2) / Gcd ();
      }

      static int Gcd () {
         if (sMyNum1 == 0 || sMyNum2 == 0) return int.Max (sMyNum1, sMyNum2);
         int gcd;
         int temp1 = int.Max (sMyNum1, sMyNum2), temp2 = int.Min (sMyNum1, sMyNum2);
         do {
            gcd = temp1 % temp2;
            temp1 = temp2;
            temp2 = gcd;
         } while (gcd != 0);
         return temp1;
      }

      static int sMyNum1, sMyNum2;
      static bool sIsValid;
   }
}

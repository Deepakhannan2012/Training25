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
         Console.Write ("Enter the first number: ");
         do {
            isValid = int.TryParse (Console.ReadLine (), out myNum1);
            if (!isValid) Console.Write ("Please enter a valid number: ");
         } while (!isValid);
         Console.Write ("Enter the second number: ");
         do {
            isValid = int.TryParse (Console.ReadLine (), out myNum2);
            if (!isValid) Console.Write ("Please enter a valid number: ");
         } while (!isValid);
         Console.WriteLine ("LCM: " + Lcm ());
         if (myNum1 == 0 && myNum2 == 0) Console.WriteLine ("GCD: Does not exist !");
         else Console.WriteLine ("GCD: " + Gcd ());
      }

      static int Lcm () {
         if (myNum1 == 0 || myNum2 == 0) return 0;
         return (myNum1 * myNum2) / Gcd ();
      }

      static int Gcd () {
         if (myNum1 == 0 || myNum2 == 0) return int.Max (myNum1, myNum2);
         int gcd;
         int temp1 = int.Max (myNum1, myNum2), temp2 = int.Min (myNum1, myNum2);
         do {
            gcd = temp1 % temp2;
            temp1 = temp2;
            temp2 = gcd;
         } while (gcd != 0);
         return temp1;
      }

      static int myNum1, myNum2;
      static bool isValid;
   }
}

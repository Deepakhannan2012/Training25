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
         int result = 0;
         int myNum1 = int.Parse (Console.ReadLine ());
         int myNum2 = int.Parse (Console.ReadLine ());


         int LcmNum (int myNum1, int myNum2) {
            for (int i = 1; i <= myNum2; i++) {
               int temp1 = myNum1 * i;
               for (int j = 1; j <= myNum1; j++) {
                  int temp2 = myNum2 * j;
                  if (temp1 == temp2) {
                     return temp1;
                  }
               }
            }
            return myNum1 * myNum2;
         }
         int Gcd(int myNum1, int myNum2) {
            return (myNum1 * myNum2) / LcmNum (myNum1, myNum2);
         }
         Console.WriteLine (LcmNum(myNum1,myNum2));
         Console.WriteLine (Gcd(myNum1,myNum2));

      }
   }
}

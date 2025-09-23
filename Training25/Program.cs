// ------------------------------------------------------------------------------------------------
// Training ~ A training program for new joinees at Metamation, Batch- July 2025.
// Copyright (c) Metamation India.
// ------------------------------------------------------------------
// Program.cs
// Program on main branch.
// ------------------------------------------------------------------------------------------------
using System;
using System.Globalization;

namespace Training25 {
   internal class Program {
      static void Main (string[] args) {
         Console.WriteLine ("Enter the number that is to be converted:");
         do {
            sisValid = int.TryParse (Console.ReadLine (), out smyNum);
            if (!sisValid) Console.WriteLine ("Please enter a valid number !");
         } while (!sisValid);
         Console.WriteLine ("Please enter the conversion type:\nw - Words\tr - Roman Numerals (1 - 3999)");
         do {
            sconversionType = Console.ReadLine ().ToLower ().Trim ();
            if (sconversionType == "w") {
               Console.WriteLine (NumtoWord (smyNum));
               sisValid = true;
            } else if ((sconversionType == "r") && smyNum < 4000) {
               Console.WriteLine (NumToRoman (smyNum));
               sisValid = true;
            } else {
               Console.WriteLine ("Please enter a valid input ! !");
               sisValid = false;
            }
         } while (!sisValid);
      }

      static string TensToWord (int num) {
         if (num / 10 == 0) return numOnes[(num % 10)];
         else if (num / 10 == 1) return numTeens[num % 10];
         else if ((num % 10) == 0) return numTens[num / 10];
         else return numTens[num / 10] + " " + numOnes[num % 10];
      }

      static string NumtoWord (int num) {
         if (num == 0) sresult = "zero";
         if (num / 10000000 > 0) {
            sresult += NumtoWord (num / 10000000) + " crore ";
            num %= 10000000;
         }
         if (num / 100000 > 0) {
            sresult += TensToWord (num / 100000) + " lakhs ";
            num %= 100000;
         }
         if (num / 1000 > 0) {
            sresult += TensToWord (num / 1000) + " thousand ";
            num %= 1000;
         }
         if (num / 100 > 0) {
            sresult += numOnes[(num / 100)] + " hundred ";
            num %= 100;
         }
         if (num < 100) {
            sresult += TensToWord (num);
         }
         return sresult;
      }

      static string NumToRoman (int myNum) {
         if (myNum >= 1000) {
            for (int i = 0; i < (myNum / 1000); i++) sresult += numeral[Array.IndexOf (num, 1000)];
            myNum %= 1000;
         }
         if (myNum >= 100) {
            sresult = OnesToRoman (myNum / 100, 100);
            myNum %= 100;
         }
         if (myNum >= 10) {
            sresult = OnesToRoman (myNum / 10, 10);
            myNum %= 10;
         }
         if (myNum > 0) sresult = OnesToRoman (myNum, 1);
         else sresult = "Does not exist !";
         return sresult;
      }

      static string OnesToRoman (int num1, int numeralValue) {
         if (num1 < 4) for (int i = 0; i < num1; i++) sresult += numeral[Array.IndexOf (num, numeralValue)];
         else if (num1 == 4) sresult += numeral[Array.IndexOf (num, numeralValue)] + numeral[Array.IndexOf (num, numeralValue) + 1];
         else if (num1 == 5) sresult += numeral[Array.IndexOf (num, numeralValue) + 1];
         else if (num1 < 9) {
            sresult += numeral[Array.IndexOf (num, numeralValue) + 1];
            for (int i = 0; i < (num1 - 5); i++) {
               sresult += numeral[Array.IndexOf (num, numeralValue)];
            }
         } else sresult += numeral[Array.IndexOf (num, numeralValue)] + numeral[Array.IndexOf (num, numeralValue) + 2];
         return sresult;
      }

      static int smyNum;
      static bool sisValid;
      static string sresult = "", sconversionType;
      static string[] numOnes = ["", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"];
      static string[] numTens = ["", "", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety"];
      static string[] numTeens = ["ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen"];
      static int[] num = [1, 5, 10, 50, 100, 500, 1000];
      static string[] numeral = ["I", "V", "X", "L", "C", "D", "M"];
   }
}

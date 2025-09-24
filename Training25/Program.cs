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
         do {
            Console.WriteLine ("Enter the number that is to be converted: ");
            sIsValid = int.TryParse (Console.ReadLine (), out sMyNum);
         } while (!sIsValid);
         Console.WriteLine ("Please enter the conversion type:\nw - Words\tr - Roman Numerals (1 - 3999)");
         do {
            sConversionType = Console.ReadLine ().ToLower ().Trim ();
            if (sConversionType == "w") {
               Console.WriteLine (NumtoWord ());
               sIsValid = true;
            } else if ((sConversionType is "r") && sMyNum < 4000) {
               Console.WriteLine (NumToRoman ());
               sIsValid = true;
            } else {
               Console.WriteLine ("Please enter a valid input ! !");
               sIsValid = false;
            }
         } while (!sIsValid);
      }

      static string TensToWord (int sMyNum) {
         if (sMyNum / 10 == 0) return sNumOnes[(sMyNum % 10)];
         else if (sMyNum / 10 == 1) return sNumTeens[sMyNum % 10];
         else if ((sMyNum % 10) == 0) return sNumTens[sMyNum / 10];
         else return sNumTens[sMyNum / 10] + " " + sNumOnes[sMyNum % 10];
      }

      static string NumtoWord () {
         if (sMyNum == 0) sResult = "zero";
         if (sMyNum / 10000000 > 0) {
            sMyNum /= 10000000;
            sResult += NumtoWord () + " crore ";
            sMyNum %= 10000000;
         }
         if (sMyNum / 100000 > 0) {
            sResult += TensToWord (sMyNum / 100000) + " lakhs ";
            sMyNum %= 100000;
         }
         if (sMyNum / 1000 > 0) {
            sResult += TensToWord (sMyNum / 1000) + " thousand ";
            sMyNum %= 1000;
         }
         if (sMyNum / 100 > 0) {
            sResult += sNumOnes[(sMyNum / 100)] + " hundred ";
            sMyNum %= 100;
         }
         if (sMyNum < 100) {
            sResult += TensToWord (sMyNum);
         }
         return sResult;
      }

      static string NumToRoman () {
         if (sMyNum >= 1000) {
            for (int i = 0; i < (sMyNum / 1000); i++) sResult += sNumeral[Array.IndexOf (sNum, 1000)];
            sMyNum %= 1000;
         }
         if (sMyNum >= 100) {
            sResult = OnesToRoman (sMyNum / 100, 100);
            sMyNum %= 100;
         }
         if (sMyNum >= 10) {
            sResult = OnesToRoman (sMyNum / 10, 10);
            sMyNum %= 10;
         }
         if (sMyNum > 0) sResult = OnesToRoman (sMyNum, 1);
         else sResult = "Does not exist !";
         return sResult;
      }

      static string OnesToRoman (int num1, int numeralValue) {
         if (num1 < 4) for (int i = 0; i < num1; i++) sResult += sNumeral[Array.IndexOf (sNum, numeralValue)];
         else if (num1 == 4) sResult += sNumeral[Array.IndexOf (sNum, numeralValue)] + sNumeral[Array.IndexOf (sNum, numeralValue) + 1];
         else if (num1 == 5) sResult += sNumeral[Array.IndexOf (sNum, numeralValue) + 1];
         else if (num1 < 9) {
            sResult += sNumeral[Array.IndexOf (sNum, numeralValue) + 1];
            for (int i = 0; i < (num1 - 5); i++) {
               sResult += sNumeral[Array.IndexOf (sNum, numeralValue)];
            }
         } else sResult += sNumeral[Array.IndexOf (sNum, numeralValue)] + sNumeral[Array.IndexOf (sNum, numeralValue) + 2];
         return sResult;
      }

      static int sMyNum;
      static bool sIsValid;
      static string sResult = "", sConversionType;
      static string[] sNumOnes = ["", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"];
      static string[] sNumTens = ["", "", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety"];
      static string[] sNumTeens = ["ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen"];
      static int[] sNum = [1, 5, 10, 50, 100, 500, 1000];
      static string[] sNumeral = ["I", "V", "X", "L", "C", "D", "M"];
   }
}

// ------------------------------------------------------------------------------------------------
// Training ~ A training program for new joinees at Metamation, Batch- July 2025.
// Copyright (c) Metamation India.
// ------------------------------------------------------------------
// Program.cs
// Program on main branch.
// ------------------------------------------------------------------------------------------------
using System.Globalization;

namespace Training25 {
   internal class Program {
      static void Main (string[] args) {
         Console.WriteLine ("Hello, World!");
         int myNum;
         bool isValid;
         string result = "";
         string[] numOnes = { "", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
         string[] numTens = { "", "", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };
         string[] numTeens = { "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
         int[] num = { 1, 5, 10, 50, 100, 500, 1000 };
         string[] numeral = { "I", "V", "X", "L", "C", "D", "M" };
         string conversionType;
         Console.WriteLine ("Enter a number:");
         do {
            isValid = int.TryParse (Console.ReadLine (), out myNum);
            if (!isValid) Console.WriteLine ("Please enter a valid number !");
         }
         while (!isValid);

         Console.WriteLine ("Please enter the conversion type:\nw - Words\tr - Roman Numerals (1 - 3999)");

         do {
            conversionType = Console.ReadLine ();
            if (conversionType.ToLower ().Trim () == "w") {
               Console.WriteLine (NumtoWord (myNum));
               isValid = true;
            } else if ((conversionType.ToLower ().Trim () == "r") && myNum < 4000) {
               Console.WriteLine (NumToRoman (myNum));
               isValid = true;
            } else {
               isValid = false;
               Console.WriteLine ("Please enter a valid input ! !");
            }
         }
         while (!isValid);

         string TensToWord (int num) {

            if (num / 10 == 0) {
               return numOnes[(num % 10)];
            } else if (num / 10 == 1) {
               return numTeens[num % 10];
            } else if ((num % 10) == 0) {
               return numTens[num / 10];
            } else
               return numTens[num / 10] + " " + numOnes[num % 10];
         }
         string NumtoWord (int num) {
            if (num == 0) result = "zero";
            if (num / 10000000 > 0) {
               result = result + NumtoWord (num / 10000000) + " crore ";
               num = num % 10000000;
            }
            if (num / 100000 > 0) {
               result = result + TensToWord (num / 100000) + " lakhs ";
               num = num % 100000;
            }
            if (num / 1000 > 0) {
               result = result + TensToWord (num / 1000) + " thousand ";
               num = num % 1000;
            }
            if (num / 100 > 0) {
               result = result + numOnes[(num / 100)] + " hundred ";
               num = num % 100;
            }
            if (num < 100) {
               result = result + TensToWord (num);
            }
            return result;
         }
         string NumToRoman (int myNum) {
            if (myNum >= 1000) {

               for (int i = 0; i < (myNum / 1000); i++) {
                  result = result + numeral[Array.IndexOf (num, 1000)];
               }
               myNum = myNum % 1000;
            }
            if (myNum >= 100) {

               result = OnesToRoman (myNum / 100, 100);
               myNum = myNum % 100;
            }
            if (myNum >= 10) {

               result = OnesToRoman (myNum / 10, 10);
               myNum = myNum % 10;
            }
            if (myNum > 0) {
               result = OnesToRoman (myNum, 1);
            }
            return result;
         }
         string OnesToRoman (int num1, int numeralValue) {
            if (num1 < 4) {
               for (int i = 0; i < num1; i++) {
                  result = result + numeral[Array.IndexOf (num, numeralValue)];
               }
            } else if (num1 == 4) {
               result = result + numeral[Array.IndexOf (num, numeralValue)] + numeral[Array.IndexOf (num, numeralValue) + 1];
            } else if (num1 == 5) {
               result = result + numeral[Array.IndexOf (num, numeralValue) + 1];
            } else if (num1 < 9) {
               result = result + numeral[Array.IndexOf (num, numeralValue) + 1];
               for (int i = 0; i < (num1 - 5); i++) {
                  result = result + numeral[Array.IndexOf (num, numeralValue)];
               }
            } else {
               result = result + numeral[Array.IndexOf (num, numeralValue)] + numeral[Array.IndexOf (num, numeralValue) + 2];
            }
            return result;
         }
      }
   }
}

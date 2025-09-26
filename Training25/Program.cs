// ------------------------------------------------------------------------------------------------
// Training ~ A training program for new joinees at Metamation, Batch- July 2025.
// Copyright (c) Metamation India.
// ------------------------------------------------------------------
// Program.cs
// Program on main branch.
// ------------------------------------------------------------------------------------------------
using System.Text;

namespace Training25 {
   internal class Program {
      static void Main (string[] args) {
         Console.Write ("Enter the number that is to be converted: ");
         while (!int.TryParse (Console.ReadLine (), out sMyNum)) Console.WriteLine ("Please enter a valid input !");
         Console.WriteLine ("Please enter the conversion type:\nw - Words\tr - Roman Numerals (1 - 3999)");
         string conversionType;
         do {
            conversionType = Console.ReadLine ().ToLower ().Trim ();
            string output = conversionType switch {
               "w" => NumToWord (),
               "r" => NumToRoman (),
               _ => "Please enter a valid input !"
            };
            Console.WriteLine (output);
         } while (conversionType is not "w" and not "r");
      }

      // Number to word method
      static string NumToWord () {
         string[] ones = ["", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"];
         string[] tens = ["", "", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety"];
         string[] teens = ["ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen",
                              "eighteen", "nineteen"];
         Dictionary<int, string> numValue = new (){{ 10000000,"crore"},{100000,"lakh"},{1000, "thousand"},
                                                  {100, "hundred"},{1,""} };
         var sb = new StringBuilder ();
         if (sMyNum is 0) return "Zero";
         if (sMyNum is < 0) {
            sMyNum = -sMyNum;
            return $"Minus {NumToWord ()}";
         }
         foreach (KeyValuePair<int, string> pair in numValue)
            if (sMyNum / pair.Key > 0) {
               sb.Append ($"{TensToWord (sMyNum / pair.Key)} {pair.Value} ");
               sMyNum %= pair.Key;
            }
         return sb.ToString ();

         string TensToWord (int num) {
            int divNum = num / 10, modNum = num % 10;
            if (divNum is 0) return ones[modNum];
            else if (divNum is 1) return teens[modNum];
            else if (modNum is 0) return tens[divNum];
            else return $"{tens[divNum]} {ones[modNum]}";
         }
      }

      // Number to roman method
      static string NumToRoman () {
         Dictionary<int, string> numRoman = new () { { 1000, "M" },{ 900, "CM" },{ 500, "D" },{ 400, "CD" },
                                                     { 100, "C" },{ 90, "XC" },{ 50, "L" },{ 40, "IV" },{ 10, "X" },
                                                     { 9, "IX" },{ 5, "V" },{ 4, "IV" },{ 1, "I" } };
         var sb = new StringBuilder ();
         if (sMyNum is < 1 or > 3999) return "Does not exist !";
         foreach (KeyValuePair<int, string> item in numRoman) {
            while (sMyNum >= item.Key) {
               sb.Append (item.Value);
               sMyNum -= item.Key;
            }
         }
         return sb.ToString ();
      }

      static int sMyNum;
   }
}

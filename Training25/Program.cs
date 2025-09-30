// ------------------------------------------------------------------------------------------------
// Training ~ A training program for new joinees at Metamation, Batch- July 2025.
// Copyright (c) Metamation India.
// ------------------------------------------------------------------
// Program.cs
// Program on T02 branch.
// ------------------------------------------------------------------------------------------------
using System.Text;
using static System.Console;

namespace Training25 {
   internal class Program {
      static void Main (string[] args) {
         Write ("Enter the number that is to be converted: ");
         while (!int.TryParse (ReadLine (), out sNum)) WriteLine ("Please enter a valid input !");
         WriteLine ("Please enter the conversion type:\nw - Words\tr - Roman Numerals (1 - 3999)");
         string? conversionType;
         do {
            conversionType = ReadLine ()?.ToLower ().Trim ();
            string output = conversionType switch {
               "w" => NumToWord (),
               "r" => NumToRoman (),
               _ => "Please enter a valid input !"
            };
            WriteLine (output);
         } while (conversionType is not "w" and not "r");
      }

      // Converts the number to word form
      // Handles from -999999999 to 999999999
      static string NumToWord () {
         if (sNum is 0) return "Zero";
         if (sNum is < 0) { sNum = -sNum; return $"Minus {NumToWord ()}"; }
         Dictionary<int, string> numValue = new () { { 10000000, "crore" },{ 100000, "lakh" },{ 1000, "thousand" },
                                                     { 100, "hundred" },{ 1, "" } };
         var sb = new StringBuilder ();
         foreach (var (num, word) in numValue) {
            int divNum = sNum / num;
            if (divNum > 0) { sb.Append ($"{TensToWord (divNum)} {word} "); sNum %= num; }
         }
         return sb.ToString ();

         static string TensToWord (int num) {
            string[] ones = ["", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"];
            string[] tens = ["", "", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety"];
            string[] teens = ["ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen",
                           "eighteen", "nineteen"];
            int divNum = num / 10, modNum = num % 10;
            return divNum switch {
               0 => ones[modNum],
               1 => teens[modNum],
               _ when modNum is 0 => tens[divNum],
               _ => $"{tens[divNum]} {ones[modNum]}"
            };
         }
      }

      // Converts the number to roman numerals
      static string NumToRoman () {
         if (sNum is < 1 or > 3999) return "Does not exist !";
         Dictionary<int, string> numRoman = new () { { 1000, "M" },{ 900, "CM" },{ 500, "D" },{ 400, "CD" },
                                                     { 100, "C" },{ 90, "XC" },{ 50, "L" },{ 40, "IV" },{ 10, "X" },
                                                     { 9, "IX" },{ 5, "V" },{ 4, "IV" },{ 1, "I" } };
         var sb = new StringBuilder ();
         foreach (var (num, roman) in numRoman) while (sNum >= num) { sb.Append (roman); sNum -= num; }
         return sb.ToString ();
      }

      static int sNum;
   }
}

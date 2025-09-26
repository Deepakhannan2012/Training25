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
         while (!int.TryParse (Console.ReadLine (), out sMyNum)) Console.WriteLine ("Enter a valid input !");
         Console.WriteLine ("Enter the number system to convert:\nb - binary\th - hexa");
         string numSystem;
         do {
            numSystem = Console.ReadLine ().ToLower ().Trim ();
            string output = numSystem switch {
               "b" => $"The converted binary value of {sMyNum} is {Binary ()}",
               "h" => $"The converted hexadecimal value of {sMyNum} is {Hexa ()}",
               _ => "Please enter a valid input !"
            };
            Console.WriteLine (output);
         } while (numSystem is not "b" and not "h");
      }

      // Hexadecimal conversion method
      static string Hexa () {
         var sb = new StringBuilder ();
         do {
            if (sMyNum == 0) sb.Append ('0');
            else {
               int remain = sMyNum % 16;
               sMyNum /= 16;
               if (remain / 10 == 0) sb.Insert (0, remain);
               else {
                  char remainHexa = remain switch {
                     10 => 'A',
                     11 => 'B',
                     12 => 'C',
                     13 => 'D',
                     14 => 'E',
                     15 => 'F'
                  };
                  sb.Insert (0, remainHexa);
               }
            }
         } while (sMyNum != 0);
         return sb.ToString ();
      }

      // Binary conversion method
      static string Binary () {
         var sb = new StringBuilder ();
         if (sMyNum == 0) sb.Append ('0');
         else {
            do {
               int remain = sMyNum % 2;
               sMyNum /= 2;
               sb.Insert (0, remain);
            } while (sMyNum != 0);
         }
         return sb.ToString ();
      }

      static int sMyNum;
   }
}

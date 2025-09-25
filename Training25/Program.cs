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
         string result = "";
         do {
            if (sMyNum == 0) result = "0";
            else {
               int remain = sMyNum % 16;
               sMyNum /= 16;
               if (remain / 10 == 0) result = $"{remain}{result}";
               else {
                  string remainHexa = remain switch {
                     10 => "A",
                     11 => "B",
                     12 => "C",
                     13 => "D",
                     14 => "E",
                     15 => "F"
                  };
                  result = remainHexa + result;
               }
            }
         } while (sMyNum != 0);
         return result;
      }

      // Binary conversion method
      static string Binary () {
         string result = "";
         if (sMyNum == 0) result = "0";
         else {
            do {
               int remain = sMyNum % 2;
               sMyNum /= 2;
               result = $"{remain}{result}";
            } while (sMyNum != 0);
         }
         return result;
      }

      static int sMyNum;
   }
}

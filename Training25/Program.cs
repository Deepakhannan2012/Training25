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
            Console.Write ("Enter the number that is to be converted:");
            sIsValid = int.TryParse (Console.ReadLine (), out sMyNum);
         } while (!sIsValid);
         Console.WriteLine ("Enter the number system to convert:\nb - binary\th - hexa");
         do {
            sNumSystem = Console.ReadLine ().ToLower ().Trim ();
            if (sNumSystem == "b") Console.WriteLine ($"The converted binary value of {sMyNum} is {Binary ()}");
            else if (sNumSystem == "h") Console.WriteLine ($"The converted hexadecimal value of {sMyNum} is {Hexa ()}");
            else Console.WriteLine ("Please enter a valid input !");
         } while (sNumSystem is not "b" and not "h");
      }

      static string Hexa () {
         do {
            if (sMyNum == 0) sResult = "0";
            else {
               int remain = sMyNum % 16;
               sMyNum /= 16;
               if (remain / 10 == 0) sResult = $"{remain}{sResult}";
               else {
                  string remainHexa = remain switch {
                     10 => "A",
                     11 => "B",
                     12 => "C",
                     13 => "D",
                     14 => "E",
                     15 => "F"
                  };
                  sResult = remainHexa + sResult;
               }
            }
         } while (sMyNum != 0);
         return sResult;
      }

      static string Binary () {
         if (sMyNum == 0) sResult = "0";
         else {
            do {
               int remain = sMyNum % 2;
               sMyNum /= 2;
               sResult = $"{remain}{sResult}";
            } while (sMyNum != 0);
         }
         return sResult;
      }

      static int sMyNum;
      static bool sIsValid;
      static string sNumSystem = "", sResult = "";
   }
}

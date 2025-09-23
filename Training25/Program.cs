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
            sIsValid = int.TryParse (Console.ReadLine (), out sInput1);
         } while (!sIsValid);
         sInput2 = sInput1;
         Console.WriteLine ("Enter the number system to convert:\nb - binary\th - hexa");
         do {
            sNumSystem = Console.ReadLine ().ToLower ().Trim ();
            if (sNumSystem == "b") Binary ();
            else if (sNumSystem == "h") Hexa ();
            else Console.WriteLine ("Please enter a valid input !");
         } while (sNumSystem is not "b" and not "h");
      }

      static void Hexa () {
         do {
            if (sInput2 == 0) sResult = "0";
            else {
               int remain = sInput2 % 16;
               sInput2 /= 16;
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
         } while (sInput2 != 0);
         Console.WriteLine ($"The converted hexadecimal value of {sInput1} is {sResult}");
      }

      static void Binary () {
         if (sInput2 == 0) sResult = "0";
         else {
            do {
               int remain = sInput2 % 2;
               sInput2 /= 2;
               sResult = $"{remain}{sResult}";
            } while (sInput2 != 0);
         }
         Console.WriteLine ($"The converted binary value of {sInput1} is {sResult}");
      }

      static int sInput1, sInput2;
      static bool sIsValid;
      static string sNumSystem = "", sResult = "";
   }
}

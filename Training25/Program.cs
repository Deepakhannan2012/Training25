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
         Console.WriteLine ("Enter the number that is to be converted:");
         do {
            sIsValid = int.TryParse (Console.ReadLine (), out sInput1);
            if (sIsValid == false) Console.WriteLine ("Please enter a valid number !");
         } while (!sIsValid);
         sInput2 = sInput1;
         Console.WriteLine ("Enter the number system to convert:\nb - binary\th-hexa");
         do {
            sNumSystem = Console.ReadLine ().ToLower ().Trim ();
            if (sNumSystem == "b") Binary (sInput2);
            else if (sNumSystem == "h") Hexa (sInput2);
            else Console.WriteLine ("Please enter a valid input !");
         } while (sNumSystem != "b" && sNumSystem != "h");
      }

      static void Hexa (int input2) {
         do {
            if (input2 == 0) sResult = "0";
            else {
               int remain = input2 % 16;
               input2 /= 16;
               if (remain / 10 == 0) sResult = remain.ToString () + sResult;
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
         } while (input2 != 0);
         Console.WriteLine ($"The converted hexadecimal value of {sInput1} is {sResult}");
      }

      static void Binary (int input2) {
         if (input2 == 0) sResult = "0";
         else {
            do {
               int remain = input2 % 2;
               input2 /= 2;
               sResult = remain.ToString () + sResult;
            } while (input2 != 0);
         }
         Console.WriteLine ($"The converted binary value of {sInput1} is {sResult}");
      }

      static int sInput1, sInput2;
      static bool sIsValid;
      static string sNumSystem = "", sResult = "";
   }
}

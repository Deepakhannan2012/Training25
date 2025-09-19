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
         int input1;
         int input2;
         bool isValid;
         string numSystem = "";
         string result = "";
         do {
            isValid = int.TryParse (Console.ReadLine (), out input1);
            if (isValid == false) Console.WriteLine ("Please enter a valid number !");
         }while (!isValid);
         input2 = input1;
         Console.WriteLine ("Enter the number system to convert:\nb - binary\th-hexa");
         do {
            numSystem = Console.ReadLine ();
            if (numSystem.ToLower ().Trim () == "b") {
               // Binary conversion
               do {
                  int remain = input2 % 2;
                  input2 = input2 / 2;
                  result = remain.ToString () + result;
               }
               while (input2 != 0);
            } else if (numSystem.ToLower ().Trim () == "h") {
               // Hexa conversion
               do {
                  int remain = input2 % 16;
                  input2 = input2 / 16;
                  string remainHexa = "";
                  if (remain / 10 == 0) {
                     result = remain.ToString () + result;
                  } else {
                     switch (remain) {
                        case 10: remainHexa = "A"; break;
                        case 11: remainHexa = "B"; break;
                        case 12: remainHexa = "C"; break;
                        case 13: remainHexa = "D"; break;
                        case 14: remainHexa = "E"; break;
                        case 15: remainHexa = "F"; break;
                     }
                     result = remainHexa + result;
                  }
               } while (input2 != 0);
            } else {
               Console.WriteLine ("Please enter a valid input !");
            }
         }while (numSystem.ToLower ().Trim () != "b" && numSystem.ToLower ().Trim () != "h");
         if (numSystem.ToLower ().Trim () == "b") Console.WriteLine ($"The converted binary value of {input1} is {result}");
         else Console.WriteLine ($"The converted hexadecimal value of {input1} is {result}");
      }
   }
}

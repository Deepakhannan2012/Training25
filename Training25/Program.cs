// ------------------------------------------------------------------------------------------------
// Training ~ A training program for new joinees at Metamation, Batch- July 2025.
// Copyright (c) Metamation India.
// ------------------------------------------------------------------
// Program.cs
// Program on T13 branch.
// ------------------------------------------------------------------------------------------------
using static System.Console;

namespace Training25;

internal class Program {
   static void Main () {
      GetArray (out char[] charArray);
      GetSplChar (out char splChar);
      GetSortOrder (out char order);
      SortSwap (charArray, splChar, order, out char[] sortedArray);
      WriteLine (string.Join (", ", sortedArray));
   }

   // Gets the array of characters from user input
   static void GetArray (out char[] arr) {
      while (true) {
         Write ("Enter the characters to add to the array: ");
         string input = ReadLine ()?.ToLower ().Trim () ?? "";
         if (!string.IsNullOrEmpty (input) && input.All (char.IsLetter)) {
            arr = input.ToCharArray (); break;
         }
         PrintInvalidMsg ();
      }
   }

   // Gets the special character from user input
   static void GetSplChar (out char splChar) {
      while (true) {
         Write ("Enter the special character: ");
         GetInput (out splChar);
         if (char.IsLetter (splChar)) break;
         PrintInvalidMsg ();
      }
   }

   // Gets the sort order from user input
   static void GetSortOrder (out char order) {
      order = 'a';
      while (true) {
         Write ("Would you like to specify the sort order? (y/n): ");
         GetInput (out char key);
         if (key is not ('y' or 'n')) { PrintInvalidMsg (); continue; }
         if (key is 'y')
            while (true) {
               Write ("Enter the sort order (a - ascending or d - descending): ");
               GetInput (out order);
               if (order is 'a' or 'd') break;
               PrintInvalidMsg ();
            }
         break;
      }
   }

   // Sorts the array and moves the special character to the end
   static void SortSwap (char[] arr, char splChar, char order, out char[] sortedArray) {
      (int index, int arrLen) = (0, arr.Length);
      sortedArray = new char[arrLen];
      foreach (char c in arr)
         if (c != splChar) sortedArray[index++] = c;
      Array.Sort (sortedArray, 0, index);
      if (order is 'd') Array.Reverse (sortedArray, 0, index);
      Array.Fill (sortedArray, splChar, index, arrLen - index);
   }

   // Gets user input
   static void GetInput (out char input) {
      input = char.ToLower (ReadKey ().KeyChar); WriteLine ();
   }

   // Prints invalid input message
   static void PrintInvalidMsg () => Write ("Invalid input ! ");
}

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
      GetArray (out char[] CharArray);
      GetSplChar (out char splChar);
      GetSortOrder (out char order);
      SortSwap (CharArray, splChar, order, out char[] sortedArray);
      WriteLine (string.Join (", ", sortedArray));
   }

   // Method to get the array of characters from user input
   static void GetArray (out char[] myArray) {
      while (true) {
         Write ("Enter the characters to add to the array: ");
         string input = ReadLine ()?.ToLower ().Trim () ?? "";
         if (!string.IsNullOrEmpty (input) && input.All (char.IsLetter)) {
            myArray = input.ToCharArray ();
            break;
         }
         PrintInvalidMsg ();
      }
   }

   // Method to get the special character from user input
   static void GetSplChar (out char splChar) {
      while (true) {
         Write ("Enter the special character: ");
         GetInput (out splChar);
         if (char.IsLetter (splChar)) break;
         PrintInvalidMsg ();
      }
   }

   // Method to get the sort order from user input
   static void GetSortOrder (out char order) {
      order = 'a';
      while (true) {
         Write ("Would you like to specify the sort order? (y/n): ");
         GetInput (out char pref);
         if (pref is 'y') {
            while (true) {
               Write ("Enter the sort order (a - ascending or d - descending): ");
               GetInput (out order);
               if (order is 'a' or 'd') break;
               PrintInvalidMsg ();
            }
         }
         if (pref is not ('y' or 'n')) { PrintInvalidMsg (); continue; }
         break;
      }
   }

   // Method to sort the array and move special characters to the end
   static void SortSwap (char[] myArray, char sortChar, char order, out char[] sortedArray) {
      (int index, int arrLen) = (0, myArray.Length);
      sortedArray = new char[arrLen];
      foreach (char c in myArray)
         if (c != sortChar) sortedArray[index++] = c;
      Array.Sort (sortedArray, 0, index);
      if (order is 'd') Array.Reverse (sortedArray, 0, index);
      Array.Fill (sortedArray, sortChar, index, arrLen - index);
   }

   // Method to get user input
   static void GetInput (out char input) {
      input = char.ToLower (ReadKey ().KeyChar);
      WriteLine ();
   }
   // Method to print invalid input message
   static void PrintInvalidMsg () => Write ("Invalid input ! ");
}

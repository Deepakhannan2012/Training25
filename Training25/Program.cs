// ------------------------------------------------------------------------------------------------
// Training ~ A training program for new joinees at Metamation, Batch- July 2025.
// Copyright (c) Metamation India.
// ------------------------------------------------------------------
// Program.cs
// Program on T12 branch.
// ------------------------------------------------------------------------------------------------
using static System.Console;

namespace Training25;

internal class Program {
   static void Main () {
      string input;
      Write ("Enter the string representation of the votes: ");
      while (true) {
         input = ReadLine ()?.ToLower () ?? "";
         if (string.IsNullOrEmpty (input) || !input.All (Char.IsLetter)) {
            Write ("Invalid input. Please enter a string containing only letters: ");
            continue;
         }
         break;
      }
      MaxVotes (input, out char maxChar, out int maxVote);
      WriteLine ($"The winner is {maxChar} with {maxVote} votes");
   }

   // Finds the letter with the maximum votes and its count
   static void MaxVotes (string input, out char maxChar, out int maxVotes) {
      (maxChar, maxVotes) = (' ', 0);
      Dictionary<char, int> charCount = [];
      foreach (char ch in input)
         charCount[ch] = charCount.TryGetValue (ch, out int currentCount) ? currentCount + 1 : 1;
      foreach (var pair in charCount)
         if (pair.Value > maxVotes) (maxChar, maxVotes) = (pair.Key, pair.Value);
   }
}

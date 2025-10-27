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
      bool isValid;
      Write ("Enter the string representation of the votes: ");
      do {
         input = ReadLine () ?? "";
         isValid = !string.IsNullOrEmpty (input) && input.Trim ().All (Char.IsLetter);
         if (!isValid) Write ("Invalid input. Please enter a string containing only letters: ");
      } while (!isValid);
      MaxVotes (input, out char maxChar, out int maxVote);
      WriteLine ($"The winner is {maxChar} with {maxVote} votes");
   }

   // Finds the letter with the maximum votes and its count
   static void MaxVotes (string input, out char maxChar, out int maxVotes) {
      Dictionary<char, int> count = [];
      foreach (char ch in input.ToLower ())
         count[ch] = count.ContainsKey (ch) ? ++count[ch] : 1;
      maxVotes = count.Values.Max ();
      maxChar = count.Aggregate ((a, b) => a.Value >= b.Value ? a : b).Key;
   }
}

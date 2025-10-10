// ------------------------------------------------------------------------------------------------
// Training ~ A training program for new joinees at Metamation, Batch- July 2025.
// Copyright (c) Metamation India.
// ------------------------------------------------------------------
// Program.cs
// Program on T04 branch.
// ------------------------------------------------------------------------------------------------
using static System.Console;
using System.Text;

namespace Training25;
internal class Program {
   static void Main (string[] args) {
      OutputEncoding = new UnicodeEncoding ();
      char[] white = ['♖', '♘', '♗', '♕', '♔', '♗', '♘', '♖'];
      char[] black = ['♜', '♞', '♝', '♛', '♚', '♝', '♞', '♜'];
      for (int i = 0; i <= 32; i++) {
         Action action = i switch {
            0 => () => Border ('┌', '┬', '┐'),
            2 => () => Pieces (black),
            6 => () => Pawn ('♟'),
            26 => () => Pawn ('♙'),
            30 => () => Pieces (white),
            32 => () => Border ('└', '┴', '┘'),
            _ when i % 4 is 0 => () => Border ('├', '┼', '┤'),
            _ => () => WriteLine ($"{String.Concat (Enumerable.Repeat ("│\t", 8))}│")
         };
         action ();
      }
   }

   // Print pieces in a row
   static void Pieces (char[] colour) {
      for (int i = 0; i <= 7; i++) Write ($"│   {colour[i]}   "); WriteLine ("│");
   }

   // Print border line
   static void Border (char left, char mid, char right)
      => WriteLine ($"{left}{String.Concat (Enumerable.Repeat ($"───────{mid}", 7))}───────{right}");

   // Print a row of pawns
   static void Pawn (char piece)
      => WriteLine ($"{String.Concat (Enumerable.Repeat ($"│   {piece}   ", 8))}│");
}
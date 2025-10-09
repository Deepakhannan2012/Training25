// ------------------------------------------------------------------------------------------------
// Training ~ A training program for new joinees at Metamation, Batch- July 2025.
// Copyright (c) Metamation India.
// ------------------------------------------------------------------
// Program.cs
// Program on T05 branch.
// ------------------------------------------------------------------------------------------------
using static System.Console;

namespace Training25;
internal class Program {
   static void Main (string[] args) {
      // Displays multiplication table from 1 to 10
      for (int tableNum = 1; tableNum < 11; tableNum++) {
         for (int mulNum = 1; mulNum < 11; mulNum++) WriteLine ($"{tableNum} * {mulNum,2} = {tableNum * mulNum}");
         WriteLine ("");
      }
   }
}


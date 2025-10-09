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
      (int startNum, int endNum) = (1, 10);
      // Displays multiplication table from 1 to 10
      for (int tableNum = startNum; tableNum <= endNum; tableNum++) {
         for (int mulNum = startNum; mulNum <= endNum; mulNum++) WriteLine ($"{tableNum} * {mulNum,2} = {tableNum * mulNum}");
         WriteLine ("");
      }
   }
}
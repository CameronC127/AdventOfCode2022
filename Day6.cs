using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace AdventOfCode2022
{
  internal class Day6
  {
    public void Run()
    {
      Console.WriteLine("DAY 6----------------------------------------");
      int doneCount = 0;
      int doneCount2 = 0;
      foreach (var line in File.ReadAllLines(InputFilePath))
      {
        for (int i = 0; i < line.Length-4; i++)
        {
          string substring = line.Substring(i, 4);
          if (substring.Distinct().Count() == substring.Length)
          {
            doneCount = i + 4;
            break;
          }
        }
        for (int i = 0; i < line.Length - 14; i++)
        {
          string substring = line.Substring(i, 14);
          if (substring.Distinct().Count() == substring.Length)
          {
            doneCount2 = i + 14;
            break;
          }
        }
      }
      Console.WriteLine($"Part 1 : {doneCount}");
      Console.WriteLine($"Part 2 : {doneCount2}");
      Console.WriteLine("---------------------------------------------");
    }

    public string InputFilePath { get; set; } = @"C:\Users\Cameron Cronkhite\OneDrive\git\AdventOfCode2022\inputs\day6input.txt";
  }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace AdventOfCode2022
{
  internal class Day3
  {
    public void Run()
    {
      Console.WriteLine("DAY 3----------------------------------------");
      List<string> charCodes = new List<string>();
      //uppercase a-z have priorities 1 through 26
      for (int i = 97; i <= 122; i++)
      {
        charCodes.Add(char.ConvertFromUtf32(i));
      }
      //uppercase a-z have priorities 27 through 52
      for (int i = 65; i <= 90; i++)
      {
        charCodes.Add(char.ConvertFromUtf32(i));
      }
      string[] lineHalves = new string[2];
      int total = 0;
      foreach (var line in File.ReadAllLines(InputFilePath))
      {
        lineHalves[0] = line.Substring(0,line.Length/2);
        lineHalves[1] = line.Substring(line.Length / 2, line.Length / 2);
        foreach (var letter in lineHalves[0])
        {
          if (lineHalves[1].Contains(letter))
          {
            total += charCodes.IndexOf(letter.ToString()) + 1;
            break;
          }
        }
      }
      Console.WriteLine($"Part 1 : {total}");

      var allLines = File.ReadAllLines(InputFilePath);
      total = 0;
      for (int i = 0; i < allLines.Length; i+=3)
      {
        foreach (var letter in allLines[i])
        {
          if (allLines[i+1].Contains(letter) && allLines[i+2].Contains(letter))
          {
            total += charCodes.IndexOf(letter.ToString()) + 1;
            break;
          }
        }
      }
      Console.WriteLine($"Part 2 : {total}");
      Console.WriteLine("---------------------------------------------");
    }

    public string InputFilePath { get; set; } = @"C:\Users\Cameron Cronkhite\OneDrive\git\AdventOfCode2022\inputs\day3input.txt";
  }
}

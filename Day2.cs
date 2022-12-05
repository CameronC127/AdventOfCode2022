using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace AdventOfCode2022
{
  internal class Day2
  {
    public void Run()
    {
      Console.WriteLine("DAY 2----------------------------------------");
      int totalScore = 0;
      string[] lines = System.IO.File.ReadAllLines(InputFilePath);
      //Part 1
      foreach (string line in lines)
      {
        if (line[0] == 'A')
        {
          if(line[2] == 'X')
          {
            totalScore += 1 + 3;
          }
          else if (line[2] == 'Y')
          {
            totalScore += 2 + 6;
          }
          else if (line[2] == 'Z')
          {
            totalScore += 3 + 0;
          }
        }
        else if (line[0] == 'B')
        {
          if (line[2] == 'X')
          {
            totalScore += 1 + 0;
          }
          else if (line[2] == 'Y')
          {
            totalScore += 2 + 3;
          }
          else if (line[2] == 'Z')
          {
            totalScore += 3 + 6;
          }
        }
        if (line[0] == 'C')
        {
          if (line[2] == 'X')
          {
            totalScore += 1 + 6;
          }
          else if (line[2] == 'Y')
          {
            totalScore += 2 + 0;
          }
          else if (line[2] == 'Z')
          {
            totalScore += 3 + 3;
          }
        }
        
      }
      Console.WriteLine($"Part 1 : RPS Score : {totalScore}");

      totalScore = 0;
      //Part 2
      foreach (string line in lines)
      {
        if (line[0] == 'A')
        {
          if (line[2] == 'X')
          {
            totalScore += 3 + 0;
          }
          else if (line[2] == 'Y')
          {
            totalScore += 1 + 3;
          }
          else if (line[2] == 'Z')
          {
            totalScore += 2 + 6;
          }
        }
        else if (line[0] == 'B')
        {
          if (line[2] == 'X')
          {
            totalScore += 1 + 0;
          }
          else if (line[2] == 'Y')
          {
            totalScore += 2 + 3;
          }
          else if (line[2] == 'Z')
          {
            totalScore += 3 + 6;
          }
        }
        if (line[0] == 'C')
        {
          if (line[2] == 'X')
          {
            totalScore += 2 + 0;
          }
          else if (line[2] == 'Y')
          {
            totalScore += 3 + 3;
          }
          else if (line[2] == 'Z')
          {
            totalScore += 1 + 6;
          }
        }

      }
      Console.WriteLine($"Part 2 : RPS Score : {totalScore}");
      Console.WriteLine("---------------------------------------------");
    }

    public string InputFilePath { get; set; } = @"C:\Users\Cameron Cronkhite\OneDrive\git\AdventOfCode2022\inputs\day2input.txt";
  }
}

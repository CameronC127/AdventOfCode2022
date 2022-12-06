using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace AdventOfCode2022
{
  internal class Day4
  {
    public void Run()
    {
      Console.WriteLine("DAY 4----------------------------------------");
      int total = 0;
      int total2 = 0;
      foreach (var line in File.ReadAllLines(InputFilePath))
      {
        var numSecs = line.Split(',');
        var range1L = int.Parse(numSecs[0].Split("-")[0]);
        var range1H = int.Parse(numSecs[0].Split("-")[1]);
        var range2L = int.Parse(numSecs[1].Split("-")[0]);
        var range2H = int.Parse(numSecs[1].Split("-")[1]);
        var r1 = Enumerable.Range(int.Parse(numSecs[0].Split("-")[0]), int.Parse(numSecs[0].Split("-")[1])- int.Parse(numSecs[0].Split("-")[0])+1);
        var r2 = Enumerable.Range(int.Parse(numSecs[1].Split("-")[0]), int.Parse(numSecs[1].Split("-")[1]) - int.Parse(numSecs[1].Split("-")[0]) + 1);
        var intersect = r1.Intersect(r2);
        if (range1L >= range2L && range1H <= range2H)
        {
          total ++;
        }
        else if (range2L >= range1L && range2H <= range1H)
        {
          total ++;
        }
        if (intersect.Count() > 0 )
        {
          total2++;
        }
      }
      Console.WriteLine($"Part 1 : {total}");
      Console.WriteLine($"Part 2 : {total2}");
      Console.WriteLine("---------------------------------------------");
    }

    public string InputFilePath { get; set; } = @"C:\Users\Cameron Cronkhite\OneDrive\git\AdventOfCode2022\inputs\day4input.txt";
  }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace AdventOfCode2022
{
  internal class Day1
  {
    public void Run()
    {
      Console.WriteLine("DAY 1----------------------------------------");
      List<int> elfCals = new List<int>();
      int curCalCount = 0;
      string[] lines = System.IO.File.ReadAllLines(InputFilePath);
      foreach (string line in lines)
      {
        try
        {
          curCalCount += int.Parse(line);
        }
        catch (Exception e)
        {
          elfCals.Add(curCalCount);
          curCalCount = 0;
        }
      }
      
      int bestElf = elfCals.Max();
      Console.WriteLine($"Best Elf: {bestElf}");
      elfCals.Remove(bestElf);

      int secondBestElf = elfCals.Max();
      Console.WriteLine($"Second Best Elf: {secondBestElf}");
      elfCals.Remove(secondBestElf);

      int thirdBestElf = elfCals.Max();
      Console.WriteLine($"Third Best Elf: {thirdBestElf}");
      elfCals.Remove(thirdBestElf);

      int totalElfs = bestElf + secondBestElf + thirdBestElf;
      Console.WriteLine($"Total Cals: {totalElfs}");
      Console.WriteLine("---------------------------------------------");
    }
    public string InputFilePath { get; set; } = @"C:\Users\Cameron Cronkhite\OneDrive\git\AdventOfCode2022\day1input.txt";
  }
}

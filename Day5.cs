using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace AdventOfCode2022
{
  internal class Day5
  {
    public void Run()
    {
      Console.WriteLine("DAY 5----------------------------------------");
      List<string> lines = new List<string>();
      List<Stack<string>> stacks = new List<Stack<string>>();
      List<Stack<string>> stacks2 = new List<Stack<string>>();
      foreach (string line in File.ReadAllLines(InputFilePath))
      {
        if (line.Contains("1"))
        {
          break;

        }
        lines.Add(line);
      }

      //create stacks
      for (int i = 0; i < 9; i++)
      {
        stacks.Add(new Stack<string>());
        stacks2.Add(new Stack<string>());
      }

      //fill stacks
      for (int row = lines.Count()-1; row >= 0; row--)
      {
        for(int col = 1; col < lines[row].Length; col+=4)
        {
          if (lines[row][col].ToString() != " ")
          {
            stacks[col / 4].Push(lines[row][col].ToString());
            stacks2[col / 4].Push(lines[row][col].ToString());
          }
        }
      }

      //do moves
      foreach (string line in File.ReadAllLines(InputFilePath))
      {
        if (line.Contains("move"))
        {
          var moves = line.Split(" ");
          var crateNum = int.Parse(moves[1]);
          var from = int.Parse(moves[3]) - 1;
          var to = int.Parse(moves[5]) - 1;
          //p1
          for (int i = 0; i < crateNum; i++)
          {
            if (stacks[from].Count() > 0)
            {
              stacks[to].Push(stacks[from].Pop());
            }
          }

          //p2
          Stack<string> interstack = new Stack<string>();
          for (int i = 0; i < crateNum; i++)
          {
            if (stacks2[from].Count() > 0)
            {
              interstack.Push(stacks2[from].Pop());
            }
          }
          int pushSize = interstack.Count();
          for (int i = 0; i < pushSize; i++)
          {
            stacks2[to].Push(interstack.Pop());
          }
        } 
      }
      string p1 = "";
      foreach(var stack in stacks)
      {
        if (stack.Count() > 0)
        {
          p1 += stack.Peek();
        }
      }
      Console.WriteLine($"Part 1 : {p1}");

      string p2 = "";
      foreach (var stack in stacks2)
      {
        if (stack.Count() > 0)
        {
          p2 += stack.Peek();
        }
      }
      Console.WriteLine($"Part 2 : {p2}");


      Console.WriteLine("---------------------------------------------");
    }

    public string InputFilePath { get; set; } = @"C:\Users\Cameron Cronkhite\OneDrive\git\AdventOfCode2022\inputs\day5input.txt";
  }
}

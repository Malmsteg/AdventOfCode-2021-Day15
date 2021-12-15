using System.IO;
using System.Collections.Generic;
using System;
using System.Linq;

namespace AdventOfCode_2021_Day15
{
    public static class Program
    {
        public static void Main()
        {
            string currentDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string file = Path.Combine(currentDirectory, @"..\..\..\test.txt");
            string path = Path.GetFullPath(file);
            string[] text = File.ReadAllText(path).Replace("\r", "").Split("\n");

            int xLen = text[0].Length;
            int yLen = text.Length;

            int[,] puzzleInput = new int[xLen,yLen];

            for(int i = 0; i < text[0].Length; i++)
            {
                for (int j = 0; j < text.Length; j++)
                {
                    puzzleInput[i,j] = Convert.ToInt32(text[i][j] - '0');
                }
            }

            int aPath = 0;
            for(int i = 1; i < puzzleInput.GetLength(0);i++)
            {
                aPath+= puzzleInput[i,0];
            }
            for(int j = 1; j < puzzleInput.GetLength(1);j++)
            {
                aPath+= puzzleInput[0,j];
            }
            Console.WriteLine(aPath);

            int tempPath = 0;
            for(int i = 1; i < puzzleInput.GetLength(0);i++)
            {
                for(int j = 0; j < puzzleInput.GetLength(1);j++)
                {

                }   
            }




        }
    }
}

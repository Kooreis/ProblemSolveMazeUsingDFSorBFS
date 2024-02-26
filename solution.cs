Here is a simple console application in C# that uses depth-first search to solve a maze.

```C#
using System;
using System.Collections.Generic;

public class Program
{
    static char[,] maze = {
        { 'S', '#', '#', '#', '#', '#'},
        { '#', ' ', ' ', ' ', ' ', '#'},
        { '#', ' ', '#', '#', ' ', '#'},
        { '#', ' ', '#', '#', ' ', '#'},
        { '#', ' ', ' ', ' ', ' ', 'E'},
        { '#', '#', '#', '#', '#', '#'}
    };

    static List<Tuple<int, int>> path = new List<Tuple<int, int>>();

    public static void Main()
    {
        if (DFS(0, 0))
        {
            foreach (var step in path)
            {
                Console.WriteLine(step);
            }
        }
        else
        {
            Console.WriteLine("No path found!");
        }
    }

    static bool DFS(int row, int col)
    {
        if (maze[row, col] == 'E')
        {
            path.Add(new Tuple<int, int>(row, col));
            return true;
        }

        if (maze[row, col] == ' ' || maze[row, col] == 'S')
        {
            maze[row, col] = '.';

            int[] rowMoves = { -1, 0, 1, 0 };
            int[] colMoves = { 0, 1, 0, -1 };

            for (int i = 0; i < 4; i++)
            {
                if (IsValidMove(row + rowMoves[i], col + colMoves[i]))
                {
                    path.Add(new Tuple<int, int>(row, col));

                    if (DFS(row + rowMoves[i], col + colMoves[i]))
                    {
                        return true;
                    }

                    path.RemoveAt(path.Count - 1);
                }
            }
        }

        return false;
    }

    static bool IsValidMove(int row, int col)
    {
        if (row < 0 || col < 0 || row >= maze.GetLength(0) || col >= maze.GetLength(1))
        {
            return false;
        }

        if (maze[row, col] == '#' || maze[row, col] == '.')
        {
            return false;
        }

        return true;
    }
}
```

This program represents the maze as a 2D array of characters, where 'S' is the start, 'E' is the end, '#' are walls, and ' ' are open paths. The DFS function uses recursion to explore all possible paths from the start to the end. If a path is found, it is stored in the 'path' list. If no path is found, the program prints "No path found!".
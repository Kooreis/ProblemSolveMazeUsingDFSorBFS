```C#
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
```
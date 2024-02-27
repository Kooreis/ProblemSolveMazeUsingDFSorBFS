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
```
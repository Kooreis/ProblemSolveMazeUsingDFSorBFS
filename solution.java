Here is a simple console application in Java that uses depth-first search to solve a maze. The maze is represented as a 2D array where 1's represent walls and 0's represent paths. The start point is at (0,0) and the end point is at (n-1, m-1).

```java
import java.util.Stack;

public class Main {
    private static int[][] maze = {
            {0, 1, 0, 0, 0},
            {0, 0, 0, 1, 0},
            {1, 1, 0, 1, 1},
            {0, 0, 0, 0, 0},
            {1, 1, 1, 1, 0}
    };

    private static final int[][] DIRECTIONS = {{0, 1}, {1, 0}, {0, -1}, {-1, 0}};

    public static void main(String[] args) {
        boolean[][] visited = new boolean[maze.length][maze[0].length];
        Stack<int[]> stack = new Stack<>();
        stack.push(new int[]{0, 0});

        while (!stack.isEmpty()) {
            int[] pos = stack.pop();
            visited[pos[0]][pos[1]] = true;

            if (pos[0] == maze.length - 1 && pos[1] == maze[0].length - 1) {
                System.out.println("Path found");
                return;
            }

            for (int[] direction : DIRECTIONS) {
                int newX = pos[0] + direction[0];
                int newY = pos[1] + direction[1];

                if (newX >= 0 && newX < maze.length && newY >= 0 && newY < maze[0].length
                        && maze[newX][newY] == 0 && !visited[newX][newY]) {
                    stack.push(new int[]{newX, newY});
                }
            }
        }

        System.out.println("No path found");
    }
}
```

This program uses a stack to keep track of the path it's currently exploring. If it reaches the end of the maze, it prints "Path found" and exits. If it exhausts all possible paths without finding the end, it prints "No path found".
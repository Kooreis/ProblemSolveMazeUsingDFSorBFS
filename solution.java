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
}
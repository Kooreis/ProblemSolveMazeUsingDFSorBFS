Here is a Python console application that uses depth-first search to solve a maze. The maze is represented as a 2D list, where 0s represent walls and 1s represent paths. The start is at the top left corner and the goal is at the bottom right corner.

```python
class Node:
    def __init__(self, position:(), parent:()):
        self.position = position
        self.parent = parent
        self.g = 0 
        self.h = 0 
        self.f = 0 

    def __eq__(self, other):
        return self.position == other.position

def astar(maze, start, end):
    open = []
    closed = []

    start_node = Node(start, None)
    goal_node = Node(end, None)

    open.append(start_node)
    
    while len(open) > 0:
        open.sort()
        current_node = open.pop(0)
        closed.append(current_node)
        
        if current_node == goal_node:
            path = []
            while current_node != start_node:
                path.append(current_node.position)
                current_node = current_node.parent
            path.append(start) 
            return path[::-1]

        (x, y) = current_node.position
        neighbors = [(x-1, y), (x+1, y), (x, y-1), (x, y+1)]

        for next in neighbors:
            if maze[next[0]][next[1]] != 0:
                continue

            neighbor = Node(next, current_node)

            if(neighbor in closed):
                continue

            if(neighbor in open):
                continue

            open.append(neighbor)
    return None

def main():
    maze = [[0, 1, 0, 0, 0, 0],
            [0, 1, 0, 1, 1, 0],
            [0, 1, 0, 0, 1, 0],
            [0, 0, 0, 0, 1, 0],
            [0, 0, 0, 0, 0, 0]]

    start = (0, 0) 
    end = (4, 5) 

    path = astar(maze, start, end)
    print(path)

if __name__ == "__main__":
    main()
```

This program uses the A* search algorithm, which is a type of depth-first search. It starts at the top left corner of the maze and explores the maze by moving to the next unvisited node that has the lowest f value (g value + h value). The g value is the cost from the start node to the current node, and the h value is the heuristic estimated cost from the current node to the goal node. The program continues this process until it reaches the goal node or if there are no more unvisited nodes, in which case it returns None.
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
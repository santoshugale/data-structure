using System.Collections.Generic;

namespace Leetcode
{
    public class QItem
    {
        public int row;
        public int col;
        public int dist;

        public QItem(int row, int col, int dist)
        {
            this.row = row;
            this.col = col;
            this.dist = dist;
        }
    }

    public class Maze
    {
        public static QItem FindSource(char[,] grid)
        {
            var source = new QItem(0, 0, 0);
            for (var i = 0; i < grid.GetLength(0); i++)
            {
                for (var j = 0; j < grid.GetLength(1); j++)
                {
                    // Finding source
                    if (grid[i, j] == 's')
                    {
                        source.row = i;
                        source.col = j;
                        return source;
                    }
                }
            }

            return source;
        }
        public static int MinDistance(char[,] grid)
        {

            var source = FindSource(grid);
            // applying BFS on matrix cells starting from source
            var queue = new Queue<QItem>();
            queue.Enqueue(new QItem(source.row, source.col, 0));
            bool[,] visited = new bool[grid.GetLength(0), grid.GetLength(1)];
            visited[source.row, source.col] = true;
            while (queue.Count != 0)
            {
                var p = queue.Dequeue();
                // Destination found;
                if (grid[p.row, p.col] == 'd')
                {
                    return p.dist;
                }

                // moving up
                if (IsValid(p.row - 1, p.col, grid, visited))
                {
                    queue.Enqueue(new QItem(p.row - 1, p.col, p.dist + 1));
                    visited[p.row - 1, p.col] = true;
                }

                // moving down
                if (IsValid(p.row + 1, p.col, grid, visited))
                {
                    queue.Enqueue(new QItem(p.row + 1, p.col, p.dist + 1));
                    visited[p.row + 1, p.col] = true;
                }

                // moving left
                if (IsValid(p.row, p.col - 1, grid, visited))
                {
                    queue.Enqueue(new QItem(p.row, p.col - 1, p.dist + 1));
                    visited[p.row, p.col - 1] = true;
                }

                // moving right
                if (IsValid(p.row - 1, p.col + 1, grid, visited))
                {
                    queue.Enqueue(new QItem(p.row, p.col + 1, p.dist + 1));
                    visited[p.row, p.col + 1] = true;
                }
            }

            return -1;
        }

        // checking where it's valid or not
        private static bool IsValid(int x, int y, char[,] grid, bool[,] visited)
        {
            if (x >= 0 && y >= 0 && x < grid.GetLength(0) && y < grid.GetLength(1) && grid[x, y] != '0' &&
                visited[x, y] == false)
            {
                return true;
            }
            return false;
        }
    }
}

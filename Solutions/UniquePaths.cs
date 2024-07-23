namespace Solutions;

public class UniquePaths
{
    public int UniquePathsSolve(int m, int n)
    {
        var grid = new int[m, n];
        if (m == 1 || n == 1)
        {
            return 1;
        }
        
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (j == 0 || i == 0)
                {
                    grid[i, j] = 1;
                }
                else
                {
                    grid[i, j] = grid[i, j - 1] + grid[i - 1, j];
                }
            }
        }


        return grid[m - 1, n - 1];
    }
}
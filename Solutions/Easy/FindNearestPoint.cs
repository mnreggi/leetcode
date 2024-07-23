namespace Solutions.Easy;

/// <summary>
/// You are given two integers, x and y, which represent your current location on a Cartesian grid: (x, y). You are also given an array points where each points[i] = [ai, bi] represents that a point exists at (ai, bi). A point is valid if it shares the same x-coordinate or the same y-coordinate as your location.
/// Return the index (0-indexed) of the valid point with the smallest Manhattan distance from your current location.
/// If there are multiple, return the valid point with the smallest index.
/// If there are no valid points, return -1.The Manhattan distance between two points (x1, y1) and (x2, y2) is abs(x1 - x2) + abs(y1 - y2).
/// </summary>
public class FindNearestPoint
{
    // x = 3, y = 4, points = [[1,2],[3,1],[2,4],[2,3],[4,4]]
    // x = 3, y = 4, points = [[3,1],[2,4],[4,4]]
    // 3-3 = 0 + 4-1 = 3 -> 3
    // 3-2 = 1 + 4-4 = 0 -> 1
    // 3-4 = 1 + 4-4 = 0 -> 1
    public int NearestValidPoint(int x, int y, int[][] points)
    {
        var result = -1;
        var minDistance = int.MaxValue;

        for (int i = 0; i < points.Length; i++)
        {
            if (points[i][0] != x &&  points[i][1] != y)
            {
                continue;
            }

            var absValue = Math.Abs(x - points[i][0]) + Math.Abs(y - points[i][1]);

            if (absValue < minDistance)
            {
                minDistance = absValue;
                result = i;
            }
        }

        return result;
    }
}
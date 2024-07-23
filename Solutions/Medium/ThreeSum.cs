namespace Solutions.Medium;

/// <summary>
/// Given an integer array nums, return all the triplets [nums[i], nums[j], nums[k]] such that i != j, i != k, and j != k, and nums[i] + nums[j] + nums[k] == 0.
/// Notice that the solution set must not contain duplicate triplets.
/// </summary>
public class ThreeSum
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="nums"></param>
    /// <returns></returns>
    public IList<IList<int>> Solve(int[] nums) 
    {
        var sum = nums.Sum(x => x);
        if (nums.Length < 3 || nums.Length == 3 && sum != 0)
        {
            return ArraySegment<IList<int>>.Empty;
        }

        if (nums.Length == 3 && sum == 0)
        {
            return new List<IList<int>> { nums };
        }
        
        // Are they all negatives or all positives.
        if (nums.All(x => x > 0) || nums.All(x => x < 0))
        {
            return ArraySegment<IList<int>>.Empty;
        }

        var result = new List<IList<int>>();
        var sortedList = nums.OrderBy(x => x).ToList();
        
        // Look for the change between negative and positive.
        var findLastIndex = sortedList.FindLastIndex(x => x < 0);

        for (var i = 0; i < nums.Length; i++)
        {
            for (var j = i + 1; j < nums.Length; j++)
            {
                for (var k = j + 1; k < nums.Length; k++)
                {
                    if (nums[i] + nums[j] + nums[k] != 0) continue;

                    var innerResult = new List<int>
                    {
                        nums[i],
                        nums[j],
                        nums[k]
                    };

                    if (result.Any(x => x.OrderBy(x => x).SequenceEqual(innerResult.OrderBy(x => x))))
                    {
                        continue;
                    }
                    
                    result.Add(innerResult);
                }
            }
        }

        return result;
    }
}
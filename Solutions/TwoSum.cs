namespace Solutions;

/// <summary>
/// https://leetcode.com/problems/two-sum/
/// Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.
/// You may assume that each input would have exactly one solution, and you may not use the same element twice.
/// You can return the answer in any order.
///
/// Questions that we could have asked if no conditions were specified:
/// - Because we need to return the indices, that mean that we can't alter the input order, right?
/// - What if the input doesn't give you a solution? What do we want to return?
/// - If any validation occurs before, what do we want to return?
/// </summary>
public class TwoSum
{
    public int[] Solve(int[] nums, int target)
    {
        // First attempt
        var resultFirstAttempt = Array.Empty<int>();

        for (var i = 0; i < nums.Length; i++)
        {
            for (var j = i + 1; j < nums.Length; j++)
            {
                if (nums[i] + nums[j] == target)
                {
                    resultFirstAttempt = new[] { i, j };
                    break;
                }
            }

            if (resultFirstAttempt.Length != 0)
            {
                break;
            }
        }
        
        // Second attempt
        var resultSecondAttempt = Array.Empty<int>();
        var dictionary = new Dictionary<int, int>();
        for (var i = 0; i < nums.Length; i++)
        {
            // The target minus the current value, will give us the number that we need to add to hit the target.
            var needNumber = target - nums[i];
            
            // We now can check if at some point, we saved that number in our dictionary.
            // If so, we return that position (dictionary[needNumber]) and the current position (i)
            if (dictionary.ContainsKey(needNumber))
                resultSecondAttempt = new[] {i, dictionary[needNumber]};
            
            dictionary[nums[i]] = i;
        }
        bool hasMatch = resultFirstAttempt.Select(x => x)
            .Intersect(resultSecondAttempt)
            .Any(); 
        
        return hasMatch ? resultFirstAttempt : Array.Empty<int>();
    }
}
namespace Solutions.Easy;

/// <summary>
/// You are given an integer array nums (0-indexed). In one operation, you can choose an element of the array and increment it by 1.
/// For example, if nums = [1,2,3], you can choose to increment nums[1] to make nums = [1,3,3].
/// Return the minimum number of operations needed to make nums strictly increasing.
/// An array nums is strictly increasing if nums[i] < nums[i+1] for all 0 <= i < nums.length - 1. An array of length 1 is trivially strictly increasing.
/// </summary>
public class MinimumOperationsToMakeTheArrayIncreasing
{
    public int MinOperations(int[] nums)
    {
        if (nums.Length < 2)
        {
            return 0;
        }

        var result = 0;

        // for (int i = indexMaxValue + 1; i < nums.Length; i++)
        // {
        //     var newValue = maxValue + (i - indexMaxValue);
        //     result += newValue - nums[i];
        // }

        // var copyOfArray = new int[nums.Length];
        // Array.Copy(nums, copyOfArray, nums.Length);
        
        for (int i = 0; i < nums.Length - 1; i++)
        {
            if (nums[i] >= nums[i + 1])
            {
                var newValue = nums[i] + 1;
                result += newValue - nums[i + 1];
                nums[i + 1] = newValue;
            }
        }

        return result;
    }
}
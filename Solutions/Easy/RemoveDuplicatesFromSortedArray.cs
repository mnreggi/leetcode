namespace Solutions.Easy;

/// <summary>
/// Given an integer array nums sorted in non-decreasing order, remove the duplicates in-place such that each unique element appears only once.
/// The relative order of the elements should be kept the same.
/// Then return the number of unique elements in nums.
/// </summary>
public class RemoveDuplicatesFromSortedArray
{
    /// <summary>
    /// Non Desc order
    /// In-Place?
    /// Only once
    /// 1- []
    /// 2- null
    /// 3- [0]
    /// 4- [0,0,0]
    /// 5- [1,2,3]
    /// 6- [1,5,4,4]?
    /// 7- So, we do not care of what is returned after the sorted part of the array.
    /// </summary>
    /// <param name="nums"></param>
    /// <returns></returns>
    public int RemoveDuplicates(int[] nums)
    {
        // a SortedSet should be enough, but we need to do it IN-PLACE, so manipulating the array given.
        // var hashSet = new SortedSet<int>(nums);
        var listOfOccurrences = new List<int>();
        var count = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            if (listOfOccurrences.All(x => x != nums[i]))
            {
                nums[count] = nums[i];
                listOfOccurrences.Add(nums[i]);
                count++;
            }
        }

        var copy = nums.Distinct().ToArray();
        copy.CopyTo(nums, 0);

        return nums.Length;
    }
}
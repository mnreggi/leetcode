namespace Solutions;

/// <summary>
/// You are given an integer array height of length n. There are n vertical lines drawn such that the two endpoints of the ith line are (i, 0) and (i, height[i]).
/// Find two lines that together with the x-axis form a container, such that the container contains the most water.
/// Return the maximum amount of water a container can store.
/// Notice that you may not slant the container.
/// </summary>
public class ContainerWithMostWater
{
    public int MaxArea(int[] height)
    {
        var start = 0;
        var end = height.Length - 1;
        var maxWater = 0;
        
        while (start - end != 0)
        {
            var newMaxWater = Math.Min(height[start], height[end]) * (end - start);

            if (maxWater < newMaxWater)
            {
                maxWater = newMaxWater;
            }
            
            if (height[start] < height[end])
            {
                start++;
            }
            else
            {
                end--;
            }
        }
        
        
        var maxAmountOfWater = 0;
        
        for (int i = 0; i < height.Length; i++)
        {
            for (int j = i; j < height.Length; j++)
            {
                var newArea = Math.Min(height[i], height[j]) * (j - i);

                if (maxAmountOfWater < newArea)
                {
                    maxAmountOfWater = newArea;
                }
            }
        }

        return maxAmountOfWater;
    }
}
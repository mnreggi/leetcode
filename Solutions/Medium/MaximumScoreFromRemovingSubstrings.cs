using System.Collections;

namespace Solutions.Medium;

/// <summary>
/// You are given a string s and two integers x and y. You can perform two types of operations any number of times.
/// Remove substring "ab" and gain x points.
/// For example, when removing "ab" from "cabxbae" it becomes "cxbae".
/// Remove substring "ba" and gain y points.For example, when removing "ba" from "cabxbae" it becomes "cabxe".
/// Return the maximum points you can gain after applying the above operations on s.
/// </summary>
public class MaximumScoreFromRemovingSubstrings
{
    public int MaximumGain(string s, int x, int y)
    {
        if (!new[] { "ab", "ba" }.Any(s.Contains))
        { 
            return 0;
        }

        var result = 0;
        var stack = new Stack<char>();
        if (x > y)
        {
            foreach (var c in s)
            {
                if (stack.Count > 0 && c == 'b' && stack.Peek() == 'a')
                {
                    stack.Pop();
                    result += x;
                    continue;
                }
                stack.Push(c);
            }

            var newString = stack.ToArray();
            foreach (var c in newString)
            {
                if (stack.Count > 0 && c == 'a' && stack.Peek() == 'b')
                {
                    stack.Pop();
                    result += y;
                    continue;
                }
                stack.Push(c);
            }
        }
        else
        {
            foreach (var c in s)
            {
                if (stack.Count > 0 && c == 'a' && stack.Peek() == 'b')
                {
                    stack.Pop();
                    result += y;
                    continue;
                }
                stack.Push(c);
            }
            
            var newString = stack.ToArray().Reverse();
            foreach (var c in newString)
            {
                if (stack.Count > 0 && c == 'b' && stack.Peek() == 'a')
                {
                    stack.Pop();
                    result += x;
                    continue;
                }
                stack.Push(c);
            }
        }

        return result;



        // if (!new[] { "ab", "ba"}.Any(s.Contains))
        // {
        //     return 0;
        // }
        //
        // var i = 0;
        // var j = 1;
        //
        // var result = 0;
        // var hashMap = new Dictionary<int, string>();
        //
        // if (x > y)
        // {
        //     while (j < s.Length)
        //     {
        //         if (i < 0)
        //         {
        //             i = 0;
        //             j = i + 1;
        //         }
        //         
        //         if ($"{s[i]}{s[j]}" == "ab")
        //         {
        //             result += x;
        //             s = s.Remove(i, 2);
        //
        //             if (hashMap.ContainsKey(i - 1))
        //             {
        //                 hashMap.Remove(i - 1);
        //             }
        //
        //             i -= 1;
        //             j = i + 1;
        //         }
        //         else if ($"{s[i]}{s[j]}" == "ba")
        //         {
        //             hashMap[i] = "ba";
        //             j++;
        //             i++;
        //         } 
        //         else
        //         {
        //             j++;
        //             i++;
        //         }
        //     }
        //
        //     result += hashMap.Count * y;
        // }
        // else
        // {
        //     while (j < s.Length)
        //     {
        //         if (i < 0)
        //         {
        //             i = 0;
        //             j = i + 1;
        //         }
        //         
        //         if ($"{s[i]}{s[j]}" == "ba")
        //         {
        //             result += y;
        //             s = s.Remove(i, 2);
        //
        //             if (hashMap.ContainsKey(i - 1))
        //             {
        //                 hashMap.Remove(i - 1);
        //             }
        //             i -= 1;
        //             j = i + 1;
        //         }
        //         else if ($"{s[i]}{s[j]}" == "ab")
        //         {
        //             hashMap[i] = "ab";
        //             j++;
        //             i++;
        //         } 
        //         else
        //         {
        //             j++;
        //             i++;
        //         }
        //     }
        //     
        //     result += hashMap.Count * x;
        // }
        //
        // return result;
    }
}
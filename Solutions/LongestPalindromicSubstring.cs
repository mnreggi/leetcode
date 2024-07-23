namespace Solutions;

/// <summary>
/// Given a string s, return the longest palindromic substring in s.
/// A string is palindromic if it reads the same forward and backward.
/// A substring is a contiguous non-empty sequence of characters within a string.
/// </summary>
public class LongestPalindromicSubstring
{
    
    public string LongestPalindrome(string s)
    {
        if (s == new string(s.Reverse().ToArray())) {
            return s;
        }

        var left = LongestPalindrome(s.Substring(1));
        var right = LongestPalindrome(s.Substring(0, s.Length - 1));

        return left.Length > right.Length ? left : right;
        
        
        
        
        
        
        // var resultFirstAttempt = string.Empty;
        // var map = new Dictionary<char, int>();
        //
        // // abcde dcba
        // // abc c, here I need to continue from a different position.
        // // abc c c cba this should be fine. Edge case?
        // // abcd b, I have to move to the last position of b.
        //
        // for (int i = 0; i < s.Length; i++)
        // {
        //     map[s[i]] = i;
        //     for (int j = 1; j < s.Length; j++)
        //     {
        //         // If I do not have it already, I add it.
        //         if (!map.ContainsKey(s[j]))
        //         {
        //             map[s[j]] = j;
        //         }
        //         else
        //         {
        //             var charAlreadyHaveItPosition = map[s[j]];
        //             if (charAlreadyHaveItPosition == s[j])
        //             {
        //                 
        //             }
        //         }
        //
        //     }
        // }
        //
        // return resultFirstAttempt;
    }
}
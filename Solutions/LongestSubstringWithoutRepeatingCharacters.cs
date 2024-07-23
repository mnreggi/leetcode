namespace Solutions;

public class LongestSubstringWithoutRepeatingCharacters
{
    public int LengthOfLongestSubstring(string s) {
        var map = new Dictionary<char, int>();
        var start = 0;
        var result = 0;
        
        for(var i = 0; i < s.Length; i++){
            var c = s[i];
            
            // If I already have it.
            if(map.ContainsKey(c))
            {
                // If the contained letter is behind the current substring, I don't care.
                // Only when the repeated letter is in the current substring I need to "create"/move the new substring init.
                if(start <= map[c])
                {
                    // I need to move the start pointer to the following place after the same letter.
                    start = map[c] + 1;
                }
            }
            
            // This is to compare if the new substring is greater or not.
            result = Math.Max(result, i - start + 1);
            
            // Assign the new place to the letter.
            map[c] = i;
        }
        
        return result;
    }
}
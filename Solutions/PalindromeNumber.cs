namespace Solutions;

/// <summary>
/// https://leetcode.com/problems/palindrome-number/
/// Given an integer x, return true if x is a palindrome, and false otherwise.
/// An integer is a palindrome when it reads the same forward and backward.
/// For example, 121 is a palindrome while 123 is not.
/// Questions that we could have asked if no conditions were specified:
/// Weird Characters?
/// Type of input? Am I gonna read from somewhere?
/// Any limit validations?
/// Negative numbers? Like ABS or not?
/// Is the type of input an int already or string?
/// </summary>
public class PalindromeNumber
{
    public bool IsPalindrome(int x)
    {
        var resultFirstAttempt = true;
        // If negative, we ignore it. It will never be a palindrome
        if (x < 0)
        {
            return false;
        }

        var listOfNumbers = x.ToString().ToCharArray();
        var endOfArray = listOfNumbers.Length;

        for (var i = 0; i <= endOfArray; i++)
        {
            if (listOfNumbers[i] != listOfNumbers[endOfArray - 1])
            {
                resultFirstAttempt = false;
                break;
            }

            endOfArray -= 1;
        }

        // Different way. Reversing the word.
        var originalStr = x.ToString();
        var reversedStr = new string(originalStr.Reverse().ToArray());

        var resultSecondAttempt = originalStr == reversedStr;

        if (resultFirstAttempt != resultSecondAttempt)
        {
            throw new Exception("First attempt not the same as Second attempt");
        }
        
        return resultFirstAttempt;
    }
}
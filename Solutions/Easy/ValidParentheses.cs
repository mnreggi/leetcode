namespace Solutions.Easy;

/// <summary>
/// Given a string s containing just the characters '(', ')', '{', '}', '[' and ']', determine if the input string is valid.
/// An input string is valid if:
/// Open brackets must be closed by the same type of brackets.
/// Open brackets must be closed in the correct order.
/// Every close bracket has a corresponding open bracket of the same type.
/// </summary>
public class ValidParentheses
{
    /// <summary>
    /// Scenarios:
    /// Failed Scenarios:
    /// 1- Empty String.
    /// 3- Any other char
    /// 4- All opened or All closed chars?
    /// 5- (]
    /// 6- ([)]
    /// Correct Scenarios:
    /// 1- (){}[]
    /// 2- Odd number of elements.
    /// 3- ( ( ( [] ) {} ) )
    /// </summary>
    /// <param name="s"></param>
    /// <returns></returns>
    public bool IsValid(string s)
    {
        var openValidChars = new[] { '{', '(', '[' };
        var closedValidChars = new[] { '}', ')', ']' };
        var onlyCharsValid = openValidChars.Concat(closedValidChars);
        
        if (string.IsNullOrEmpty(s) || s.Length % 2 != 0)
        {
            return false;
        }

        if (s.Any(x => !onlyCharsValid.Contains(x)) || s.All(x => openValidChars.Contains(x) || s.All(x => closedValidChars.Contains(x))))
        {
            return false;
        }

        var regulator = 0;
        while (s.Length != regulator)
        {
            regulator = s.Length;
            s = s.Replace("()", "");
            s = s.Replace("{}", "");
            s = s.Replace("[]", "");
        }

        return s.Length == 0;
    }
}
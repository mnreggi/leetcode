namespace Solutions;

/// <summary>
/// Given a signed 32-bit integer x, return x with its digits reversed. If reversing x causes the value to go outside the signed 32-bit integer range [-231, 231 - 1], then return 0.
/// Assume the environment does not allow you to store 64-bit integers (signed or unsigned).
/// </summary>
public class ReverseInteger
{
    public int Reverse(int x)
    {
        long result = 0;

        while (x != 0)
        {
            int digit;
            x = Math.DivRem(x, 10, out digit);
            result = result * 10 + digit;
        }
        
        try
        {
            var isPositive = x >= 0;
            var absValue = Math.Abs(x);
            var reversedString = new string(absValue.ToString().Reverse().ToArray());

            if (!int.TryParse(reversedString, out var converted))
            {
                return 0;
            }

            return isPositive ? Convert.ToInt32(converted) : Convert.ToInt32($"-{converted}");
        }
        catch (OverflowException e)
        {
            return 0;
        }
    }
}
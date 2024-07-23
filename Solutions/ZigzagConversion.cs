namespace Solutions;

/// <summary>
/// The string "PAYPALISHIRING" is written in a zigzag pattern on a given number of rows like this:
/// (you may want to display this pattern in a fixed font for better legibility)
/// P   A   H   N
/// A P L S I I G
/// Y   I   R
/// And then read line by line: "PAHNAPLSIIGYIR"
/// Write the code that will take a string and make this conversion given a number of rows:
/// </summary>
public class ZigzagConversion
{
    
    public string Convert(string s, int numRows)
    {
        var resultFirstAttempt = string.Empty;
        var listOfResults = new Dictionary<int, List<char>>();
        bool goingDown = false;
        var index = 0;

        // Loop through each letter
        foreach (var t in s)
        {
            // This if..else is to avoid inserting on an index that does not exist for the list.
            if (listOfResults.ContainsKey(index))
            {
                // Just add at the index the letter.
                listOfResults[index].Add(t);
            }
            else
            {
                listOfResults.Add(index, new List<char> { t });
            }
            
            // if I'm at the top or bottom, I need to change direction. To avoid Index Exception as well.
            if (index == 0 || index == numRows - 1)
            {
                goingDown = !goingDown;
            }

            // Increase or decrease.
            index += goingDown ? 1 : -1;
        }

        // Build the output
        foreach (var letters in listOfResults.Values)
        {
            resultFirstAttempt += new string(letters.ToArray());
        }
        
        return resultFirstAttempt;
    }
}
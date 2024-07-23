namespace Solutions.Medium;

/// <summary>
/// We build a table of n rows (1-indexed). We start by writing 0 in the 1st row.
/// Now in every subsequent row, we look at the previous row and replace each occurrence of 0 with 01, and each occurrence of 1 with 10.
/// For example, for n = 3, the 1st row is 0, the 2nd row is 01, and the 3rd row is 0110.
/// Given two integer n and k, return the kth (1-indexed) symbol in the nth row of a table of n rows.
/// </summary>
public class KthSymbolinGrammar
{
    // n the number of rows
    // k the 1-k index from the last row
    public int KthGrammar(int n, int k)
    {
        // Solucion buena
        if (n == 1)
        {
            return 0;
        }

        var parent = KthGrammar(n - 1, (k + 2 - 1) / 2);
        var isEven = k % 2 == 0;

        if (parent == 0)
        {
            return isEven ? 1 : 0;
        }

        return isEven ? 0 : 1;

        // // Solución chota
        // if (n < 2)
        // {
        //     return 0;
        // }
        //
        // var replaceFunctionDictionary = new Dictionary<char, string>
        // {
        //     { '0', "01" },
        //     { '1', "10" }
        // };
        //
        // List<char>? previous = null;
        // for (int i = 0; i < n; i++)
        // {
        //     var newString = string.Empty;
        //     if (string.IsNullOrEmpty(previous?.ToString()))
        //     {
        //         previous = "0".ToList();
        //         continue;
        //     }
        //     
        //     previous.ForEach(x =>
        //     {
        //         newString += replaceFunctionDictionary[x];
        //     });
        //     
        //     previous = newString.ToList();
        // }
        //
        // return Convert.ToInt32(previous?[k-1].ToString());
    }
}
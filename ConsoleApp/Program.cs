// See https://aka.ms/new-console-template for more information

#region TwoSum Solution

using Solutions;

var twoSumTestCases = new Dictionary<int[], int>
{
    {
        new[] { 2, 7, 11, 15 }, 9
    },
    {
        new[] { 3, 2, 4 }, 6
    },
    {
        new[] { 3, 3 }, 6
    }
};

var twoSumSolution = new TwoSum();
foreach (var testCase in twoSumTestCases)
{
    var arrayResult = twoSumSolution.Solve(testCase.Key, testCase.Value);
    Console.WriteLine(
        $"First element {arrayResult[0]} = {testCase.Key[arrayResult[0]]}, and second element {arrayResult[1]} = {testCase.Key[arrayResult[1]]}");
}

#endregion

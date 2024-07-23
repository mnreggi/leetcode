// See https://aka.ms/new-console-template for more information
using Solutions;
using Solutions.Easy;
using Solutions.Medium;

#region TwoSum Solution
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

#region Palindrome Solution

var palindrome = new int[]
{
    121,
    -121,
    10,
    123454321
};

var palindromeSolution = new PalindromeNumber();
foreach (var number in palindrome)
{
    var result = palindromeSolution.IsPalindrome(number);
    Console.WriteLine($"{number} : {result}");
}

#endregion


#region RomanToInteger Solution

var romansStrings = new string[]
{
    "III",
    "LVIII",
    "MCMXCIV"
};

var romanToIntegerSolution = new RomanToInteger();
foreach (var roman in romansStrings)
{
    var result = romanToIntegerSolution.RomanToInt(roman);
    Console.WriteLine($"{roman} : {result}");
}

#endregion

#region LongestSubstringWithoutRepeatingCharacters Solution

var longestStrings = new string[]
{
    "abcabcbb",
    "bbbbb",
    "pwwkew"
};

var longestSolution = new LongestSubstringWithoutRepeatingCharacters();
foreach (var word in longestStrings)
{
    var result = longestSolution.LengthOfLongestSubstring(word);
    Console.WriteLine($"{word} : {result}");
}

#endregion


#region LongestPalindromicSubstring Solution

var longestPalindromeStrings = new string[]
{
    "babad",
    "cbbd",
    "abdcdba",
    "abcdcefec"
};

var longestPalindromeStringsSolution = new LongestPalindromicSubstring();
foreach (var word in longestPalindromeStrings)
{
    var result = longestPalindromeStringsSolution.LongestPalindrome(word);
    Console.WriteLine($"{word} : {result}");
}

#endregion

#region ZigzagConversion Solution

var zigzagStrings = new Dictionary<int, string>
{
    {
        3, "PAYPALISHIRING"
    },
    { 
        4, "PAYPALISHIRING"
    },
    {
        1, "A"
    }
};

var zigzagConversionSolution = new ZigzagConversion();
foreach (var word in zigzagStrings)
{
    var result = zigzagConversionSolution.Convert(word.Value, word.Key);
    Console.WriteLine($"{word} : {result}");
}

#endregion

#region ReverseInteger Solution

var reverseInteger = new int[]
{
    123,
    -123,
    120,
    1534236469,
    -2147483648
};

var reverseIntegerSolution = new ReverseInteger();
foreach (var number in reverseInteger)
{
    var result = reverseIntegerSolution.Reverse(number);
    Console.WriteLine($"{number} : {result}");
}

#endregion

#region ContainerWithMostWater Solution

var containerWithMostWater = new[]
{
    new[] {1,8,6,2,5,4,8,3,7},
    new[] {1,1}
};

var containerWithMostWaterSolution = new ContainerWithMostWater();
foreach (var numbers in containerWithMostWater)
{
    var result = containerWithMostWaterSolution.MaxArea(numbers);
    Console.WriteLine($"{numbers} : {result}");
}

#endregion

#region ContainerWithMostWater Solution

var uniquePathsSolution = new UniquePaths();
uniquePathsSolution.UniquePathsSolve(3, 7);

#endregion

#region ValidParentheses Solution

var validParenthesesStrings = new[]
{
    "",
    "(((((",
    "([{(",
    "]]]}}}",
    "()",
    "()[]{}",
    "(]",
    "((([]){}))",
    "((([]){}))(("
};

var validParenthesesSolution = new ValidParentheses();
foreach (var word in validParenthesesStrings)
{
    var result = validParenthesesSolution.IsValid(word);
    Console.WriteLine($"{word} : {result}");
}

#endregion

#region ValidParentheses Solution

var list1 = new MergeTwoSortedLists.ListNode(1,
    new MergeTwoSortedLists.ListNode(2, new MergeTwoSortedLists.ListNode(4)));

var list2 = new MergeTwoSortedLists.ListNode(1,
    new MergeTwoSortedLists.ListNode(3, new MergeTwoSortedLists.ListNode(4)));

var mergeTwoSortedListsSolution = new MergeTwoSortedLists();
mergeTwoSortedListsSolution.MergeTwoLists(list1, list2);

#endregion

#region RemoveDuplicatesFromSortedArray Solution

var removeDuplicatesFromSortedArray = new[]
{
    new [] {1,1,2},
    new [] {0,0,1,1,1,2,2,3,3,4}
};

var removeDuplicatesFromSortedArraySolution = new RemoveDuplicatesFromSortedArray();
foreach (var word in removeDuplicatesFromSortedArray)
{
    var result = removeDuplicatesFromSortedArraySolution.RemoveDuplicates(word);
    Console.WriteLine($"{word} : {result}");
}

#endregion

#region BinaryTreeInorderTraversal Solution

var root = new TreeNode
{
    Val = 1,
    Left = new TreeNode
    {
        Val = 2,
        Left = new TreeNode
        {
            Val = 3,
        },
        Right = new TreeNode
        {
            Val = 4,
        }
    },
    Right = new TreeNode
    {
        Val = 5
    }
};

var root2 = new TreeNode
{
    Val = 1,
    Right = new TreeNode
    {
        Val = 2,
        Left = new TreeNode
        {
            Val = 3
        }
    }
};


var binaryTreeInorderTraversalSolution = new BinaryTreeInorderTraversal();
binaryTreeInorderTraversalSolution.InorderTraversal(root2);

#endregion

#region sameTree Solution

var sameTreeArray = new TreeNode[]
{
    new TreeNode
    {
        Val = 1,
        Left = new TreeNode
        {
            Val = 2,
        },
        Right = new TreeNode
        {
            Val = 3
        }
    },
    new TreeNode
    {
        Val = 1,
        Left = new TreeNode
        {
            Val = 2,
        },
        Right = new TreeNode
        {
            Val = 3
        }
    }
};

var sameTreeSolution = new SameTree();
sameTreeSolution.IsSameTree(sameTreeArray[0], sameTreeArray[1]);

#endregion

#region ThreeSum Solution

var threeSumArray = new[]
{
    new [] {1,-1,-1,0},
    new [] {-1,0,1,2,-1,-4}, // -4, -1, -1, 0, 1, 2
    new [] {0,1,1},
    new [] {0,0,0}
};

var threeSumSolution = new ThreeSum();
foreach (var word in threeSumArray)
{
    var result = threeSumSolution.Solve(word);
    Console.WriteLine($"{word} : {result}");
}

#endregion

#region ThreeSum Solution

// [[1,2],[2,3],[5],[0],[5],[],[]]
var FindEventualSafeStatesArray = new[]
{
    new [] {1, 2},
    new [] {2, 3}, // -4, -1, -1, 0, 1, 2
    new [] {5},
    new [] {0},
    new [] {5},
    new int[] { },
    new int[] { }
};

var FindEventualSafeStatesSolution = new FindEventualSafeStates();
FindEventualSafeStatesSolution.EventualSafeNodes(FindEventualSafeStatesArray);

#endregion

#region ThreeSum Solution

// [[1,2],[2,3],[5],[0],[5],[],[]]
var KthSymbolinGrammarArray = new[]
{
    new [] {3, 1}, // 0
    new [] {2, 1}, // 0
    new [] {2, 2}, // 1
    new [] {5, 7}, // 0
    new [] {3, 3}  // 0
};

var KthSymbolinGrammarSolution = new KthSymbolinGrammar();
foreach (var word in KthSymbolinGrammarArray)
{
    var result = KthSymbolinGrammarSolution.KthGrammar(word[0], word[1]);
    Console.WriteLine($"{word} : {result}");
}

#endregion

#region ThreeSum Solution

// [[1,2],[2,3],[5],[0],[5],[],[]]
var MaximumScoreFromRemovingSubstringsArray = new[]
{
    new [] {3, 1}, // 0
    new [] {2, 1}, // 0
    new [] {2, 2}, // 1
    new [] {5, 7}, // 0
    new [] {3, 3}  // 0
};

var MaximumScoreFromRemovingSubstringsSolution = new MaximumScoreFromRemovingSubstrings();
MaximumScoreFromRemovingSubstringsSolution.MaximumGain("aabbaaxybbaabb", 5, 4);

#endregion

#region ThreeSum Solution

// [[1,2],[2,3],[5],[0],[5],[],[]]
var MinimumSidewayJumpsArray = new[]
{
    new [] {3, 1}, // 0
    new [] {2, 1}, // 0
    new [] {2, 2}, // 1
    new [] {5, 7}, // 0
    new [] {3, 3}  // 0
};

var MinimumSidewayJumpsSolution = new MinimumSidewayJumps();
MinimumSidewayJumpsSolution.MinSideJumps(new int[] {0,2,1,0,3,0});

#endregion

#region ThreeSum Solution

// [[1,2],[2,3],[5],[0],[5],[],[]]
var FindNearestPointArray = new[]
{
    new [] {3, 1}, // 0
    new [] {2, 1}, // 0
    new [] {2, 2}, // 1
    new [] {5, 7}, // 0
    new [] {3, 3}  // 0
};

var FindNearestPointSolution = new FindNearestPoint();
FindNearestPointSolution.NearestValidPoint(3, 4, new []
{
    new [] {1, 2}, // 0
    new [] {3, 1}, // 0
    new [] {2, 4}, // 0
    new [] {2, 3}, // 0
    new [] {4, 4}, // 0
});

#endregion

#region ThreeSum Solution

// [[1,2],[2,3],[5],[0],[5],[],[]]
var MinimumOperationsToMakeTheArrayIncreasingArray = new[]
{
    new [] {3, 1}, // 0
    new [] {2, 1}, // 0
    new [] {2, 2}, // 1
    new [] {5, 7}, // 0
    new [] {3, 3}  // 0
};

var MinimumOperationsToMakeTheArrayIncreasingSolution = new MinimumOperationsToMakeTheArrayIncreasing();
MinimumOperationsToMakeTheArrayIncreasingSolution.MinOperations(new []
{
    1,5,2,4,1
});

#endregion

#region ThreeSum Solution

// [[1,2],[2,3],[5],[0],[5],[],[]]
var CreateBinaryTreeFromDescriptionsArray = new[]
{
    new[] { 20, 15, 1 }, // 0
    new[] { 20, 17, 0 }, // 0
    new[] { 50, 20, 1 }, // 0
    new[] { 50, 80, 0 }, // 0
    new[] { 80, 19, 1 }, // 0
};

var CreateBinaryTreeFromDescriptionsSolution = new CreateBinaryTreeFromDescriptions();
CreateBinaryTreeFromDescriptionsSolution.CreateBinaryTree(CreateBinaryTreeFromDescriptionsArray);

#endregion
namespace Solutions.Easy;

/// <summary>
/// Given the root of a binary tree, return the inorder traversal of its nodes' values.
/// </summary>
public class BinaryTreeInorderTraversal
{
    /// <summary>
    /// 1- null?
    /// 2- 1 node
    /// 3- All left
    /// 4- All right
    /// 5- All 1
    /// </summary>
    /// <param name="root"></param>
    /// <returns></returns>
    public IList<int> InorderTraversal(TreeNode? root)
    {
        var result = new List<int>();
        var stack = new Stack<int>();

        if (root != null)
        {
            TakeNode(stack, root, result);
        }
        else
        {
            return ArraySegment<int>.Empty;
        }

        return result;
    }

    private void TakeNode(Stack<int> stack, TreeNode? node, IList<int> result)
    {
        if (node != null)
        {
            stack.Push(node.Val);
            TakeNode(stack, node.Left, result);
            result.Add(stack.Pop());
            TakeNode(stack, node.Right, result);
        }
    }
}

public class TreeNode {
    public int Val;
    public TreeNode? Left;
    public TreeNode? Right;
    
    public TreeNode(int val=0, TreeNode? left=null, TreeNode? right=null) 
    {
        Val = val;
        Left = left;
        Right = right;
    }
}

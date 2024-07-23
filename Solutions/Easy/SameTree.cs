namespace Solutions.Easy;

/// <summary>
/// Given the roots of two binary trees p and q, write a function to check if they are the same or not.
/// Two binary trees are considered the same if they are structurally identical, and the nodes have the same value.
/// </summary>
public class SameTree
{
        /// <summary>
        /// 1- 1 Shorter Tree
        /// 2- null and null = SAME
        /// 3- null and something - DIFFERENT
        /// 4- 1-1, 1-null-1 (All same numbers but one on the lef and the other one on the right)
        /// </summary>
        /// <param name="p"></param>
        /// <param name="q"></param>
        /// <returns></returns>
        public bool IsSameTree(TreeNode? p, TreeNode? q)
        {
            if (p == null && q != null || q == null && p != null)
            {
                return false;
            }
            
            return StackNodes(p, q);
        }

        private bool StackNodes(TreeNode? firstTree, TreeNode? secondTree)
        {
            if (firstTree != null && secondTree == null || firstTree == null && secondTree != null)
            {
                return false;
            }

            if (firstTree == null && secondTree == null)
            {
                return true;
            }
            return StackNodes(firstTree?.Left, secondTree?.Left) && StackNodes(firstTree?.Right, secondTree?.Right);
        }
}

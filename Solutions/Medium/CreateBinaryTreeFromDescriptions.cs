namespace Solutions.Medium;

public class CreateBinaryTreeFromDescriptions
{
    // [
    //  [20,15,1],
    //  [20,17,0],
    //  [50,20,1],
    //  [50,80,0],
    //  [80,19,1]
    // ]
    public TreeNode3 CreateBinaryTree(int[][] descriptions)
    {
        var hashMap = new Dictionary<int, TreeNode3>();
        foreach (var node in descriptions)
        {
            TreeNode3 parentNode;
            TreeNode3 childNode;
            
            // Check the parent
            if (hashMap.ContainsKey(node[0]))
            {
                parentNode = hashMap[node[0]];
            }
            else
            {
                parentNode = new TreeNode3(node[0]);
                hashMap[node[0]] = parentNode;
            }
            
            // Check Child
            if (hashMap.ContainsKey(node[1]))
            {
                childNode = hashMap[node[1]];
            }
            else
            {
                childNode = new TreeNode3(node[1]);
                hashMap[node[1]] = childNode;
            }
            
            // Check position
            if (node[2] == 1) // left
            {
                parentNode.left = childNode;
            }
            else
            {
                parentNode.right = childNode;
            }
            
            // if (hashMap.TryGetValue(node[0], out var value))
            // {
            //     if (node[2] == 1)
            //     {
            //         value.left = new TreeNode3(node[1]);
            //     }
            //     else
            //     {
            //         value.right = new TreeNode3(node[1]);
            //     }
            // }
            // else
            // {
            //     TreeNode3? leftNode = null;
            //     TreeNode3? rightNode = null;
            //     
            //     if (hashMap.ContainsKey(node[1]))
            //     {
            //         if (node[2] == 1)
            //         {
            //             leftNode = hashMap[node[1]];
            //         }
            //         else
            //         {
            //             rightNode = hashMap[node[1]];
            //         }
            //         
            //         hashMap[node[0]] = new TreeNode3
            //         {
            //             val = node[0],
            //             left = node[2] == 1 ? leftNode : null,
            //             right = node[2] == 0 ? rightNode : null
            //         };
            //     }
            //     else
            //     {
            //         hashMap[node[0]] = new TreeNode3
            //         {
            //             val = node[0],
            //             left = node[2] == 1 ? new TreeNode3(node[1]) : null,
            //             right = node[2] == 0 ? new TreeNode3(node[1]) : null
            //         };
            //     }
            // }
        }
        
        // Find the Root
        var childNodes = new List<int>();
        foreach (var treeNode in descriptions)
        {
            childNodes.Add(treeNode[1]);
        }

        TreeNode3? root = null;
        foreach (var treeNode in descriptions)
        {
            if (!childNodes.Contains(treeNode[0]))
            {
                root = hashMap[treeNode[0]];
            }
        }

        return root;
    }
}

public class TreeNode3 {
public int val;
public TreeNode3? left;
public TreeNode3? right;
public TreeNode3(int val=0, TreeNode3? left=null, TreeNode3? right=null) {
    this.val = val;
    this.left = left;
    this.right = right;
    }
}
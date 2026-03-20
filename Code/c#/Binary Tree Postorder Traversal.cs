//Given the root of a binary tree, return the postorder traversal of its nodes' values.

/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution {
    public IList<int> PostorderTraversal(TreeNode root) {
        
        List<int> result = new List<int>();
        PostOrderTraversal(root, result);

        return result;
    }

    public void PostOrderTraversal(TreeNode node, List<int> list)
    {
        if (node == null) return;

        //go left
        PostOrderTraversal(node.left, list);
        //go right
        PostOrderTraversal(node.right, list);
        //do something
        list.Add(node.val);

    }
}
//Given the root of a binary tree, return the preorder traversal of its nodes' values.

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
    public IList<int> PreorderTraversal(TreeNode root) {

        List<int> result = new List<int>();
        PreOrderTraversal(root, result);

        return result; 
    }

    public void PreOrderTraversal(TreeNode node, List<int> list) {

        if (node == null) return;

        //do something at the root
        list.Add(node.val);
        //go left
        PreOrderTraversal(node.left, list);
        //go right
        PreOrderTraversal(node.right, list);

    }
}
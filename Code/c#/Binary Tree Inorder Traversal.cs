//Given the root of a binary tree, return the inorder traversal of its nodes' values.

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
    public IList<int> InorderTraversal(TreeNode root)
    {      
        List<int> solution = new List<int>();
        InOrderTraversal(root, solution);

        return solution;
    }

    public void InOrderTraversal(TreeNode node, IList<int> list){

        if (node == null) return;

        //go to the left
        InOrderTraversal(node.left, list);

        //place value in list
        list.Add(node.val);

        //go to the right
        InOrderTraversal(node.right, list);
    }
}
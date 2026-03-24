/*
Given the root of a binary tree and an integer targetSum, return all root-to-leaf paths where the sum of the node values in the path equals targetSum. Each path should be returned as a list of the node values, not node references.

A root-to-leaf path is a path starting from the root and ending at any leaf node. A leaf is a node with no children.
*/


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
    List<IList<int>> result = new List<IList<int>>();
    List<int> currentPath = new List<int>();

    public IList<IList<int>> PathSum(TreeNode root, int targetSum) {

        PreOrderTraversal(root, 0, targetSum);
        return result;
    }

    void PreOrderTraversal(TreeNode node, int curr, int target) {
        if (node == null) return;
        
        //add current node to current path
        currentPath.Add(node.val);
        curr += node.val; //add its value to sum

        //check for leaf
        if (node.right == null && node.left == null) {
            //found a leaf
            //if the current sum equals the target, add the current path to the list of paths
            if (curr == target) result.Add(new List<int>(currentPath) );
        }
        //got to the left
        PreOrderTraversal(node.left, curr, target);
        //go to the right
        PreOrderTraversal(node.right,curr, target);

        //backTracking, Remove the current node from the list after going through its path
        currentPath.RemoveAt(currentPath.Count - 1);
        curr -= node.val; //remove value
    }
}
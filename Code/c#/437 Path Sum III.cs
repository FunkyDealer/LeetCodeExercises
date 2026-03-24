/*
Given the root of a binary tree and an integer targetSum, return the number of paths where the sum of the values along the path equals targetSum.

The path does not need to start or end at the root or a leaf, but it must go downwards (i.e., traveling only from parent nodes to child nodes).
*/

//Uses prefix sum + DFP/Preorder traversal

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

    //prefix Sum
    Dictionary<long, int> prefixSum = new Dictionary<long,int>();

    public int PathSum(TreeNode root, int targetSum) {      

        prefixSum.Add(0, 1);
        
        return PreOrderTraversal(root,0, targetSum);
    }

    int PreOrderTraversal(TreeNode node, long currSum, int targetSum) {
        if (node == null) return 0;        

        //do something       
        //prefix sum
        currSum += node.val;
        int res = prefixSum.GetValueOrDefault(currSum - targetSum, 0);
        prefixSum[currSum] = prefixSum.GetValueOrDefault(currSum, 0) + 1;        

        //go left
        res += PreOrderTraversal(node.left, currSum, targetSum);
        //go right
        res += PreOrderTraversal(node.right, currSum, targetSum);

        //backtracking
        prefixSum[currSum]--;
        return res;
    }
}
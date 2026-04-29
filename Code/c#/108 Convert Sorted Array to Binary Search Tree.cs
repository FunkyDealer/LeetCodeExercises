/*
Given an integer array nums where the elements are sorted in ascending order, convert it to a binary search tree.
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
    public TreeNode SortedArrayToBST(int[] nums) {
        if (nums.Length < 1) return null;

        TreeNode root = TreeBuilder(nums, 0, nums.Length - 1);

        return root;
    }
    
    TreeNode TreeBuilder(int[] nums, int min, int max)
    {
        if (min > max) return null;
        int mid = min + (max - min) / 2;

        TreeNode node = new TreeNode(nums[mid], null, null);
        //left
        node.left = TreeBuilder(nums, min, mid - 1);
        //right
        node.right = TreeBuilder(nums, mid + 1, max);

        return node;
    }
}
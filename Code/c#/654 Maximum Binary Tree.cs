/*
You are given an integer array nums with no duplicates. A maximum binary tree can be built recursively from nums using the following algorithm:

    Create a root node whose value is the maximum value in nums.
    Recursively build the left subtree on the subarray prefix to the left of the maximum value.
    Recursively build the right subtree on the subarray suffix to the right of the maximum value.

Return the maximum binary tree built from nums.
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
    public TreeNode ConstructMaximumBinaryTree(int[] nums) {

        return BuildTree(nums, 0, nums.Length);
    }

    private TreeNode BuildTree(int[] nums, int start, int len)
    {
        if (start == len) return null;

        //get highest value
        int max = GetHighestElement(nums, start, len);

        TreeNode node = new TreeNode(nums[max], null, null);

        node.left = BuildTree(nums, start, max);
        node.right = BuildTree(nums, max + 1, len);
   
        return node;
    }

    private int GetHighestElement(int[] nums, int start, int len) {

        int maxElement = start;
        int max = nums[start];

        for (int i = start + 1; i < len; i++) {
            if (nums[i] > max) {
                maxElement = i;
                max = nums[i];
            }
        }

        return maxElement;
    }
}
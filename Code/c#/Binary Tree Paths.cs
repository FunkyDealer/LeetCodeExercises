/*
Given the root of a binary tree, return all root-to-leaf paths in any order.

A leaf is a node with no children.
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

    public List<string> AllPaths = new List<string>();
    public List<string> CurrentPath = new List<string>();

    public IList<string> BinaryTreePaths(TreeNode root)
    {       
        PreOrderTraversal(root);

        return AllPaths;
    }

    public void PreOrderTraversal(TreeNode node) {

        //if the node is null, return
        if (node == null) return;
        
        //do something with the data
        //add current node value to the list
        CurrentPath.Add(node.val.ToString());

        //check if current node is a leaf (has no children)
        if (node.right == null && node.left == null)
        {
            //since this is a complete root-to-leaf path. add it to the results list
            AllPaths.Add(String.Join("->", CurrentPath));
        }
        else
        {
        //go to the left
        PreOrderTraversal(node.left);
        //go to the right
        PreOrderTraversal(node.right);
        }

        //Backtracking, Remove the current node from the list after going through its path
        CurrentPath.RemoveAt(CurrentPath.Count - 1);
    }
}
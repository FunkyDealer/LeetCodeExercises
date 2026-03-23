//Given the root of a binary tree, return the level order traversal of its nodes' values. (i.e., from left to right, level by level).


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
    public IList<IList<int>> LevelOrder(TreeNode root) {        
        List<IList<int>> result = new List<IList<int>>();
        if (root == null) return result;

        //create queue to place nodes in
        Queue<TreeNode> q = new Queue<TreeNode>();

        //place the root in the queue
        q.Enqueue(root);
        int currLevel = 0;

        //while the queue isn't empty
        while (q.Count > 0)
        {
            int len = q.Count; //get length of queue
            result.Add(new List<int>()); //create a new list for this level in the results
            
            //lets go throught each node on this level and switch them with their children
            for (int i = 0; i < len; i++) {
                //get node and remove it from the queue
                TreeNode node = q.Dequeue();

                //place node value in result
                result[currLevel].Add(node.val);

                //get left child
                if (node.left != null) {
                    //place it in the queue
                    q.Enqueue(node.left);
                }
                //get right child
                if (node.right != null) {
                    q.Enqueue(node.right);
                }
            }
            currLevel++;
        }
        return result;
    }
}
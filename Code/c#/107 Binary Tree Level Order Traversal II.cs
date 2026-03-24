//Given the root of a binary tree, return the bottom-up level order traversal of its nodes' values. (i.e., from left to right, level by level from leaf to root).

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
 //explanation: it's the same as a normal level order traversal
 //but we place each level at the top of the list to achieve bottom up level order
public class Solution {
    public IList<IList<int>> LevelOrderBottom(TreeNode root) {
        //result list
        List<IList<int>> result = new List<IList<int>>();
        if (root == null) return result;

        //create queue to place nodes in
        Queue<TreeNode> q = new Queue<TreeNode>();
        q.Enqueue(root);

        while (q.Count > 0)
        {
            int len = q.Count; //get length of queue
            List<int> level = new List<int>(); //level

              //lets go throught each node on this level and switch them with their children
            for (int i = 0; i < len; i++) {
                //get node and remove it from the queue
                TreeNode node = q.Dequeue();

                //place node value in result
                level.Add(node.val);

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

            result.Insert(0, level);
        }

        return result;
    }
}
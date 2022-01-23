using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace apps.Trees
{
    internal class postorder_tree_traversal
    {
        public class TreeNode
        {
            public int val;
            public TreeNode left;
            public TreeNode right;
            public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
            {
                this.val = val;
                this.left = left;
                this.right = right;
            }
        }
        #region postorder_tree_traversal_recursion
        public static List<int> result = new List<int>();

           public IList<int> postorder_tree_recusion(TreeNode root)
            {
                result.Clear();
                if (root == null) return result;
                postorder(root);
                return result;

            }

        public static void postorder(TreeNode root)
        {
            if (root.left != null) postorder(root.left);
            if (root.right != null) postorder(root.right);
            result.Add(root.val);

        }

        #endregion


        #region postorder_tree_traversal_Iterative


        public IList<int> PostorderTraversal(TreeNode root)
            {
                List<int> result = new List<int>();
                if (root == null) return result;

                Stack<TreeNode> s = new Stack<TreeNode>();
                s.Push(root);

                while (s.Count() != 0)
                {
                    TreeNode node = s.Pop();
                    result.Add(node.val);

                    if (node.left != null) s.Push(node.left);
                    if (node.right != null) s.Push(node.right);

                }

                result.Reverse();
                return result;

            }
      


        #endregion




    }
}

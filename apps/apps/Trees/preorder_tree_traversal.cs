using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace apps
{
    internal class preorder_tree_traversal
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
        #region preorder_tree_traversal_recursion
        public static List<int> result = new List<int>();
        /// <summary>
        /// Preorder Tree traversal using recurrsions
        /// </summary>
        /// <returns></returns>
        /// 
        public static List<int> preoder_tree_recusion(TreeNode root)
        {
            result.Clear();
            if (root == null) return result;
            preorder(root);
            return result;

        }

        public static void preorder(TreeNode root)
        {
            result.Add(root.val);
            if (root.left != null) preorder(root.left);
            if (root.right != null) preorder(root.right);
            int[] a = new int[23];
            int a1 = a.Length;


        }

        #endregion

        #region preorder_tree_traversal_iterative


        public IList<int> PreorderTraversal(TreeNode root)
            {
                List<int> result = new List<int>();
                if (root == null) return result;

                Stack<TreeNode> s = new Stack<TreeNode>();
                s.Push(root);

                while (s.Count() != 0)
                {
                    TreeNode node = s.Pop();
                    result.Add(node.val);

                    if (node.right != null) s.Push(node.right);
                    if (node.left != null) s.Push(node.left);

                }

                return result;

            }
       


        #endregion


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace apps
{
    internal class inorder_tree_traversal
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

        #region inorder_tree_traversal_recursion

        public static List<int> result = new List<int>();
        /// <summary>
        /// Inorder Tree traversal using recurrsions
        /// </summary>
        /// <returns></returns>
        
        public static List<int> inodertree_recursion()

        {
            TreeNode root = new TreeNode();
            result.Clear();
            inorder(root);

            return result;

        }

        public static void inorder(TreeNode root)

        {
            if (root.left != null) inorder(root.left);
            result.Add(root.val);
            if (root.right != null) inorder(root.right);

        }
        #endregion




        #region inorder_tree_traversal_iterative
        /// <summary>
        ///
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public IList<int> InorderTraversal(TreeNode root)
            {
                List<int> result = new List<int>();
                if (root == null) return result;
                Stack<TreeNode> s = new Stack<TreeNode>();

                //s.Push(root);
                TreeNode node = root;
                while (s.Count() != 0 || node != null)
                {

                    if (node != null)
                    {
                        s.Push(node);
                        node = node.left;
                    }
                    else
                    {
                        node = s.Pop();
                        result.Add(node.val);
                        node = node.right;
                    }

                }


                return result;


            }

        #endregion


    }
}

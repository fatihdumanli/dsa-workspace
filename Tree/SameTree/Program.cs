﻿using System;

namespace SameTree
{
    class TreeNode
    {
        public TreeNode left;
        public TreeNode right;
        public int val;

        public TreeNode(int val)
        {
            this.val = val;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var treeNode = new TreeNode(1);
            treeNode.left = new TreeNode(2);

            var treeNode2 = new TreeNode(1);
            treeNode2.right = new TreeNode(2);
         

            var result = IsSameTree(treeNode, treeNode2);
        }

        private static bool IsSameTree(TreeNode p, TreeNode q)
        {
            if (p == null && q == null)
                return true;

            if (p == null || q == null)
                return false;

            return IsSameTree(p.left, q.left) && IsSameTree(p.right, q.right) && p.val == q.val;
        }
    }
}
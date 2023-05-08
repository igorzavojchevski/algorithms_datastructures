using AL_DS_Lib.LeetCode.Common;

namespace AL_DS_Lib.LeetCode
{
    public class _0104_MaximumDepthOfBinaryTree
    {
        public int MaxDepth(TreeNode root)
        {
            if (root == null) return 0;

            int leftDepth = MaxDepth(root.left);
            int rightDepth = MaxDepth(root.right);

            if (leftDepth > rightDepth) return leftDepth + 1;
            else return rightDepth + 1;
        }
    }
}

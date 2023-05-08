using AL_DS_Lib.LeetCode.Common;

namespace AL_DS_Lib.LeetCode
{
    internal class _0938_RangeSumOfBST
    {
        public int RangeSumBST(TreeNode root, int low, int high)
        {
            if (root == null) return 0;
            if (root.val < low) return RangeSumBST(root.right, low, high);
            else if (root.val > high) return RangeSumBST(root.left, low, high);
            else return root.val + RangeSumBST(root.left, low, high) + RangeSumBST(root.right, low, high);
        }
    }
}

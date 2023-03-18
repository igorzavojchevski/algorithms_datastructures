using AL_DS.LeetCode.Common;

namespace AL_DS.LeetCode
{
    public class _0653_TwoSumIV_InputIsABST
    {
        HashSet<int> hashSet = new HashSet<int>();
        public bool FindTarget(TreeNode root, int k)
        {
            if (root is null) return false;

            if (hashSet.Contains(k - root.val)) return true;
            hashSet.Add(root.val);

            return FindTarget(root.left, k) || FindTarget(root.right, k);
        }
    }
}

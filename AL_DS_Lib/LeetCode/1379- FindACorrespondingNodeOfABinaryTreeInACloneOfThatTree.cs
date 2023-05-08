using AL_DS_Lib.LeetCode.Common;

namespace AL_DS_Lib.LeetCode
{
    public class _1379_FindACorrespondingNodeOfABinaryTreeInACloneOfThatTree
    {
        public TreeNode GetTargetCopy(TreeNode original, TreeNode cloned, TreeNode target)
        {
            if (original == null || original == target) return cloned;
            TreeNode answer = GetTargetCopy(original.left, cloned.left, target);
            if (answer != null) return answer;
            return GetTargetCopy(original.right, cloned.right, target);
        }
    }
}

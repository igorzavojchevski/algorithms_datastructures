using AL_DS.LeetCode.Common;

namespace AL_DS.LeetCode
{
    public class _0094_BinaryTreeInorderTraversal
    {
        private IList<int> _result;
        public IList<int> InorderTraversal(TreeNode root)
        {
            _result = new List<int>();
            TraverseWithInorder(root);
            return _result;
        }

        private void TraverseWithInorder(TreeNode root)
        {
            if (root != null)
            {
                TraverseWithInorder(root.left);
                _result.Add(root.val);
                TraverseWithInorder(root.right);
            }
        }
    }


}

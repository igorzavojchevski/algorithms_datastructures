using System.Text;

namespace AL_DS_Lib.LeetCode
{
    public static class _0022_GenerateParentheses
    {
        public static IList<string> GenerateParenthesis(int n)
        {
            List<String> ans = new List<String>();
            Backtrack(ans, new StringBuilder(), 0, 0, n);
            return ans;
        }

        public static void Backtrack(List<String> ans, StringBuilder cur, int open, int close, int max)
        {
            if (cur.Length == max * 2)
            {
                ans.Add(cur.ToString());
                return;
            }

            if (open < max)
            {
                cur.Append("(");
                Backtrack(ans, cur, open + 1, close, max);
                cur.Remove(cur.Length - 1, 1);
            }
            if (close < open)
            {
                cur.Append(")");
                Backtrack(ans, cur, open, close + 1, max);
                cur.Remove(cur.Length - 1, 1);
            }
        }
    }
}

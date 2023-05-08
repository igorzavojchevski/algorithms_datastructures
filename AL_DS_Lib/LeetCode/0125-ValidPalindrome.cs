namespace AL_DS_Lib.LeetCode
{
    public static class _0125_ValidPalindrome
    {
        public static bool IsPalindrome(string s)
        {
            for (int i = 0, j = s.Length - 1; i < j; i++, j--)
            {
                while (i < j && !char.IsLetterOrDigit(s[i]))
                {
                    i++;
                }
                while (i < j && !char.IsLetterOrDigit(s[j]))
                {
                    j--;
                }

                if (char.ToLower(s[i]) != char.ToLower(s[j]))
                    return false;
            }

            return true;
        }
    }
}

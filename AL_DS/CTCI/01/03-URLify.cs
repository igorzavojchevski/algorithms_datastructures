namespace AL_DS.CTCI._01
{
    public static class _03_URLify
    {
        //
        public static void ReplaceSpaces(string s, int trueLength)
        {
            s = s.TrimEnd();
            for (int i = 0; i < trueLength; i++)
            {
                if (s[i] == ' ')
                {
                    s = s.Substring(0, i) + "%20" + s.Substring(i + 1);
                }
            }
        }
    }
}

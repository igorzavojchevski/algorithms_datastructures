namespace AL_DS.LeetCode
{
    public class _0735_AsteroidCollision
    {
        public int[] AsteroidCollision(int[] asteroids)
        {
            Stack<int> ans = new Stack<int>();
            for (int i = 0; i < asteroids.Length; i++)
            {
                if (ans.Count == 0 || asteroids[i] > 0)
                {
                    ans.Push(asteroids[i]);
                }
                else
                {
                    while (ans.Count != 0 && ans.Peek() > 0 && ans.Peek() < Math.Abs(asteroids[i]))
                    {
                        ans.Pop();
                    }
                    if (ans.Count != 0 && ans.Peek() == Math.Abs(asteroids[i]))
                    {
                        ans.Pop();
                    }
                    else if (ans.Count == 0 || ans.Peek() < 0)
                    {
                        ans.Push(asteroids[i]);
                    }
                }
            }
            return ans.ToArray().Reverse().ToArray();
        }
    }
}

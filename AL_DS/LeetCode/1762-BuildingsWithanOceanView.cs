namespace AL_DS.LeetCode
{
    public class _1762_BuildingsWithanOceanView
    {
        public int[] FindBuildings(int[] heights)
        {
            Stack<int> buildings = new Stack<int>();

            for (int i = heights.Length - 1; i >= 0; i--)
            {
                if (!buildings.Any() || heights[i] > heights[buildings.Peek()])
                {
                    buildings.Push(i);
                }
            }

            return buildings.ToArray();
        }
    }
}

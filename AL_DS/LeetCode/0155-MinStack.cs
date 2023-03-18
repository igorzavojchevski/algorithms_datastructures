namespace AL_DS.LeetCode
{
    public class Item
    {
        public int val;
        public Item nextMin;
        public Item(int v, Item min)
        {
            val = v;
            nextMin = min;
        }
    }

    public class _0155_MinStack
    {
        List<Item> ls;
        Item minimum;
        public _0155_MinStack()
        {
            ls = new List<Item>();
            minimum = null;
        }

        public void Push(int val)
        {
            Item item;
            if (minimum == null || minimum.val >= val)
            {
                item = new Item(val, minimum);
                minimum = item;
            }
            else
            {
                item = new Item(val, null);
            }
            ls.Add(item);
        }

        public void Pop()
        {
            if (ls[ls.Count - 1] == minimum)
                minimum = ls[ls.Count - 1].nextMin;

            ls.Remove(ls[ls.Count - 1]);
        }

        public int Top()
        {
            return ls[ls.Count - 1].val;
        }

        public int GetMin()
        {
            return minimum.val;
        }

        /**
         * Your MinStack object will be instantiated and called as such:
         * MinStack obj = new MinStack();
         * obj.Push(val);
         * obj.Pop();
         * int param_3 = obj.Top();
         * int param_4 = obj.GetMin();
         */
    }
}

namespace AL_DS.LeetCode
{
    public static class _0875_KokoEatingBananas
    {
        public static int MinEatingSpeed(int[] piles, int h)
        {
            int left = 1;
            int right = piles.Max();

            while (left < right)
            {
                int mid = (left + right) / 2;

                bool isWorkable = IsWorkable(piles, h, mid);

                if (isWorkable)
                    right = mid;
                else
                    left = mid + 1;
            }

            return right;
        }

        private static bool IsWorkable(int[] piles, int h, int speed)
        {
            double hours = 0;
            foreach (int pile in piles)
            {
                hours += Math.Ceiling((double)pile / speed);
            }
            return hours <= h;
        }

        //public static int MinEatingSpeed(int[] piles, int h)
        //{
        //    int left = 1;
        //    int right = piles.Max();

        //    while (left < right)
        //    {
        //        double hours = 0;
        //        int mid = (left + right) / 2;

        //        foreach (int pile in piles)
        //        {
        //            hours += Math.Ceiling((double)pile / mid);
        //        }

        //        if (hours <= h)
        //        {
        //            right = mid;
        //        }
        //        else
        //        {
        //            left = left + 1;
        //        }
        //    }

        //    return right;
        //}
    }
}

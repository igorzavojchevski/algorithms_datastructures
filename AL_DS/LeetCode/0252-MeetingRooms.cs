namespace AL_DS.LeetCode
{
    public static class _0252_MeetingRooms
    {
        public static bool CanAttendMeetings(int[][] intervals)
        {
            Array.Sort(intervals, (x, y) => x[0].CompareTo(y[0]));

            for (int i = 0; i < intervals.Length - 1; i++)
            {
                if (intervals[i][1] > intervals[i + 1][0])
                    return false;
            }
            return true;
        }
    }
}

//namespace LeetCode.LeetCode
//{
//    public static class _0853_CarFleet
//    {
//        public static int CarFleet(int target, int[] position, int[] speed)
//        {
//            //REVIEW AGAIN
//            int n = position.Length;
//            int counter = 0;
//            float time = 0;
//            // Iterate through each car starting from the last one
//            for (int i = n - 1; i >= 0; i--)
//            {
//                // Calculate time for the current car to reach the destination
//                float t = (float)(target - position[i]) / speed[i];
//                // If the current car's time is greater than the last car's time, it's a new fleet
//                if (t > time)
//                {
//                    counter++;
//                    time = t;
//                }
//            }
//            return counter;
//        }
//    }
//}

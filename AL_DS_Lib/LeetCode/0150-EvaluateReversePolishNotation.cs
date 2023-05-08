namespace AL_DS_Lib.LeetCode
{
    public static class _0150_EvaluateReversePolishNotation
    {
        //tokens = ["2","1","+","3","*"]
        private static int Sum(int a, int b) => a + b;
        private static int Sub(int a, int b) => a - b;
        private static int Mul(int a, int b) => a * b;
        private static int Div(int a, int b) => a / b;

        public static int EvalRPN(string[] tokens)
        {
            var actions = new Dictionary<string, Func<int, int, int>>
            {
                { "+", Sum },
                { "-", Sub },
                { "*", Mul },
                { "/", Div },
            };

            Stack<int> stack = new Stack<int>();

            foreach (string token in tokens)
            {
                if (!int.TryParse(token, out int n))
                {
                    int b = stack.Pop();
                    int a = stack.Pop();

                    Func<int, int, int> action = actions[token];

                    int result = action(a, b);

                    stack.Push(result);

                    continue;
                }

                stack.Push(n);
            }

            return stack.Pop();
        }
    }
}

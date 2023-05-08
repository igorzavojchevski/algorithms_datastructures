namespace AL_DS_Lib.LeetCode
{
    //Two Stacks implementation
    public class _1472_DesignBrowserHistory
    {
        Stack<string> backwardStack = new Stack<string>();
        Stack<string> forwardStack = new Stack<string>();
        string currentPage = string.Empty;

        public _1472_DesignBrowserHistory(string homepage)
        {
            backwardStack = new Stack<string>();
            forwardStack = new Stack<string>();
            currentPage = homepage;
        }

        public void Visit(string url)
        {
            backwardStack.Push(currentPage);
            forwardStack = new Stack<string>();
            currentPage = url;
        }

        public string Back(int steps)
        {
            if (backwardStack == null || !backwardStack.Any()) return currentPage;
            while (backwardStack.Any() && steps > 0)
            {
                forwardStack.Push(currentPage);
                currentPage = backwardStack.Pop();
                steps--;
            }
            return currentPage;
        }

        public string Forward(int steps)
        {
            if (forwardStack == null || !forwardStack.Any()) return currentPage;
            while (forwardStack.Any() && steps > 0)
            {
                backwardStack.Push(currentPage);
                currentPage = forwardStack.Pop();
                steps--;
            }
            return currentPage;
        }
    }

    /**
     * Your BrowserHistory object will be instantiated and called as such:
     * BrowserHistory obj = new BrowserHistory(homepage);
     * obj.Visit(url);
     * string param_2 = obj.Back(steps);
     * string param_3 = obj.Forward(steps);
     */
}

namespace assignment_one
{
    class SubString
    {
        public static void subString(string str, int n)
        {
            // Pick starting point
            for (int len = 1; len <= n; len++)
            {
                // Pick ending point
                for (int i = 0; i <= n - len; i++)
                {
                    // Print characters
                    // from current
                    // starting point to
                    // current ending
                    // point.
                    int j = i + len - 1;

                    for (int k = i; k <= j; k++) 
                    System.Console.Write(str[k]);
                    System.Console.WriteLine();
                }
            }
        }
    }
}

using System;

namespace assignment_one
{
    public class Palindrome
    {
        public static void palendrome(string input)
        {
            string upperInput = input;
            string lowerInput = input;
            Reverse.reverse(upperInput);
            Reverse.reverse(lowerInput);
            if (upperInput == input)
            {
                System.Console.WriteLine($"The string {input} is palendrome ");
            }
            else if (lowerInput == input){
                System.Console.WriteLine($"The sting {input} is palendrome");
            }
            else {
                System.Console.WriteLine($"The stirng {input} is not palendrome");
            }
        }
        public static bool isPalendrome(string input)
        {
            string input_lower = input;
            input_lower.ToLower();
            string input_upper = input;
            input_upper.ToUpper();
            for (int i = 0; i < (input.Length / 2); i++)
            {
                if (input[i] != input[input.Length - 1 - i])
                {
                    System.Console.WriteLine($"The string {input} is not palendrome ");
                    return false;
                }
                else if (input_lower[i] != input_lower[input_lower.Length - 1 - i])
                {
                    return false;
                }
                else
                {
                    return false;
                }
            }
            System.Console.WriteLine($"The string {input} is palendrome ");
            return true;
        }
    }
}

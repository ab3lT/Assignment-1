using System;

namespace assignment_one
{
    public class Palindrome
    {
       public static void palendrome(string revString, string input)
        {
            string upperInput = input.ToUpper();
            string lowerInput = input.ToLower();
        
            if (revString == input)
            {
                input.ToUpper();
                if (revString == input)
                {
                    input.ToLower();
                    if (revString == input)
                    {
                        Console.WriteLine($"String is Palindrome \n Entered String Was {input} and reverse string is {revString}");
                    }
                }
            }
            else
            {
                Console.WriteLine($"String is not Palindrome \n Entered String Was {input} and reverse string is {revString}", input, revString);
            }
        }
        public static bool isPalendrome(string input)
        {
            
            for (int i = 0; i < (input.Length / 2); i++)
            {
                if (input[i] != input[input.Length - 1 - i])
                {
                    System.Console.WriteLine($"The string {input}is not palendrome ");
                    return false;
                }
            }
            
            System.Console.WriteLine($"The string {input} is palendrome ");
            return true;
    }
    }
}
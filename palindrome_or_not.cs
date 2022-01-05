using System;

namespace assignment_one
{
    public class Palindrome{
        public void palendrome(string revString, string input)
        {
            if  (revString == input) {  
                Console.WriteLine("String is Palindrome \n Entered String Was {0} and reverse string is {1}", input, revString);  
            }  
            else  
            {  
                Console.WriteLine("String is not Palindrome \n Entered String Was {0} and reverse string is {1}", input, revString);  
            }  
        }
    }

}
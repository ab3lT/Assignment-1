using System;
using static assignment_one.Palindrome;
namespace assignment_one
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string revString = "";
            string input;
           
            Console.Write("Enter string : ");
            input = Console.ReadLine();
            
            for(int i=input.Length-1; i>=0; i--){
                revString = revString + input[i];
            }
            
            Console.WriteLine($"Reverse String is : {revString}");
            
            Palindrome pal = new Palindrome();
            pal.palendrome(revString, input);
         
            Console.WriteLine("The program excuted perfectly!!");
        }
    }
}

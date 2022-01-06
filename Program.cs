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
            Menu.menu();
            Time.SetTimer();
            Console.Write("Enter string : ");
            Time.SetTimer();
            input = Console.ReadLine();
            Reverse.reverse(input);
            
            Palindrome.palendrome(revString, input);

            Console.WriteLine("The program excuted perfectly!!");
        }
    }
}

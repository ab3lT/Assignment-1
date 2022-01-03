using System;

namespace assignment_one
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            string revString = "";
            Console.Write("Enter string : ");
            input = Console.ReadLine();
            /* input = input.ToLower(); */
            for(int i=input.Length-1; i>=0; i--){
                revString = revString + input[i];
            }
            
            Console.WriteLine($"Reverse String is : {revString}");
            /* if(input==revString)
            {
                Console.WriteLine("\nString is palindrome");
            }
            else
                Console.WriteLine("\nString not palindrome."); */
         
            Console.WriteLine("The program excuted perfectly!!");
        }
    }
}

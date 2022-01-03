using System;

namespace assignment_one
{
    class Program
    {
        static void Main(string[] args)
        {
            string revString = "";
            string input;
            Console.Write("Enter string : ");
            input = Console.ReadLine();
            
            for(int i=input.Length-1; i>=0; i--){
                revString = revString + input[i];
            }
            
            Console.WriteLine($"Reverse String is : {revString}");
            
         
            Console.WriteLine("The program excuted perfectly!!");
        }
    }
}

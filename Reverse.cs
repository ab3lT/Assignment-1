using System;

namespace assignment_one
{
    class Reverse{
        public static void reverse(string input){
            
            string revString = "";
            for(int i=input.Length-1; i>=0; i--){
                revString = revString + input[i];
            }
            
            Console.WriteLine($"Reverse String is : {revString}");
            
        }
    }
}
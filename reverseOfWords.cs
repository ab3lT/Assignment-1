using System;
using System.Timers;
using System.Runtime.InteropServices;

namespace assignment_one{
    class Reverse_Word{
        public static void Wordor(){
            int length;
            string rev= "";
            Console.Write("Inpute Your Sentence : ");
            string sent = Console.ReadLine();

            length = sent.Length -1;
            while(length>=0)
            {
                rev = rev + sent[length];
                length --;

            }
            Console.WriteLine("\n_________________________________\n\n>>> the reverse of "+ sent+ " is => \n" + rev +" <<<\n_________________________________");
            
            }
    }
}
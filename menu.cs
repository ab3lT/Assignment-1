using System;
using System.Timers;
using System.Runtime.InteropServices;

namespace assignment_one
{
    public class Menu
    {
        public static void menu()
        {
            Time.SetTimer(4000);
            System.Console.WriteLine("=======================================");
            System.Console.WriteLine("      Wellcome to OOP II project      ");
            System.Console.WriteLine("=======================================");
            var Choice = (string)null;
            var menuChoice = Choice;
            menuList();
            Console.Write("Please Enter your choice number : ");
            menuChoice = Console.ReadLine();
            menuListChoice(menuChoice);
        }

        private static void menuList()
        {
            System.Console.WriteLine("=======================================================");
            System.Console.WriteLine("      Please enter the number to the project you went.");
            System.Console.WriteLine("=======================================================");
            System.Console.WriteLine("1|    To reverse a string");
            Time.SetTimer(500000);
            System.Console.WriteLine("2|    To find if the given string is a palindrome or not");
            Time.SetTimer(500000);
            System.Console.WriteLine("3|    To reverse the order of words in a given string");
            Time.SetTimer(5000);
            System.Console.WriteLine("4|    To count the occurrence of each character in a string");
            Time.SetTimer(5000);
            System.Console.WriteLine("5|    To find all possible substrings of a given string");
            Time.SetTimer(5000);
            System.Console.WriteLine("6|    TO find the second largest integer in an array");
            Time.SetTimer(5000);
            System.Console.WriteLine(
                "7|    To tonvert a two-dimensional array to a one-dimensional array"
            );
            Time.SetTimer(2000);
            System.Console.WriteLine(
                "8|    To find the angle between hour and minute hands of a clock at any given time"
            );
            Time.SetTimer(2000);
        }

        public static void menuListChoice(string menuChoice)
        {
            if (menuChoice == "1")
            {
                Time.SetTimer(5000);
                System.Console.WriteLine("=======================================");
                System.Console.WriteLine(" ||     To reverse a string     ||");
                System.Console.WriteLine("=======================================");
                Console.Write("Please Enter string : ");
                string input = Console.ReadLine();
                Reverse.reverse(input);
                Time.SetTimer(5000);
                Menu.meauAgain();
            }
            else if (menuChoice == "2")
            {
                Time.SetTimer(5000);
                System.Console.WriteLine("=======================================");
                System.Console.WriteLine(" ||     To reverse a string     ||");
                System.Console.WriteLine("=======================================");
                Console.Write("Please Enter string : ");
                string input = Console.ReadLine();
                Palindrome.palendrome(input);
                Time.SetTimer(5000);
                Menu.meauAgain();
            }
            else if (menuChoice == "3")
            {
                
                Reverse_Word.Wordor();
                Menu.meauAgain();   
            }
            else if (menuChoice == "4")
            {
                System.Console.WriteLine(
                    "============================================================="
                );
                System.Console.WriteLine(
                    " ||    To count the occurrence of each character in a string."
                );
                System.Console.WriteLine(
                    "=============================================================="
                );
                System.Console.Write("write a string => ");
                string str = Console.ReadLine();
                Ocurrence.Occurrence(str);
                Menu.meauAgain();
            }
            else if (menuChoice == "5")
            {
                Time.SetTimer(5000);
                System.Console.WriteLine(
                    "==========================================================="
                );
                System.Console.WriteLine(
                    " ||     find all possible substrings of a given string    "
                );
                System.Console.WriteLine(
                    "==========================================================="
                );

                Console.Write("Please Enter string : ");
                string str = Console.ReadLine();
                SubString.subString(str, str.Length);
                System.Console.WriteLine(
                    "==========================================================="
                );
                System.Console.WriteLine("");
                System.Console.WriteLine(
                    "==========================================================="
                );
                Menu.meauAgain();
            }
            else if (menuChoice == "6")
            {
                LargersIntiger.largint();

                Menu.meauAgain();
            }
            else if (menuChoice == "7")
            {
                Dimancaion.conversion();

                Menu.meauAgain();
            }
            else if (menuChoice == "8")
            {
                Angle.hourmun();
                Menu.meauAgain();
            }
        }

        private static void meauAgain()
        {
            System.Console.WriteLine("Do you went to retrun to menu ??");
            System.Console.WriteLine("To retrun to the menu write yes !");
            System.Console.Write("To exit the application please write any thing.:");

            System.Console.Write("=> ");
            string input = System.Console.ReadLine();
            if (input == "yes" ^ input == "Yes" ^ input == "y" ^ input =="1")
            {
                menu();
            }
            else
            {
                System.Console.WriteLine("the application is closed sucessfully.");
                Environment.Exit(0);
            }
        }
    }
}

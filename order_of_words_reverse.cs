using System;

namespace Assignment_1
{
    public class order_of_words_reverse
    {
        public static string[] reverse(string[] input)
        {
            if (input is null)
            {
                throw new ArgumentNullException(nameof(input));
            }
            string temp;
            int j = input.Length - 1;
            for (int i = 0; i < j; i++)
            {
                temp = input[i];
                input[i] = input[j];
                input[j] = temp;
                j--;
            }
            return input;
        }
        static void DisplayArrayValues(string[] input)
        {
            if (input is null)
            {
                throw new ArgumentNullException(nameof(input));
            }
            for (int i = 0; i < input.Length; i++)
                Console.Write(input[i] + " ");
            Console.WriteLine();
        }
    }
}

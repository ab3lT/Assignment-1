using System;

namespace assignment_one
{
    class Ocurrence
    {
        public static void Occurrence(string str)
        {
            Console.WriteLine("String: " + str);
            str = str.Replace(" ", string.Empty);
            while (str.Length > 0)
            {
                Console.Write(str[0] + " => ");
                int coccurance = 0;
                for (int i = 0; i < str.Length; i++)
                {
                    if (str[0] != str[i] || str[0] == str[i])
                    {
                        coccurance++;
                    }
                }
                Console.WriteLine (coccurance);
                str = str.Replace(str[0].ToString(), string.Empty);
            }
        }
    }
}

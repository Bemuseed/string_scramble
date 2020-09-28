using System;

namespace string_scramble
{
    class Program
    {
        static string Scramble(string str)
        {
            bool odd = false;
            if (str.Length % 2 != 0)
            {
                odd = true;
                char last = str[-1];
                str = str.Substring(0, str.Length - 1);
            }
            for (int i = 0; i < str.Length; i+=2)
            {
                string scrampair = str[i + 1] + str[i];
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the message to be scrambled:  ");
            string origin = Console.ReadLine();
            string scramstr = Scramble(origin);
            Console.WriteLine("\n" + scramstr);
            
        }
    }
}

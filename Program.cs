using System;

namespace GetVowels
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputString;
            char ch;

            Console.Write("Enter a letter: ");
            inputString = Console.ReadLine().ToUpper();
            ch = Convert.ToChar(inputString);

            while(ch=='A' || ch=='E' || ch=='I' || ch=='O' || ch=='U')
            {
                Console.WriteLine("{0} is a vowel!", ch);

                Console.Write("Enter a letter: ");
                inputString = Console.ReadLine().ToUpper();
                ch = Convert.ToChar(inputString);

            }

            Console.WriteLine("{0} is not a vowel!", ch);

        }
    }
}

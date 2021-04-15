using System;

namespace projektz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("enter number of arrays: ");
            string input = Console.ReadLine();
            int arraysize = Convert.ToInt32(input);
            int[] skaitli = new int[arraysize];
            string sep = "";
            for (int i = 0; i < arraysize; i++)
            {
                Console.Write("which number u select?: ");
                string userInput = Console.ReadLine();
                int secondInput = Convert.ToInt32(userInput);
                skaitli[i] = secondInput;

            }
            for (int i = 0; i < arraysize; i++)
                if (skaitli[i] != 0)
                {

                    Console.Write(skaitli[i]);
                    sep = ",";
                    Console.Write(sep);
                }
            sep = "";
            for (int i = 0; i < arraysize; i++)
                if (skaitli[i] == 0)
                {
                    Console.Write(sep);
                    Console.Write(skaitli[i]);
                    sep = ",";
                }



        }
    }
}

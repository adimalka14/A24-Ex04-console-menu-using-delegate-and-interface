using Ex04.Menus.Interfaces;
using System;

namespace Ex04.Menus.Test
{
    public class CountCapitals : IExecuteLeafAction
    {
        public void ExecuteLeafAction()
        {
            CountCapitalsLetters();
        }

        public static void CountCapitalsLetters()
        {
            string userInput;
            int countOfCapitalLetters = 0;

            Console.WriteLine("Please enter your sentence:");
            userInput = Console.ReadLine();
            foreach (char capitals in userInput)
            {
                if (char.IsLetter(capitals) && char.IsUpper(capitals))
                {
                    countOfCapitalLetters++;
                }
            }

            Console.WriteLine($"There are {countOfCapitalLetters} Letters are in the sentence...\n");
        }
    }
}
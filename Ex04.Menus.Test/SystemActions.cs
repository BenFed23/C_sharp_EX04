using Ex04.Menus.Events;
using System;
using System.Collections.Generic;



namespace Ex04.Menus.Test
{
    public class SystemActions
    {
        public void CurrentMenu_UserChoseShowTime(ActionMenu i_CurrentMenu)
        {
            Console.Clear();
            DateTime currentTime = DateTime.Now;
            Console.WriteLine($"> Current Time is {currentTime:HH:mm:ss}");
            returnToMenuMessage();
        }

        public void CurrentMenu_UserChoseShowDate(ActionMenu i_CurrentMenu)
        {
            Console.Clear();
            DateTime currentTime = DateTime.Now;
            Console.WriteLine($"> Current Date is {currentTime:dd/MM/yy}");
            returnToMenuMessage();
        }

        public void CurrentMenu_UserChoseCountCapaital(ActionMenu i_CurrentMenu)
        {
            Console.Clear();
            ShowAllCapitalLettersInSentence();
        }

        public void CurrentMenu_UserChoseShowVersion(ActionMenu i_CurrentMenu)
        {
            Console.Clear();
            ShowVersion();
        }

        public void ShowVersion()
        {
            Console.WriteLine("App Version: 26.2.4.7310");
            returnToMenuMessage();
        }

        public int CountAllCapitalLetters(string i_UserInputSentence)
        {
            int capitalLettersCount = 0;

            foreach (char currentChar in i_UserInputSentence)
            {
                if (char.IsUpper(currentChar))
                {
                    capitalLettersCount++;
                }
            }

            return capitalLettersCount;
        }

        public void ShowAllCapitalLettersInSentence()
        {
            Console.WriteLine("Enter a Sentence");
            string userSentence = Console.ReadLine();
            if (string.IsNullOrEmpty(userSentence))
            {
                Console.WriteLine("You entered an empty space try again!");
                return;
            }

            int capitalLettersInSentence = CountAllCapitalLetters(userSentence);
            Console.WriteLine($"> There are {capitalLettersInSentence} uppercase letters in your text");
            returnToMenuMessage();
        }

        private void returnToMenuMessage()
        {
            Console.WriteLine("Press any key to return to menu...");
            Console.ReadKey();
        }
    }
}

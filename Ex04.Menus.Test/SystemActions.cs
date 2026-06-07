using Ex04.Menus.Events;
using System;
using System.Collections.Generic;


namespace Ex04.Menus.Test
{
    internal class SystemActions
    {
        public void  CurrentMenu_UserChoseShowTime(ActionMenu i_CurrentMenu)
        {
            Console.Clear();
            ShowCurrentTime();
        }
        public void CurrentMenu_UserChoseShowDate(ActionMenu i_CurrentMenu)
        {
            Console.Clear();
            ShowCurrentDate();
        }
        public void CurrentMenu_UserChoseCountCapaital(ActionMenu i_CurrentMenu)
        {
            Console.Clear();
            ShowAllCapitalLettersInSentence();
        }
        public void CurrentMenu_ChoseShowVersion(ActionMenu i_CurrentMenu)
        {
            Console.Clear();
            ShowVersion();
        }
        public void ShowVersion()
        {
            Console.WriteLine("App Version: 26.2.4.7310");
        }
        public int CountAllCapitalLetters(string i_iuerInputSentence)
        {
            int capittalLettersCount = 0;
            foreach (char c in i_iuerInputSentence)
            {
                if (char.IsUpper(c))
                {
                    capittalLettersCount++;
                }
            }

            return capittalLettersCount;
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
            Console.WriteLine($"There are {capitalLettersInSentence} capital letters in your sentence.");
        }
        public void ShowCurrentTime() 
        {
            DateTime currentDate = DateTime.Now;
            Console.WriteLine($"The current time is: {currentDate:HH:mm}");
        }
        public void ShowCurrentDate() 
        {
            DateTime currentDate = DateTime.Now;
            Console.WriteLine($"The current date is: {currentDate:dd/MM/yy}");
        }



    }
}

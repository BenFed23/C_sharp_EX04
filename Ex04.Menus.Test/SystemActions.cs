using Ex04.Menus.Events;
using System;
using System.Collections.Generic;



namespace Ex04.Menus.Test
{
    public class SystemActions
    {
        public void  CurrentMenu_UserChoseShowTime(ActionMenu i_CurrentMenu)
        {
            Console.Clear();
            DateTime currentTime = DateTime.Now;
            Console.WriteLine($"currentTime: {currentTime:HH:mm:ss}");
            Console.WriteLine("Press any key to return to menu...");
            Console.ReadKey();
        }
        public void CurrentMenu_UserChoseShowDate(ActionMenu i_CurrentMenu)
        {
            Console.Clear();
            DateTime currentTime = DateTime.Now;
            Console.WriteLine($"current Date: {currentTime:dd:MM:yy}");
            Console.WriteLine("Press any key to return to menu...");
            Console.ReadKey();
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
            Console.WriteLine("Press any key to return to menu...");
            Console.ReadKey();
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
            Console.WriteLine("Press any key to return to menu...");
            Console.ReadKey();
        }


    }
}

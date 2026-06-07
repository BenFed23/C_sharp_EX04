using System;
using System.Collections.Generic;

namespace Ex04.Menus.Interfaces
{
    public class SubMenu : MenuItem
    {
        private readonly List<MenuItem> r_SubItems = new List<MenuItem>();
        private readonly bool r_IsMainMenu;

        public SubMenu(string i_MenuTitle, bool i_IsMainMenu = false) : base(i_MenuTitle)
        {
            r_IsMainMenu = i_IsMainMenu;
        }

        public List<MenuItem> SubItems
        {
            get
            {
                return r_SubItems;
            }
        }

        public void AddMenuItem(MenuItem i_MenuItem)
        {
            if(i_MenuItem != null)
            {
                r_SubItems.Add(i_MenuItem);
            }
        }

        public override void RunSelected()
        {
            bool isRunning = true;

            while(isRunning)
            {
                int amountOfItems = r_SubItems.Count;
                printMenu(amountOfItems);
                string userInput = Console.ReadLine();
                validateUserChoiceInput(userInput, amountOfItems, out isRunning);
            }
        }

        private void validateUserChoiceInput(string i_UserInput, int i_AmountOfOptions, out bool i_IsRunning)
        {
            i_IsRunning = true;

            if (int.TryParse(i_UserInput, out int userChoice))
            {
                if(userChoice == 0)
                {
                    i_IsRunning = false;
                }
                else if (userChoice > 0 && userChoice <= i_AmountOfOptions)
                {
                    Console.Clear();
                    r_SubItems[userChoice - 1].RunSelected();
                }
                else
                {
                    handleInvalidInput();
                }
            }
            else
            {
                handleInvalidInput();
            }
        }

        private void handleInvalidInput()
        {
            printInvalidInputMessage();
            Console.ReadLine();
        }

        private void printInvalidInputMessage()
        {
            Console.WriteLine("Invalid input. Please try again");
        }

        private void printMenu(int i_AmountOfOptions)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"** {Title} **");
            Console.WriteLine("------------------------");
            Console.ForegroundColor = ConsoleColor.White;
            for (int i = 0; i < i_AmountOfOptions; i++)
            {
                Console.WriteLine($"{i + 1}. {r_SubItems[i].Title}");
            }

            printLastOptionAndUserChoiceRequest(i_AmountOfOptions);
            Console.Write(">>");
        }

        private void printLastOptionAndUserChoiceRequest(int i_AmountOfOptions)
        {
            if (r_IsMainMenu)
            {
                Console.WriteLine("0. Exit");
                Console.WriteLine($"Please enter your choice (1-{i_AmountOfOptions} or 0 to exit): ");
            }
            else
            {
                Console.WriteLine("0. Back");
                Console.WriteLine($"Please enter your choice (1-{i_AmountOfOptions} or 0 to go back): ");
            }
        }
    }
}

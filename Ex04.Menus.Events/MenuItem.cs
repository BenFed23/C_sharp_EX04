using System;
using System.Collections.Generic;


namespace Ex04.Menus.Events
{
    public class MenuItem : Menu
    {
        protected readonly List<Menu> r_SubMenus;
        protected const int k_ExitOrGoingBack = 0;
        protected const int k_NoValueBeenGiven = -1;
        public MenuItem(string i_MenuTitle) : base(i_MenuTitle)
        {
            r_SubMenus = new List<Menu>();
        }
        public override void Show()
        {
            bool MenuIsruninng = true;
            int userChoice = k_NoValueBeenGiven;

            while (MenuIsruninng == true)
            {
                Console.Clear();
                printMenu();
                if (checkIfUserInputIsVailid(out userChoice))
                {
                    if (userChoice == k_ExitOrGoingBack)
                    {
                        Console.Clear();
                        Console.WriteLine("Hope to see you soon!");
                        MenuIsruninng = false; 
                    }
                    else
                    {
                        r_SubMenus[userChoice - 1].Show();
                    }
                }
                else
                {
                    Console.WriteLine("invalid choice try again!");
                    Console.ReadKey();
                }
            }

        }
        public void AddSubMenu(Menu i_SubMenu)
        {
            if (i_SubMenu != null)
            {
                r_SubMenus.Add(i_SubMenu);
            }
        }
        protected virtual void printMenu()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"** {m_Title} **");
            Console.WriteLine("------------------------");
            Console.ForegroundColor = ConsoleColor.White;
            if (r_SubMenus != null)
            {
                for (int i = 0; i < r_SubMenus.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {r_SubMenus[i].Title}");
                }
            }
            Console.WriteLine($"0. Exit");

            printMenuMessage();
        }
        protected virtual void printMenuMessage()
        {
            Console.WriteLine($"Please enter your choice (1-{r_SubMenus.Count} | or 0 to go back)");
        }
        private bool checkIfUserInputIsVailid(out int userChoice)
        {
            bool inputIsValid = false;
            string userInput = Console.ReadLine();
            if (int.TryParse(userInput, out userChoice) && userChoice >= 0 && userChoice <= r_SubMenus.Count)
            {
               inputIsValid = true;
            }
            else 
            {
                userChoice = k_NoValueBeenGiven;
                
            }

            return inputIsValid;
                
           


        }
    }
}

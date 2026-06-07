using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;


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
            bool menuIsRuninng = true;
            int userChoice = k_NoValueBeenGiven;

            while (menuIsRuninng == true)
            {
                Console.Clear();
                PrintMenu();
                if (checkIfUserInputIsVailid(out userChoice))
                {
                    if (userChoice == k_ExitOrGoingBack)
                    {
                        Console.Clear();
                        Console.WriteLine("Hope to see you soon!");
                        menuIsRuninng = false; 
                    }
                    else
                    {
                        r_SubMenus[userChoice - 1].Show();
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Press any key to return to the menu...");
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

        protected virtual void PrintMenu()
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
            printZeroOption();
            PrintMenuMessage();
        }

        protected virtual void PrintMenuMessage()
        {
            Console.WriteLine($"Please enter your choice (1-{r_SubMenus.Count} or 0 to go back):");
            Console.Write(">> ");
        }
        protected virtual void printZeroOption() 
        {
            Console.WriteLine($"0. Go back");
        }

        private bool checkIfUserInputIsVailid(out int o_UserChoice)
        {
            bool inputIsValid = false;
            string userInput = Console.ReadLine();

            if (int.TryParse(userInput, out o_UserChoice) && o_UserChoice >= 0 && o_UserChoice <= r_SubMenus.Count)
            {
               inputIsValid = true;
            }
            else 
            {
                o_UserChoice = k_NoValueBeenGiven;
                
            }

            return inputIsValid;
        }
    }
}

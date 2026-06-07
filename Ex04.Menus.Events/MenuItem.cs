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
            bool k_getOutOfMenu = false;
            int userChoice = k_NoValueBeenGiven;
            try 
            {
                while (k_getOutOfMenu == false)
                {
                    Console.Clear();
                    printMenu();
                    userChoice = int.Parse(Console.ReadLine());
                    if(userChoice == k_ExitOrGoingBack)//add vlidation check
                    {
                        Console.Clear() ;
                        Console.WriteLine("Hope you come back soon");
                        k_getOutOfMenu= true;
                    }
                    else
                    {
                        r_SubMenus[userChoice-1].Show();
                    }

                   
                }
            }
            catch
            {

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
                    Console.WriteLine($"{i + 1}. {r_SubMenus[i].Tytle}");
                }
            }
            printMenuMessage();
            
        }
        protected virtual void printMenuMessage()
        {
            Console.WriteLine($"Please enter your choice (1-{r_SubMenus.Count} | or 0 to go back)");
        }
    }
}

using System;
using System.Collections.Generic;


namespace Ex04.Menus.Events
{
    public class MainMenu : MenuItem 
    {
        public MainMenu(string i_MenuTitle) : base(i_MenuTitle) { }

        protected override void PrintMenuMessage()
        {
            Console.WriteLine($"Please enter your choice (1-{r_SubMenus.Count} or 0 to exit):");
            Console.Write(">> ");
        }
        protected override void printZeroOption()
        {
            Console.WriteLine($"0. Exit");
        }
    }
}

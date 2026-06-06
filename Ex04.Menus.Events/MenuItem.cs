using System;
using System.Collections.Generic;


namespace Ex04.Menus.Events
{
    public class MenuItem : Menu
    {
        private readonly List<Menu> r_SubMenus;
        public MenuItem(string i_MenuTitle) : base(i_MenuTitle)
        {
            r_SubMenus = new List<Menu>();
        }
        public override void Show()
        {

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(m_Title);
            Console.WriteLine("------------------------");
            Console.ForegroundColor = ConsoleColor.White;
            if (r_SubMenus != null)
            {
                for (int i = 0; i < r_SubMenus.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {r_SubMenus[i].Tytle}");
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
    }
}

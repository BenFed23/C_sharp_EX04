using System;

namespace Ex04.Menus.Interfaces
{
    public class MainMenu
    {
        private readonly SubMenu r_MainMenuRoot;

        public MainMenu(string i_MainMenuTitle)
        {
            r_MainMenuRoot = new SubMenu(i_MainMenuTitle, true);
        }

        public void AddMenuItem(MenuItem i_MenuItem)
        {
            r_MainMenuRoot.AddMenuItem(i_MenuItem);
        }

        public void Show()
        {

        }
    }
}

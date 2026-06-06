using System;

namespace Ex04.Menus.Interfaces
{
    public class MainMenu
    {
        private readonly SubMenu r_MenuRoot;

        public MainMenu(string i_MainMenuTitle)
        {
            r_MenuRoot = new SubMenu(i_MainMenuTitle, true);
        }

        public void AddMenuItem(MenuItem i_MenuItem)
        {
            r_MenuRoot.AddMenuItem(i_MenuItem);
        }

        public void Show()
        {
            r_MenuRoot.RunSelected();
        }
    }
}

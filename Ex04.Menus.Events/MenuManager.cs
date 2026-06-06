using System;
using System.Collections.Generic;


namespace Ex04.Menus.Events
{
    public class MenuManager
    {
        private MenuItem m_MainMenu ;
        public MenuManager( MenuItem i_MainMenu)
        {
            m_MainMenu = i_MainMenu;
        }
        public void Show()
        {
            m_MainMenu.Show();
        }
       
    }
}

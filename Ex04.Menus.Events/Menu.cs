using System;
using System.Collections.Generic;


namespace Ex04.Menus.Events
{
    public abstract class Menu
    {
        protected string m_Title;

        public Menu(string i_MenuTitle)
        {
            m_Title = i_MenuTitle;
        }
        public abstract void Show();
        public string Title 
        {
            get
            {
                return m_Title;
            }
            set
            {
                m_Title = value; 
            }
        }
    }
}

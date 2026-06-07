using System;

namespace Ex04.Menus.Interfaces
{
    public abstract class MenuItem
    {
        protected string m_MenuTitle;

        protected MenuItem(string i_MenuTitle)
        {
            m_MenuTitle = i_MenuTitle;
        }

        public abstract void RunSelected();

        public string Title
        {
            get
            {
                return m_MenuTitle;
            }
            set
            {
                m_MenuTitle = value;
            }
        }
    }
}

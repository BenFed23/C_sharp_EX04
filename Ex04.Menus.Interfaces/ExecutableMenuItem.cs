using System;

namespace Ex04.Menus.Interfaces
{
    public class ExecutableMenuItem : MenuItem
    {
        private readonly ISelectionListener r_ItemListener;

        public ExecutableMenuItem(string i_MenuTitle, ISelectionListener i_ItemListener) : base(i_MenuTitle)
        {
            r_ItemListener = i_ItemListener;
        }

        public override void RunSelected ()
        {
            if(r_ItemListener != null)
            {
                r_ItemListener.OnSelected();
            }
        }
    }
}

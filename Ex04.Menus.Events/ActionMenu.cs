using System;
using System.Collections.Generic;


namespace Ex04.Menus.Events
{
    public class ActionMenu : Menu
    {
        public event Action<ActionMenu> ChoseOption;

        public ActionMenu(string i_MenuTitle) : base(i_MenuTitle) { }

        protected void OnChoseOption()
        {
            if (ChoseOption != null)
            {
                ChoseOption.Invoke(this);
            }
        }

        public override void Show()
        {
            OnChoseOption();
        }
    }
}

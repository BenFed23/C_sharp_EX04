using System;
using System.Collections.Generic;


namespace Ex04.Menus.Events
{
    public class ActionMenu : Menu
    {
        public event Action<ActionMenu> choseOption;

        public ActionMenu(string i_MenuTitle) : base(i_MenuTitle) 
        {

        }
       
        protected void OnChoseOption()
        {
            if (choseOption != null)
            {
                choseOption.Invoke(this);
            }
        }
        public override void Show()
        {
            OnChoseOption();
        }

    }
}

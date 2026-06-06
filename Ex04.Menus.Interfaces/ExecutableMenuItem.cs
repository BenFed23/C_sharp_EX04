using System;

namespace Ex04.Menus.Interfaces
{
    public class ExecutableMenuItem : MenuItem
    {
        private readonly IMenuItemRunner r_ItemRunner;

        public ExecutableMenuItem(string i_MenuTitle, IMenuItemRunner i_ItemRunner) : base(i_MenuTitle)
        {
            r_ItemRunner = i_ItemRunner;
        }

        public override void Selected()
        {
            if(r_ItemRunner != null)
            {
                r_ItemRunner.Run();
            }
        }
    }
}

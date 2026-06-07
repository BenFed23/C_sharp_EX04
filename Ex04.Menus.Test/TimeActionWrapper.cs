using System;
using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
    public class TimeActionWrapper : ISelectionListener
    {
        private readonly SystemActions r_SystemActions;

        public TimeActionWrapper(SystemActions i_SystemActions)
        {
            r_SystemActions = i_SystemActions;
        }

        public void OnSelected()
        {
            r_SystemActions.CurrentMenu_UserChoseShowTime(null);
        }
    }
}

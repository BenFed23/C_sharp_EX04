using System;
using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
    public class DateActionWrapper : ISelectionListener
    {
        private readonly SystemActions r_SystemActions;

        public DateActionWrapper(SystemActions i_SystemActions)
        {
            r_SystemActions = i_SystemActions;
        }

        public void OnSelected()
        {
            r_SystemActions.CurrentMenu_UserChoseShowDate(null);
        }
    }
}

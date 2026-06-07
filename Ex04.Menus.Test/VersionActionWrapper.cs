using Ex04.Menus.Interfaces;
using System;

namespace Ex04.Menus.Test
{
    public class VersionActionWrapper : ISelectionListener
    {
        private readonly SystemActions r_SystemActions;

        public VersionActionWrapper(SystemActions i_SystemActions)
        {
            r_SystemActions = i_SystemActions;
        }

        public void OnSelected()
        {
            r_SystemActions.CurrentMenu_UserChoseShowVersion(null);
        }
    }
}

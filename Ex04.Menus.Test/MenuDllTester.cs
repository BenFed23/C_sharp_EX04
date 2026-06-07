using Ex04.Menus.Interfaces;
using System;
using System.Collections.Generic;


namespace Ex04.Menus.Test
{
    internal class MenuDllTester
    {
        public Ex04.Menus.Events.MainMenu EventsMenuTester()
        {
            Ex04.Menus.Events.MainMenu eventsMainMenu = new Ex04.Menus.Events.MainMenu("Main Menu");
            Ex04.Menus.Events.MenuItem eventsShowTimeMenu = new Ex04.Menus.Events.MenuItem("Show Current Date/Time");
            Ex04.Menus.Events.MenuItem eventsShowVersionAndCapitalsMenu = new Ex04.Menus.Events.MenuItem("Version and Capitals");
            eventsMainMenu.AddSubMenu(eventsShowTimeMenu);
            eventsMainMenu.AddSubMenu(eventsShowVersionAndCapitalsMenu);
            Ex04.Menus.Events.ActionMenu ShowCurrentTime = new Ex04.Menus.Events.ActionMenu("Show Current Time");
            Ex04.Menus.Events.ActionMenu ShowCurrentDate = new Ex04.Menus.Events.ActionMenu("Show Current Date");
            eventsShowTimeMenu.AddSubMenu(ShowCurrentTime);
            eventsShowTimeMenu.AddSubMenu(ShowCurrentDate);
            Ex04.Menus.Events.ActionMenu ShowVersion = new Ex04.Menus.Events.ActionMenu("Show Version");
            Ex04.Menus.Events.ActionMenu CountCapitals = new Ex04.Menus.Events.ActionMenu("Count Capitals");
            eventsShowVersionAndCapitalsMenu.AddSubMenu(ShowVersion);
            eventsShowVersionAndCapitalsMenu.AddSubMenu(CountCapitals);
            SystemActions actions = new SystemActions();
            ShowCurrentTime.choseOption += actions.CurrentMenu_UserChoseShowTime;
            ShowCurrentDate.choseOption += actions.CurrentMenu_UserChoseShowDate;
            ShowVersion.choseOption += actions.CurrentMenu_ChoseShowVersion;
            CountCapitals.choseOption += actions.CurrentMenu_UserChoseCountCapaital;
            eventsMainMenu.Show();
            return eventsMainMenu;
        }

        public Ex04.Menus.Interfaces.MainMenu InterfaceMenuTester()
        {
            SystemActions actions = new SystemActions();
            Ex04.Menus.Interfaces.MainMenu interfaceMainMenu = new MainMenu("Interfaces Main Menu");
            Ex04.Menus.Interfaces.SubMenu dateAndTimeMenu = new SubMenu("Show Current Date/Time");
            Ex04.Menus.Interfaces.SubMenu versionAndCapitalsMenu = new SubMenu("Version and Capitals");
            interfaceMainMenu.AddMenuItem(dateAndTimeMenu);
            interfaceMainMenu.AddMenuItem(versionAndCapitalsMenu);
            Ex04.Menus.Interfaces.ExecutableMenuItem ShowCurrentTime = new Ex04.Menus.Interfaces.ExecutableMenuItem("Show Current Time", new TimeActionWrapper(actions));
            Ex04.Menus.Interfaces.ExecutableMenuItem ShowCurrentDate = new Ex04.Menus.Interfaces.ExecutableMenuItem("Show Current Date", new DateActionWrapper(actions));
            Ex04.Menus.Interfaces.ExecutableMenuItem ShowVersion = new Ex04.Menus.Interfaces.ExecutableMenuItem("Show Version", new VersionActionWrapper(actions));
            Ex04.Menus.Interfaces.ExecutableMenuItem CountCapitals = new Ex04.Menus.Interfaces.ExecutableMenuItem("Show Capitals", new CapitalsActionWrapper(actions));
            dateAndTimeMenu.AddMenuItem(ShowCurrentTime);
            dateAndTimeMenu.AddMenuItem(ShowCurrentDate);
            versionAndCapitalsMenu.AddMenuItem(ShowVersion);
            versionAndCapitalsMenu.AddMenuItem(CountCapitals);
            interfaceMainMenu.Show();
            return interfaceMainMenu;
        }
    }
}

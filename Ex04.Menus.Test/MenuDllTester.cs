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
            eventsMainMenu.Show();

            return eventsMainMenu;
        }
    }
}

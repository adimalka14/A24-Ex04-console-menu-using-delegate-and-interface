using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
    public class InterfaceTest
    {
        public static void StartInterfaceTest()
        {
            MainMenu mainMenu = new MainMenu("Interface MainMenu");
            SubMenu showDateTime = new SubMenu("Show Date/Time");
            SubMenu versionAndCapitals = new SubMenu("Version and Capitals");
            ActionItem showDate = new ActionItem("Show Date", new ShowDate());
            ActionItem showTime = new ActionItem("Show Time", new ShowTime());
            ActionItem countCapitals = new ActionItem("countCapitals", new CountCapitals());
            ActionItem showVersion = new ActionItem("Show Version", new ShowVersion());
            mainMenu.AddOptionsForMainMenu(showDateTime, versionAndCapitals);
            showDateTime.AddOptionsForSubMenu(showDate, showTime);
            versionAndCapitals.AddOptionsForSubMenu(countCapitals, showVersion);
            mainMenu.Show();
        }
    }
}
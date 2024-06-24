using Ex04.Menus.Delegates;

namespace Ex04.Menus.Test
{
    internal class DelegatesTest
    {
        public static void StartDelegatesTest()
        {
            MainMenu mainMenu = new MainMenu("Delegates MainMenu");
            SubMenu showDateTime = new SubMenu("Show Date/Time");
            SubMenu versionAndCapitals = new SubMenu("Version and Capitals");
            ActionItem showDate = new ActionItem("Show Date");
            showDate.ExecuteActionItem += ShowDate.ShowCurrentDate;
            ActionItem showTime = new ActionItem("Show Time");
            showTime.ExecuteActionItem += ShowTime.ShowCurrentTime;
            ActionItem countCapitals = new ActionItem("countCapitals");
            countCapitals.ExecuteActionItem += CountCapitals.CountCapitalsLetters;
            ActionItem showVersion = new ActionItem("Show Version");
            showVersion.ExecuteActionItem += ShowVersion.ShowVersionMethod;
            mainMenu.AddOptionsForMainMenu(showDateTime, versionAndCapitals);
            showDateTime.AddOptionsForSubMenu(showDate, showTime);
            versionAndCapitals.AddOptionsForSubMenu(countCapitals, showVersion);
            mainMenu.Show();
        }
    }
}
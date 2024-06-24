using System;

namespace Ex04.Menus.Delegates
{
    public class MainMenu
    {
        private readonly SubMenu r_SubMenu;

        public MainMenu(string i_Name)
        {
            r_SubMenu = new SubMenu(i_Name);
            ActionItem exit = new ActionItem("Exit");
            exit.ExecuteActionItem += this.exit;
            r_SubMenu.AddBackOption(exit);
        }

        public void Show()
        {
            r_SubMenu.NotifySelectedMenuItem();
        }

        public void AddOptionsForMainMenu(params MenuItem[] i_Options)
        {
            r_SubMenu.AddOptionsForSubMenu(i_Options);
        }

        private void exit()
        {
            Console.WriteLine(@"Goodbye,
You have selected to exit the menu.
Click any button to finish.");
            Console.ReadKey();
        }
    }
}
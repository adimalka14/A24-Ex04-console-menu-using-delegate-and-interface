using System;

namespace Ex04.Menus.Interfaces
{
    public class MainMenu
    {
        private readonly SubMenu r_SubMenu;

        public MainMenu(string i_Name)
        {
            r_SubMenu = new SubMenu(i_Name);
            r_SubMenu.AddBackOption(new ActionItem("Exit", new Exit()));
        }

        public void Show()
        {
            r_SubMenu.NotifySelectedMenuItem();
        }

        public void AddOptionsForMainMenu(params MenuItem[] i_Options)
        {
            r_SubMenu.AddOptionsForSubMenu(i_Options);
        }

        internal class Exit : IExecuteLeafAction
        {
            public void ExecuteLeafAction()
            {
                exit();
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
}
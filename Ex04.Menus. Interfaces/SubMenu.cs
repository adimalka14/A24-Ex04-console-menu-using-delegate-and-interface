using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex04.Menus.Interfaces
{
    public class SubMenu : MenuItem
    {
        private readonly Dictionary<int, MenuItem> r_Items = new Dictionary<int, MenuItem>();
        private const int k_BackOptionNumber = 0;

        public SubMenu(string i_Name) : base(i_Name) { }

        public void AddOptionsForSubMenu(params MenuItem[] i_OptionNames)
        {
            int optionNumber = r_Items.Count;

            foreach (MenuItem option in i_OptionNames)
            {
                r_Items.Add(optionNumber++, option);
                option.AddBackOption(this);
            }
        }

        internal override void AddBackOption(MenuItem i_MenuItem)
        {
            this.r_Items.Add(k_BackOptionNumber, i_MenuItem);
        }

        private void addOptionsToDisplay(StringBuilder i_Display)
        {
            i_Display.AppendLine($"**{this.r_Name}**");
            i_Display.AppendLine("--------------------");
            foreach (var item in this.r_Items.Skip(1))
            {
                string option = string.Format($"{item.Key} -> {item.Value.Name}");
                i_Display.AppendLine(option);
            }

            r_Items.TryGetValue(k_BackOptionNumber, out MenuItem menuItem);
            i_Display.AppendLine($"0 -> {backOrExit(menuItem)}");
        }

        internal override void NotifySelectedMenuItem()
        {
            int userChoise;
            StringBuilder display = new StringBuilder();

            addOptionsToDisplay(display);
            Console.Write(display.ToString());
            userChoise = getValidUserChoise();
            Console.Clear();
            r_Items.TryGetValue(userChoise, out MenuItem nextSubMenu);
            nextSubMenu?.NotifySelectedMenuItem();
        }

        private int getValidUserChoise()
        {
            int userChoise;

            r_Items.TryGetValue(k_BackOptionNumber, out MenuItem item);
            Console.WriteLine($"Enter your request : ( 1 to {r_Items.Count - 1} or press '0' to {backOrExit(item)}).");
            while (!int.TryParse(Console.ReadLine(), out userChoise) || !checkRange(userChoise))
            {
                Console.WriteLine("Please choose a valid numeric option.");
            }

            return userChoise;
        }

        private string backOrExit(MenuItem i_MenuItem)
        {
            return i_MenuItem.Name == "Exit" ? "Exit" : "Back";
        }

        private bool checkRange(int i_UserChoise)
        {
            return i_UserChoise >= 0 && i_UserChoise <= r_Items.Count - 1;
        }
    }
}
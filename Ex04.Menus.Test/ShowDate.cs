using Ex04.Menus.Interfaces;
using System;

namespace Ex04.Menus.Test
{
    public class ShowDate : IExecuteLeafAction
    {
        public void ExecuteLeafAction()
        {
            ShowCurrentDate();
        }

        public static void ShowCurrentDate()
        {
            Console.WriteLine($"Current date: {DateTime.Now.ToString("yyyy-MM-dd")}\n");
        }
    }
}
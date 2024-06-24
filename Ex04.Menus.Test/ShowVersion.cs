using Ex04.Menus.Interfaces;
using System;

namespace Ex04.Menus.Test
{
    public class ShowVersion : IExecuteLeafAction
    {
        public void ExecuteLeafAction()
        {
            ShowVersionMethod();
        }

        public static void ShowVersionMethod()
        {
            Console.WriteLine("Version 24.1.4.9633\n");
        }
    }
}
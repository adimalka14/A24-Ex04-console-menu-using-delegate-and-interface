using Ex04.Menus.Interfaces;
using System;

namespace Ex04.Menus.Test
{
    public class ShowTime : IExecuteLeafAction
    {
        public void ExecuteLeafAction()
        {
            ShowCurrentTime();
        }

        public static void ShowCurrentTime()
        {
            Console.WriteLine("The hour is: " + DateTime.Now.ToString("HH:mm:ss\n"));
        }
    }
}
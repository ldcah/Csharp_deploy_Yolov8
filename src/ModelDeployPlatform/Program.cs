
using CommonSharp;
using System;
using System.Windows.Forms;

namespace ModelDeployPlatform
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ConsoleShow.AllocConsole();
            Console.Title = "������ʾ";
          //  ApplicationConfiguration.Initialize();
            //Application.Run(new FormEngineConvert());
            Application.Run(new FormModelDeployPlat());
        }
    }
}
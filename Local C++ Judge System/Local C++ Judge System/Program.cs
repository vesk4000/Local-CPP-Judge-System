using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace Local_C___Judge_System
{
    static class Evaluator
    {
        //get the current directory
        public static string cdir = Directory.GetCurrentDirectory();

        public static bool Compile(string sourcePath, string exePath, int compilationTimeLimit)
        {
            Process cmd = new Process();
            cmd.StartInfo.FileName = "CMD";
            cmd.StartInfo.RedirectStandardInput = true;
            cmd.StartInfo.RedirectStandardOutput = true;
            cmd.StartInfo.UseShellExecute = false;
            cmd.Start();
            cmd.StandardInput.WriteLine("c:");
            cmd.StandardInput.WriteLine("cd C:\\MinGW\\bin");
            cmd.StandardInput.WriteLine("g++ \"E:\\DeKStop\\helloworld.cpp\" -o \"E:\\DeKStop\\helloworld.exe\" -static-libgcc -static-libstdc++");
            cmd.StandardInput.Flush();
            cmd.StandardInput.Close();
            cmd.WaitForExit();

            return true; 
        }
        public static string getRoaming()
        {
            return Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\AppData\\Roaming";
        }

        public static void Settings()
        {
            string tdir = getRoaming();
            if (!Directory.Exists(tdir + "\\Vesk"))
                Directory.CreateDirectory(tdir + "\\Vesk");
            tdir = tdir + "\\Vesk";

            if(!Directory.Exists(tdir + "\\Local C++ Judge System"))
                Directory.CreateDirectory(tdir + "\\Local C++ Judge System");
            tdir = tdir + "\\Local C++ Judge System";

            //Setup settings.ini
            if(!File.Exists(tdir + "\\settings.ini"))
            {

            }
        }
    }

    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}

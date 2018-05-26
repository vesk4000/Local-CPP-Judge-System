using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;
using System.Windows.Forms;

namespace Local_C___Judge_System
{
    static class BackEnd
    {
        public static string tdir;//Temporary directory

        //Initiate Settings
        public static void InitSettings()
        {
            //Set tdir to the user's Roaming folder
            tdir = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\AppData\\Roaming";

            //Open Roaming\Vesk
            if (!Directory.Exists(tdir + "\\Vesk"))
                Directory.CreateDirectory(tdir + "\\Vesk");
            tdir = tdir + "\\Vesk";

            //Open Roaming\Vesk\Local C++ Judge System
            if (!Directory.Exists(tdir + "\\Local C++ Judge System"))
                Directory.CreateDirectory(tdir + "\\Local C++ Judge System");
            tdir = tdir + "\\Local C++ Judge System";

            //Open settings.txt
            if (File.Exists(tdir + "\\settings.txt"))
            {
                Program.mf.textBoxGPP.Text = File.ReadAllText(tdir + "\\settings.txt");
            }
            else
            {
                File.Create(tdir + "\\settings.txt");
            }
                
        }

        //Set Settings
        public static void SetSettings()
        {
            File.WriteAllText(tdir + "\\settings.txt", Program.mf.textBoxGPP.Text);
        }

        public static Result InitEvaluation(string gppPath, string sourcePath, string testsPath, int timeLimit, int memoryLimit)
        {
            Program.mf.buttonEvaluate.Enabled = false;
            Result r = new Result();

            Program.mf.labelStatus.Text = "Compiling...";
            string exePath = Compile(gppPath, sourcePath);
            List<string> testNames = GetTestNames(testsPath);
            
            foreach (string t in testNames)
            {
                string tt = t;
                tt = tt.Substring(tt.LastIndexOf('\\') + 1, tt.Count() - tt.LastIndexOf('\\') - 1);
                tt = tt.Substring(0, tt.Count() - 3);

                Program.mf.labelStatus.Text = "Evaluating " + tt;
                //MessageBox.Show(Program.mf.labelStatus.Text);

                r.testResults.Add("");
                
                Process p = new Process();
                p.StartInfo.FileName = exePath;
                p.StartInfo.UseShellExecute = false;//Some shit the program needs to work

                //Hide the cmd window
                p.StartInfo.CreateNoWindow = true;
                p.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;

                //Redirect the input to write commands
                p.StartInfo.RedirectStandardInput = true;
                p.StartInfo.RedirectStandardOutput = true;

                string[] input = File.ReadAllLines(t);
                string exOutput = File.ReadAllText(t.Replace(".in", ".sol"));

                p.Start();
                foreach (string line in input)
                {
                    p.StandardInput.WriteLine(line);
                }
                if (memoryLimit != -1 && Convert.ToInt64(p.PeakWorkingSet64) > Convert.ToInt64(memoryLimit) )
                {
                    r.testResults[r.testResults.Count - 1] = "ml ";
                }
                string output = p.StandardOutput.ReadToEnd();
                
                p.WaitForExit();
                if (r.testResults[r.testResults.Count - 1] != "ml " && timeLimit != -1 && (p.ExitTime - p.StartTime).TotalMilliseconds > timeLimit)
                {
                    r.testResults[r.testResults.Count - 1] = "tl ";
                }
                else if (r.testResults[r.testResults.Count - 1] != "ml ")
                {
                    if (exOutput == output)
                    {
                        r.testResults[r.testResults.Count - 1] = "ok ";
                        ++r.ok;
                    }
                    else
                    {
                        r.testResults[r.testResults.Count - 1] = "wa ";
                    }
                }

                r.testResults[r.testResults.Count - 1] = tt + ": " + r.testResults[r.testResults.Count - 1];
            }
            Program.mf.listBoxResults.Items.Add(Convert.ToString(r.ok) + "/" + r.testResults.Count + " or " + Convert.ToString(100 * r.ok / r.testResults.Count) + "%");
            foreach (string tt in r.testResults)
            {
                Program.mf.listBoxResults.Items.Add(tt);
            }
            Program.mf.labelStatus.Text = "Waiting for Input";
            Program.mf.buttonEvaluate.Enabled = true;
            return r;
        }

        public static string Compile(string gppPath, string sourcePath)
        {
            string exePath;
            exePath = tdir + "\\currentCompilation.exe";
            if (File.Exists(exePath))
                File.Delete(exePath);

            Process cmd = new Process();
            cmd.StartInfo.FileName = "cmd.exe";
            cmd.StartInfo.UseShellExecute = false;//Some shit the program needs to work

            //Hide the cmd window
            cmd.StartInfo.CreateNoWindow = true;
            cmd.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;

            //Redirect the input to write commands
            cmd.StartInfo.RedirectStandardInput = true;
            cmd.StartInfo.RedirectStandardOutput = true;

            cmd.Start();//Start the program

            //Change to the drive where g++ is
            string t;
            t = gppPath.Substring(0, 2);
            t.ToLower();
            cmd.StandardInput.WriteLine(t);
            
            //Go to where g++ is
            gppPath = gppPath.Replace("\\g++.exe", "");
            cmd.StandardInput.WriteLine("cd " + gppPath);
            
            //Compile
            cmd.StandardInput.WriteLine("g++ " + "\"" + sourcePath + "\"" + " -o " + "\"" + exePath + "\"" + " -static-libgcc -static-libstdc++");

            //Close the cmd
            cmd.StandardInput.Flush();
            cmd.StandardInput.Close();
            cmd.WaitForExit();

            return exePath;
        }

        public static List<string> GetTestNames(string path)
        {
            List<string> l = new List<string>();
            DirectoryInfo d = new DirectoryInfo(path);
            FileInfo[] filez = d.GetFiles("*.in");
            foreach (FileInfo file in filez)
            {
                if (File.Exists(path + "\\" + file.Name.Replace(".in", ".sol")))
                {
                    l.Add(path + "\\" + file.Name);
                }
            }
            return l;
        }
    }
}

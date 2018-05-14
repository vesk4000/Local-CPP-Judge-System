using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Local_C___Judge_System
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            //MessageBox.Show(Evaluator.getRoaming());
        }
        
        //An object for the Source File Browser
        OpenFileDialog ofd = new OpenFileDialog();

        //An object for the Tests Folder Browser
        FolderBrowserDialog fbd = new FolderBrowserDialog();

        //The function that activates when the G++ Browse
        private void buttonGPPBrowse_Click(object sender, EventArgs e)
        {
            ofd.Filter = "g++ Compiler|g++.exe";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                textBoxGPP.Text = ofd.FileName;
            }
        }

        //The function that activates when the Source Browse Button is pressed
        private void buttonSourceBrowse_Click(object sender, EventArgs e)
        {
            ofd.Filter = "C++ Source File|*.cpp";//Set the filter's name to "C++ Source File" and the extension to ".cpp"
            if (ofd.ShowDialog() == DialogResult.OK)//If the user has succesfully selected a cpp file
            {
                textBoxSource.Text = ofd.FileName;
            }
        }

        //The function that activates when the Tests Browse Button is pressed
        private void buttonTestsBrowse_Click(object sender, EventArgs e)
        {
            if (fbd.ShowDialog() == DialogResult.OK)//If the user has succesfully selected a folder
            {
                textBoxTests.Text = fbd.SelectedPath;
            }
        }
        
        //The function that activates when the Evaluate Button is pressed
        private void buttonEvaluate_Click(object sender, EventArgs e)
        {
            labelJudgeResult.Text = Convert.ToString(Evaluator.Compile(textBoxSource.Text, Evaluator.cdir + "\\output.exe", 1000000));
        }
    }
}

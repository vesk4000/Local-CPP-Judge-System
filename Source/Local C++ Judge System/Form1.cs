using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace Local_C___Judge_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Startup function
        private void Form1_Load(object sender, EventArgs e)
        {
            BackEnd.InitSettings();
        }

        //The function the activates when any of the browser text boxes are changed
        private void browserTextBox_TextChanged(object sender, EventArgs e)
        {
            this.tbChanged();
        }

        //The internal function that activates when any of the browser text boxes are changed
        private void tbChanged()
        {
            if ( File.Exists(textBoxGPP.Text) && File.Exists(textBoxSource.Text) && Directory.Exists(textBoxTests.Text) )
            {
                buttonEvaluate.Enabled = true;
            }
            else
            {
                buttonEvaluate.Enabled = false;
            }
        }

        //The function that activates when the text in textBoxGPP is changed
        private void textBoxGPP_TextChanged(object sender, EventArgs e)
        {
            this.tbChanged();
            BackEnd.SetSettings();
        }

        //The function that activates when the buttonGPPBrowse is clicked
        private void buttonGPPBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();//An object for the g++.exe browser
            
            ofd.Filter = "g++ Compiler|g++.exe";//Set the filter's name to "g++ Compiler" and the filename to "g++.exe"
            
            //Set the text of textBoxGPP to the path to the selected file
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                textBoxGPP.Text = ofd.FileName;
            }
        }

        //The function that activates when the buttonSourceBrowse is clicked
        private void buttonSourceBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();//An object for the source browser

            ofd.Filter = "C++ Source File|*.cpp";//Set the filter's name to "C++ Source File" and the extension to ".cpp"

            //Set the text of textBoxSource to the path to the selected file
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                textBoxSource.Text = ofd.FileName;
            }
        }

        //The function that activates when the buttonTestsBrowse is clicked
        private void buttonTestsBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog fbd = new OpenFileDialog();//An object for the source browser

            fbd.ValidateNames = false;
            fbd.CheckFileExists = false;
            fbd.CheckPathExists = true;
            fbd.FileName = "Folder Selection";

            //Set the text of textBoxTests to the path to the selected folder
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                textBoxTests.Text = fbd.FileName;
                textBoxTests.Text = textBoxTests.Text.Substring(0, textBoxTests.Text.LastIndexOf("\\"));
            }
            
        }

        private void buttonEvaluate_Click(object sender, EventArgs e)
        {
            Result r = new Result();
            int tl;
            int ml;
            if (textBoxTimeLimit.Text == "")
                tl = -1;
            else
                tl = Convert.ToInt32(textBoxTimeLimit.Text);
            if (textBoxMemoryLimit.Text == "")
                ml = -1;
            else
                ml = Convert.ToInt32(textBoxMemoryLimit.Text);
            r = BackEnd.InitEvaluation(textBoxGPP.Text, textBoxSource.Text, textBoxTests.Text, tl, ml);
            /*string sad = "";
            int br = 0;
            foreach (string asd in r.testResults)
            {
                if (asd == "ok ")
                    ++br;
                sad += asd;
            }

            listBoxResults.Items.Add(textBoxSource.Text + " " + Convert.ToString(100/r.testResults.Count*br) + "% " + sad);*/
            //MessageBox.Show("done");
        }
    }
}

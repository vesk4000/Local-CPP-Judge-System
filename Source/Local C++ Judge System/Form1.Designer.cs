namespace Local_C___Judge_System
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelTextGPP = new System.Windows.Forms.Label();
            this.buttonGPPBrowse = new System.Windows.Forms.Button();
            this.textBoxGPP = new System.Windows.Forms.TextBox();
            this.labelTextSource = new System.Windows.Forms.Label();
            this.labelTextTests = new System.Windows.Forms.Label();
            this.textBoxSource = new System.Windows.Forms.TextBox();
            this.textBoxTests = new System.Windows.Forms.TextBox();
            this.buttonSourceBrowse = new System.Windows.Forms.Button();
            this.buttonTestsBrowse = new System.Windows.Forms.Button();
            this.labelTextTimeLimit = new System.Windows.Forms.Label();
            this.labelTextMemoryLimit = new System.Windows.Forms.Label();
            this.textBoxMemoryLimit = new System.Windows.Forms.TextBox();
            this.textBoxTimeLimit = new System.Windows.Forms.TextBox();
            this.buttonEvaluate = new System.Windows.Forms.Button();
            this.labelTextResults = new System.Windows.Forms.Label();
            this.listBoxResults = new System.Windows.Forms.ListBox();
            this.labelStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelTextGPP
            // 
            this.labelTextGPP.AutoSize = true;
            this.labelTextGPP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTextGPP.Location = new System.Drawing.Point(12, 9);
            this.labelTextGPP.Name = "labelTextGPP";
            this.labelTextGPP.Size = new System.Drawing.Size(44, 20);
            this.labelTextGPP.TabIndex = 0;
            this.labelTextGPP.Text = "G++:";
            // 
            // buttonGPPBrowse
            // 
            this.buttonGPPBrowse.Location = new System.Drawing.Point(278, 8);
            this.buttonGPPBrowse.Name = "buttonGPPBrowse";
            this.buttonGPPBrowse.Size = new System.Drawing.Size(75, 20);
            this.buttonGPPBrowse.TabIndex = 2;
            this.buttonGPPBrowse.Text = "Browse";
            this.buttonGPPBrowse.UseVisualStyleBackColor = true;
            this.buttonGPPBrowse.Click += new System.EventHandler(this.buttonGPPBrowse_Click);
            // 
            // textBoxGPP
            // 
            this.textBoxGPP.Location = new System.Drawing.Point(82, 9);
            this.textBoxGPP.Name = "textBoxGPP";
            this.textBoxGPP.Size = new System.Drawing.Size(190, 20);
            this.textBoxGPP.TabIndex = 1;
            this.textBoxGPP.TextChanged += new System.EventHandler(this.textBoxGPP_TextChanged);
            // 
            // labelTextSource
            // 
            this.labelTextSource.AutoSize = true;
            this.labelTextSource.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTextSource.Location = new System.Drawing.Point(12, 34);
            this.labelTextSource.Name = "labelTextSource";
            this.labelTextSource.Size = new System.Drawing.Size(64, 20);
            this.labelTextSource.TabIndex = 3;
            this.labelTextSource.Text = "Source:";
            // 
            // labelTextTests
            // 
            this.labelTextTests.AutoSize = true;
            this.labelTextTests.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTextTests.Location = new System.Drawing.Point(12, 59);
            this.labelTextTests.Name = "labelTextTests";
            this.labelTextTests.Size = new System.Drawing.Size(52, 20);
            this.labelTextTests.TabIndex = 4;
            this.labelTextTests.Text = "Tests:";
            // 
            // textBoxSource
            // 
            this.textBoxSource.Location = new System.Drawing.Point(82, 34);
            this.textBoxSource.Name = "textBoxSource";
            this.textBoxSource.Size = new System.Drawing.Size(190, 20);
            this.textBoxSource.TabIndex = 5;
            this.textBoxSource.TextChanged += new System.EventHandler(this.browserTextBox_TextChanged);
            // 
            // textBoxTests
            // 
            this.textBoxTests.Location = new System.Drawing.Point(82, 59);
            this.textBoxTests.Name = "textBoxTests";
            this.textBoxTests.Size = new System.Drawing.Size(190, 20);
            this.textBoxTests.TabIndex = 6;
            this.textBoxTests.TextChanged += new System.EventHandler(this.browserTextBox_TextChanged);
            // 
            // buttonSourceBrowse
            // 
            this.buttonSourceBrowse.Location = new System.Drawing.Point(278, 34);
            this.buttonSourceBrowse.Name = "buttonSourceBrowse";
            this.buttonSourceBrowse.Size = new System.Drawing.Size(75, 20);
            this.buttonSourceBrowse.TabIndex = 7;
            this.buttonSourceBrowse.Text = "Browse";
            this.buttonSourceBrowse.UseVisualStyleBackColor = true;
            this.buttonSourceBrowse.Click += new System.EventHandler(this.buttonSourceBrowse_Click);
            // 
            // buttonTestsBrowse
            // 
            this.buttonTestsBrowse.Location = new System.Drawing.Point(278, 59);
            this.buttonTestsBrowse.Name = "buttonTestsBrowse";
            this.buttonTestsBrowse.Size = new System.Drawing.Size(75, 20);
            this.buttonTestsBrowse.TabIndex = 8;
            this.buttonTestsBrowse.Text = "Browse";
            this.buttonTestsBrowse.UseVisualStyleBackColor = true;
            this.buttonTestsBrowse.Click += new System.EventHandler(this.buttonTestsBrowse_Click);
            // 
            // labelTextTimeLimit
            // 
            this.labelTextTimeLimit.AutoSize = true;
            this.labelTextTimeLimit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTextTimeLimit.Location = new System.Drawing.Point(12, 84);
            this.labelTextTimeLimit.Name = "labelTextTimeLimit";
            this.labelTextTimeLimit.Size = new System.Drawing.Size(84, 20);
            this.labelTextTimeLimit.TabIndex = 9;
            this.labelTextTimeLimit.Text = "Time Limit:";
            // 
            // labelTextMemoryLimit
            // 
            this.labelTextMemoryLimit.AutoSize = true;
            this.labelTextMemoryLimit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTextMemoryLimit.Location = new System.Drawing.Point(12, 109);
            this.labelTextMemoryLimit.Name = "labelTextMemoryLimit";
            this.labelTextMemoryLimit.Size = new System.Drawing.Size(106, 20);
            this.labelTextMemoryLimit.TabIndex = 10;
            this.labelTextMemoryLimit.Text = "Memory Limit:";
            // 
            // textBoxMemoryLimit
            // 
            this.textBoxMemoryLimit.Location = new System.Drawing.Point(125, 109);
            this.textBoxMemoryLimit.Name = "textBoxMemoryLimit";
            this.textBoxMemoryLimit.Size = new System.Drawing.Size(108, 20);
            this.textBoxMemoryLimit.TabIndex = 11;
            // 
            // textBoxTimeLimit
            // 
            this.textBoxTimeLimit.Location = new System.Drawing.Point(125, 84);
            this.textBoxTimeLimit.Name = "textBoxTimeLimit";
            this.textBoxTimeLimit.Size = new System.Drawing.Size(108, 20);
            this.textBoxTimeLimit.TabIndex = 12;
            // 
            // buttonEvaluate
            // 
            this.buttonEvaluate.Enabled = false;
            this.buttonEvaluate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonEvaluate.Location = new System.Drawing.Point(240, 84);
            this.buttonEvaluate.Name = "buttonEvaluate";
            this.buttonEvaluate.Size = new System.Drawing.Size(113, 45);
            this.buttonEvaluate.TabIndex = 13;
            this.buttonEvaluate.Text = "Evaluate";
            this.buttonEvaluate.UseVisualStyleBackColor = true;
            this.buttonEvaluate.Click += new System.EventHandler(this.buttonEvaluate_Click);
            // 
            // labelTextResults
            // 
            this.labelTextResults.AutoSize = true;
            this.labelTextResults.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTextResults.Location = new System.Drawing.Point(12, 134);
            this.labelTextResults.Name = "labelTextResults";
            this.labelTextResults.Size = new System.Drawing.Size(67, 20);
            this.labelTextResults.TabIndex = 14;
            this.labelTextResults.Text = "Results:";
            // 
            // listBoxResults
            // 
            this.listBoxResults.FormattingEnabled = true;
            this.listBoxResults.Location = new System.Drawing.Point(16, 159);
            this.listBoxResults.Name = "listBoxResults";
            this.listBoxResults.Size = new System.Drawing.Size(337, 277);
            this.listBoxResults.TabIndex = 15;
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelStatus.ForeColor = System.Drawing.Color.DodgerBlue;
            this.labelStatus.Location = new System.Drawing.Point(121, 134);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(143, 20);
            this.labelStatus.TabIndex = 16;
            this.labelStatus.Text = "Waiting for Input";
            this.labelStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 450);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.listBoxResults);
            this.Controls.Add(this.labelTextResults);
            this.Controls.Add(this.buttonEvaluate);
            this.Controls.Add(this.textBoxTimeLimit);
            this.Controls.Add(this.textBoxMemoryLimit);
            this.Controls.Add(this.labelTextMemoryLimit);
            this.Controls.Add(this.labelTextTimeLimit);
            this.Controls.Add(this.buttonTestsBrowse);
            this.Controls.Add(this.buttonSourceBrowse);
            this.Controls.Add(this.textBoxTests);
            this.Controls.Add(this.textBoxSource);
            this.Controls.Add(this.labelTextTests);
            this.Controls.Add(this.labelTextSource);
            this.Controls.Add(this.textBoxGPP);
            this.Controls.Add(this.buttonGPPBrowse);
            this.Controls.Add(this.labelTextGPP);
            this.Name = "Form1";
            this.Text = "Vesk\'s Local C++ Jugde System";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label labelTextGPP;
        private System.Windows.Forms.Button buttonGPPBrowse;
        public System.Windows.Forms.TextBox textBoxGPP;
        private System.Windows.Forms.Label labelTextSource;
        private System.Windows.Forms.Label labelTextTests;
        private System.Windows.Forms.TextBox textBoxSource;
        private System.Windows.Forms.TextBox textBoxTests;
        private System.Windows.Forms.Button buttonSourceBrowse;
        private System.Windows.Forms.Button buttonTestsBrowse;
        private System.Windows.Forms.Label labelTextTimeLimit;
        private System.Windows.Forms.Label labelTextMemoryLimit;
        private System.Windows.Forms.TextBox textBoxMemoryLimit;
        private System.Windows.Forms.TextBox textBoxTimeLimit;
        public System.Windows.Forms.Button buttonEvaluate;
        private System.Windows.Forms.Label labelTextResults;
        public System.Windows.Forms.ListBox listBoxResults;
        public System.Windows.Forms.Label labelStatus;
    }
}


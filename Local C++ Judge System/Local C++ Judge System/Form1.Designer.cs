namespace Local_C___Judge_System
{
    partial class MainForm
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
            this.labelTextSource = new System.Windows.Forms.Label();
            this.textBoxSource = new System.Windows.Forms.TextBox();
            this.buttonSourceBrowse = new System.Windows.Forms.Button();
            this.labelTextTests = new System.Windows.Forms.Label();
            this.textBoxTests = new System.Windows.Forms.TextBox();
            this.buttonTestsBrowse = new System.Windows.Forms.Button();
            this.labelTextTimeLimit = new System.Windows.Forms.Label();
            this.textBoxTimeLimit = new System.Windows.Forms.TextBox();
            this.labelTextMemoryLimit = new System.Windows.Forms.Label();
            this.textBoxMemoryLimit = new System.Windows.Forms.TextBox();
            this.buttonEvaluate = new System.Windows.Forms.Button();
            this.labelTextResult = new System.Windows.Forms.Label();
            this.labelJudgeResult = new System.Windows.Forms.Label();
            this.buttonDetails = new System.Windows.Forms.Button();
            this.labelTextGPP = new System.Windows.Forms.Label();
            this.textBoxGPP = new System.Windows.Forms.TextBox();
            this.buttonGPPBrowse = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelTextSource
            // 
            this.labelTextSource.AutoSize = true;
            this.labelTextSource.BackColor = System.Drawing.SystemColors.Control;
            this.labelTextSource.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTextSource.Location = new System.Drawing.Point(12, 39);
            this.labelTextSource.Name = "labelTextSource";
            this.labelTextSource.Size = new System.Drawing.Size(64, 20);
            this.labelTextSource.TabIndex = 0;
            this.labelTextSource.Text = "Source:";
            this.labelTextSource.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxSource
            // 
            this.textBoxSource.Location = new System.Drawing.Point(82, 39);
            this.textBoxSource.Name = "textBoxSource";
            this.textBoxSource.Size = new System.Drawing.Size(181, 20);
            this.textBoxSource.TabIndex = 20;
            // 
            // buttonSourceBrowse
            // 
            this.buttonSourceBrowse.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSourceBrowse.Location = new System.Drawing.Point(269, 38);
            this.buttonSourceBrowse.Name = "buttonSourceBrowse";
            this.buttonSourceBrowse.Size = new System.Drawing.Size(75, 20);
            this.buttonSourceBrowse.TabIndex = 2;
            this.buttonSourceBrowse.Text = "Browse";
            this.buttonSourceBrowse.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonSourceBrowse.UseVisualStyleBackColor = true;
            this.buttonSourceBrowse.Click += new System.EventHandler(this.buttonSourceBrowse_Click);
            // 
            // labelTextTests
            // 
            this.labelTextTests.AutoSize = true;
            this.labelTextTests.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTextTests.Location = new System.Drawing.Point(12, 65);
            this.labelTextTests.Name = "labelTextTests";
            this.labelTextTests.Size = new System.Drawing.Size(52, 20);
            this.labelTextTests.TabIndex = 3;
            this.labelTextTests.Text = "Tests:";
            this.labelTextTests.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxTests
            // 
            this.textBoxTests.Location = new System.Drawing.Point(82, 67);
            this.textBoxTests.Name = "textBoxTests";
            this.textBoxTests.Size = new System.Drawing.Size(181, 20);
            this.textBoxTests.TabIndex = 4;
            // 
            // buttonTestsBrowse
            // 
            this.buttonTestsBrowse.Location = new System.Drawing.Point(269, 67);
            this.buttonTestsBrowse.Name = "buttonTestsBrowse";
            this.buttonTestsBrowse.Size = new System.Drawing.Size(75, 20);
            this.buttonTestsBrowse.TabIndex = 5;
            this.buttonTestsBrowse.Text = "Browse";
            this.buttonTestsBrowse.UseVisualStyleBackColor = true;
            this.buttonTestsBrowse.Click += new System.EventHandler(this.buttonTestsBrowse_Click);
            // 
            // labelTextTimeLimit
            // 
            this.labelTextTimeLimit.AutoSize = true;
            this.labelTextTimeLimit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTextTimeLimit.Location = new System.Drawing.Point(12, 91);
            this.labelTextTimeLimit.Name = "labelTextTimeLimit";
            this.labelTextTimeLimit.Size = new System.Drawing.Size(84, 20);
            this.labelTextTimeLimit.TabIndex = 6;
            this.labelTextTimeLimit.Text = "Time Limit:";
            // 
            // textBoxTimeLimit
            // 
            this.textBoxTimeLimit.Location = new System.Drawing.Point(124, 93);
            this.textBoxTimeLimit.Name = "textBoxTimeLimit";
            this.textBoxTimeLimit.Size = new System.Drawing.Size(105, 20);
            this.textBoxTimeLimit.TabIndex = 7;
            // 
            // labelTextMemoryLimit
            // 
            this.labelTextMemoryLimit.AutoSize = true;
            this.labelTextMemoryLimit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTextMemoryLimit.Location = new System.Drawing.Point(12, 117);
            this.labelTextMemoryLimit.Name = "labelTextMemoryLimit";
            this.labelTextMemoryLimit.Size = new System.Drawing.Size(106, 20);
            this.labelTextMemoryLimit.TabIndex = 8;
            this.labelTextMemoryLimit.Text = "Memory Limit:";
            // 
            // textBoxMemoryLimit
            // 
            this.textBoxMemoryLimit.Location = new System.Drawing.Point(124, 119);
            this.textBoxMemoryLimit.Name = "textBoxMemoryLimit";
            this.textBoxMemoryLimit.Size = new System.Drawing.Size(105, 20);
            this.textBoxMemoryLimit.TabIndex = 9;
            // 
            // buttonEvaluate
            // 
            this.buttonEvaluate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonEvaluate.Location = new System.Drawing.Point(235, 93);
            this.buttonEvaluate.Name = "buttonEvaluate";
            this.buttonEvaluate.Size = new System.Drawing.Size(109, 46);
            this.buttonEvaluate.TabIndex = 10;
            this.buttonEvaluate.Text = "Evaluate";
            this.buttonEvaluate.UseVisualStyleBackColor = true;
            this.buttonEvaluate.Click += new System.EventHandler(this.buttonEvaluate_Click);
            // 
            // labelTextResult
            // 
            this.labelTextResult.AutoSize = true;
            this.labelTextResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTextResult.Location = new System.Drawing.Point(12, 143);
            this.labelTextResult.Name = "labelTextResult";
            this.labelTextResult.Size = new System.Drawing.Size(59, 20);
            this.labelTextResult.TabIndex = 11;
            this.labelTextResult.Text = "Result:";
            // 
            // labelJudgeResult
            // 
            this.labelJudgeResult.AutoSize = true;
            this.labelJudgeResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelJudgeResult.ForeColor = System.Drawing.Color.SteelBlue;
            this.labelJudgeResult.Location = new System.Drawing.Point(78, 145);
            this.labelJudgeResult.Name = "labelJudgeResult";
            this.labelJudgeResult.Size = new System.Drawing.Size(141, 20);
            this.labelJudgeResult.TabIndex = 12;
            this.labelJudgeResult.Text = "Waiting for input";
            // 
            // buttonDetails
            // 
            this.buttonDetails.Location = new System.Drawing.Point(235, 143);
            this.buttonDetails.Name = "buttonDetails";
            this.buttonDetails.Size = new System.Drawing.Size(111, 22);
            this.buttonDetails.TabIndex = 13;
            this.buttonDetails.Text = "Details";
            this.buttonDetails.UseVisualStyleBackColor = true;
            // 
            // labelTextGPP
            // 
            this.labelTextGPP.AutoSize = true;
            this.labelTextGPP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTextGPP.Location = new System.Drawing.Point(12, 9);
            this.labelTextGPP.Name = "labelTextGPP";
            this.labelTextGPP.Size = new System.Drawing.Size(44, 20);
            this.labelTextGPP.TabIndex = 14;
            this.labelTextGPP.Text = "G++:";
            // 
            // textBoxGPP
            // 
            this.textBoxGPP.Location = new System.Drawing.Point(82, 9);
            this.textBoxGPP.Name = "textBoxGPP";
            this.textBoxGPP.Size = new System.Drawing.Size(181, 20);
            this.textBoxGPP.TabIndex = 1;
            // 
            // buttonGPPBrowse
            // 
            this.buttonGPPBrowse.Location = new System.Drawing.Point(270, 9);
            this.buttonGPPBrowse.Name = "buttonGPPBrowse";
            this.buttonGPPBrowse.Size = new System.Drawing.Size(75, 20);
            this.buttonGPPBrowse.TabIndex = 16;
            this.buttonGPPBrowse.Text = "Browse";
            this.buttonGPPBrowse.UseVisualStyleBackColor = true;
            this.buttonGPPBrowse.Click += new System.EventHandler(this.buttonGPPBrowse_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 175);
            this.Controls.Add(this.buttonGPPBrowse);
            this.Controls.Add(this.textBoxGPP);
            this.Controls.Add(this.labelTextGPP);
            this.Controls.Add(this.buttonDetails);
            this.Controls.Add(this.labelJudgeResult);
            this.Controls.Add(this.labelTextResult);
            this.Controls.Add(this.buttonEvaluate);
            this.Controls.Add(this.textBoxMemoryLimit);
            this.Controls.Add(this.labelTextMemoryLimit);
            this.Controls.Add(this.textBoxTimeLimit);
            this.Controls.Add(this.labelTextTimeLimit);
            this.Controls.Add(this.buttonTestsBrowse);
            this.Controls.Add(this.textBoxTests);
            this.Controls.Add(this.labelTextTests);
            this.Controls.Add(this.buttonSourceBrowse);
            this.Controls.Add(this.textBoxSource);
            this.Controls.Add(this.labelTextSource);
            this.Name = "MainForm";
            this.Text = "Local C++ Judge System";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTextSource;
        private System.Windows.Forms.TextBox textBoxSource;
        private System.Windows.Forms.Button buttonSourceBrowse;
        private System.Windows.Forms.Label labelTextTests;
        private System.Windows.Forms.TextBox textBoxTests;
        private System.Windows.Forms.Button buttonTestsBrowse;
        private System.Windows.Forms.Label labelTextTimeLimit;
        private System.Windows.Forms.TextBox textBoxTimeLimit;
        private System.Windows.Forms.Label labelTextMemoryLimit;
        private System.Windows.Forms.TextBox textBoxMemoryLimit;
        private System.Windows.Forms.Button buttonEvaluate;
        private System.Windows.Forms.Label labelTextResult;
        private System.Windows.Forms.Label labelJudgeResult;
        private System.Windows.Forms.Button buttonDetails;
        private System.Windows.Forms.Label labelTextGPP;
        private System.Windows.Forms.TextBox textBoxGPP;
        private System.Windows.Forms.Button buttonGPPBrowse;
    }
}


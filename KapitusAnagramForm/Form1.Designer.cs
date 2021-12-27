namespace KapitusAnagramForm
{
    partial class frmAnagram
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
            this.grpAnagrams = new System.Windows.Forms.GroupBox();
            this.rbLength = new System.Windows.Forms.RadioButton();
            this.rbCount = new System.Windows.Forms.RadioButton();
            this.txtOutput = new System.Windows.Forms.RichTextBox();
            this.grpAtLeast = new System.Windows.Forms.GroupBox();
            this.udAtLeast = new System.Windows.Forms.NumericUpDown();
            this.ssStatus = new System.Windows.Forms.StatusStrip();
            this.ssCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.ssLoad = new System.Windows.Forms.ToolStripStatusLabel();
            this.ssRefresh = new System.Windows.Forms.ToolStripStatusLabel();
            this.ssSpring = new System.Windows.Forms.ToolStripStatusLabel();
            this.ssWords = new System.Windows.Forms.ToolStripStatusLabel();
            this.grpDataSource = new System.Windows.Forms.GroupBox();
            this.txtFile = new System.Windows.Forms.TextBox();
            this.odFile = new System.Windows.Forms.OpenFileDialog();
            this.btnFile = new System.Windows.Forms.Button();
            this.grpAnagrams.SuspendLayout();
            this.grpAtLeast.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.udAtLeast)).BeginInit();
            this.ssStatus.SuspendLayout();
            this.grpDataSource.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpAnagrams
            // 
            this.grpAnagrams.Controls.Add(this.rbLength);
            this.grpAnagrams.Controls.Add(this.rbCount);
            this.grpAnagrams.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpAnagrams.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.grpAnagrams.Location = new System.Drawing.Point(12, 12);
            this.grpAnagrams.Name = "grpAnagrams";
            this.grpAnagrams.Size = new System.Drawing.Size(289, 64);
            this.grpAnagrams.TabIndex = 0;
            this.grpAnagrams.TabStop = false;
            this.grpAnagrams.Text = "&Anagrams By Number Of";
            // 
            // rbLength
            // 
            this.rbLength.AutoSize = true;
            this.rbLength.ForeColor = System.Drawing.Color.Black;
            this.rbLength.Location = new System.Drawing.Point(105, 29);
            this.rbLength.Name = "rbLength";
            this.rbLength.Size = new System.Drawing.Size(172, 24);
            this.rbLength.TabIndex = 1;
            this.rbLength.Text = "&Characters in a word";
            this.rbLength.UseVisualStyleBackColor = true;
            this.rbLength.CheckedChanged += new System.EventHandler(this.rbLength_CheckedChanged);
            // 
            // rbCount
            // 
            this.rbCount.AutoSize = true;
            this.rbCount.Checked = true;
            this.rbCount.ForeColor = System.Drawing.Color.Black;
            this.rbCount.Location = new System.Drawing.Point(22, 29);
            this.rbCount.Name = "rbCount";
            this.rbCount.Size = new System.Drawing.Size(77, 24);
            this.rbCount.TabIndex = 0;
            this.rbCount.TabStop = true;
            this.rbCount.Text = " &Words";
            this.rbCount.UseVisualStyleBackColor = true;
            this.rbCount.CheckedChanged += new System.EventHandler(this.rbCount_CheckedChanged);
            // 
            // txtOutput
            // 
            this.txtOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOutput.Location = new System.Drawing.Point(12, 94);
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ReadOnly = true;
            this.txtOutput.Size = new System.Drawing.Size(1145, 597);
            this.txtOutput.TabIndex = 2;
            this.txtOutput.Text = "";
            // 
            // grpAtLeast
            // 
            this.grpAtLeast.Controls.Add(this.udAtLeast);
            this.grpAtLeast.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpAtLeast.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.grpAtLeast.Location = new System.Drawing.Point(307, 14);
            this.grpAtLeast.Name = "grpAtLeast";
            this.grpAtLeast.Size = new System.Drawing.Size(86, 62);
            this.grpAtLeast.TabIndex = 1;
            this.grpAtLeast.TabStop = false;
            this.grpAtLeast.Text = "At &Least";
            // 
            // udAtLeast
            // 
            this.udAtLeast.Location = new System.Drawing.Point(22, 29);
            this.udAtLeast.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.udAtLeast.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.udAtLeast.Name = "udAtLeast";
            this.udAtLeast.Size = new System.Drawing.Size(58, 26);
            this.udAtLeast.TabIndex = 0;
            this.udAtLeast.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.udAtLeast.ValueChanged += new System.EventHandler(this.udAtLeast_ValueChanged);
            // 
            // ssStatus
            // 
            this.ssStatus.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ssStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ssLoad,
            this.ssRefresh,
            this.ssSpring,
            this.ssWords,
            this.ssCount});
            this.ssStatus.Location = new System.Drawing.Point(0, 694);
            this.ssStatus.Name = "ssStatus";
            this.ssStatus.Size = new System.Drawing.Size(1169, 30);
            this.ssStatus.TabIndex = 3;
            // 
            // ssCount
            // 
            this.ssCount.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.ssCount.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.ssCount.Name = "ssCount";
            this.ssCount.Size = new System.Drawing.Size(70, 25);
            this.ssCount.Text = "ssCount";
            // 
            // ssLoad
            // 
            this.ssLoad.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.ssLoad.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.ssLoad.Name = "ssLoad";
            this.ssLoad.Size = new System.Drawing.Size(161, 25);
            this.ssLoad.Text = "toolStripStatusLabel1";
            // 
            // ssRefresh
            // 
            this.ssRefresh.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.ssRefresh.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.ssRefresh.Name = "ssRefresh";
            this.ssRefresh.Size = new System.Drawing.Size(161, 25);
            this.ssRefresh.Text = "toolStripStatusLabel2";
            // 
            // ssSpring
            // 
            this.ssSpring.Name = "ssSpring";
            this.ssSpring.Size = new System.Drawing.Size(601, 25);
            this.ssSpring.Spring = true;
            // 
            // ssWords
            // 
            this.ssWords.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.ssWords.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.ssWords.Name = "ssWords";
            this.ssWords.Size = new System.Drawing.Size(161, 25);
            this.ssWords.Text = "toolStripStatusLabel1";
            // 
            // grpDataSource
            // 
            this.grpDataSource.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpDataSource.Controls.Add(this.btnFile);
            this.grpDataSource.Controls.Add(this.txtFile);
            this.grpDataSource.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpDataSource.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.grpDataSource.Location = new System.Drawing.Point(399, 12);
            this.grpDataSource.Name = "grpDataSource";
            this.grpDataSource.Size = new System.Drawing.Size(758, 64);
            this.grpDataSource.TabIndex = 2;
            this.grpDataSource.TabStop = false;
            this.grpDataSource.Text = "&Data Source";
            // 
            // txtFile
            // 
            this.txtFile.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFile.Location = new System.Drawing.Point(7, 29);
            this.txtFile.Name = "txtFile";
            this.txtFile.ReadOnly = true;
            this.txtFile.Size = new System.Drawing.Size(617, 26);
            this.txtFile.TabIndex = 0;
            // 
            // odFile
            // 
            this.odFile.FileName = "openFileDialog1";
            // 
            // btnFile
            // 
            this.btnFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFile.ForeColor = System.Drawing.Color.Black;
            this.btnFile.Location = new System.Drawing.Point(630, 27);
            this.btnFile.Name = "btnFile";
            this.btnFile.Size = new System.Drawing.Size(122, 29);
            this.btnFile.TabIndex = 1;
            this.btnFile.Text = "Select &file";
            this.btnFile.UseVisualStyleBackColor = true;
            this.btnFile.Click += new System.EventHandler(this.btnFile_Click);
            // 
            // frmAnagram
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1169, 724);
            this.Controls.Add(this.grpDataSource);
            this.Controls.Add(this.ssStatus);
            this.Controls.Add(this.grpAtLeast);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.grpAnagrams);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimumSize = new System.Drawing.Size(1000, 500);
            this.Name = "frmAnagram";
            this.Text = "Anagram Fun";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpAnagrams.ResumeLayout(false);
            this.grpAnagrams.PerformLayout();
            this.grpAtLeast.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.udAtLeast)).EndInit();
            this.ssStatus.ResumeLayout(false);
            this.ssStatus.PerformLayout();
            this.grpDataSource.ResumeLayout(false);
            this.grpDataSource.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpAnagrams;
        private System.Windows.Forms.RadioButton rbLength;
        private System.Windows.Forms.RadioButton rbCount;
        private System.Windows.Forms.RichTextBox txtOutput;
        private System.Windows.Forms.GroupBox grpAtLeast;
        private System.Windows.Forms.NumericUpDown udAtLeast;
        private System.Windows.Forms.StatusStrip ssStatus;
        private System.Windows.Forms.ToolStripStatusLabel ssCount;
        private System.Windows.Forms.ToolStripStatusLabel ssLoad;
        private System.Windows.Forms.ToolStripStatusLabel ssRefresh;
        private System.Windows.Forms.ToolStripStatusLabel ssSpring;
        private System.Windows.Forms.ToolStripStatusLabel ssWords;
        private System.Windows.Forms.GroupBox grpDataSource;
        private System.Windows.Forms.Button btnFile;
        private System.Windows.Forms.TextBox txtFile;
        private System.Windows.Forms.OpenFileDialog odFile;
    }
}


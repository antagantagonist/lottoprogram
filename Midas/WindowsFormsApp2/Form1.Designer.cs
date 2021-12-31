namespace WindowsFormsApp2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnProcess = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gbxOptions = new System.Windows.Forms.GroupBox();
            this.tbxAmount = new System.Windows.Forms.TextBox();
            this.lblError = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.rbAvg = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.rbRandom = new System.Windows.Forms.RadioButton();
            this.btnGen = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rbPool = new System.Windows.Forms.RadioButton();
            this.rbRange = new System.Windows.Forms.RadioButton();
            this.rbMargin = new System.Windows.Forms.RadioButton();
            this.rbStrat = new System.Windows.Forms.RadioButton();
            this.tbxLoad = new System.Windows.Forms.TextBox();
            this.tbxTickets = new System.Windows.Forms.TextBox();
            this.btnLoad = new System.Windows.Forms.Button();
            this.lblPrompt = new System.Windows.Forms.Label();
            this.ofdText = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1.SuspendLayout();
            this.gbxOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnProcess
            // 
            this.btnProcess.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnProcess.Location = new System.Drawing.Point(12, 105);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(274, 33);
            this.btnProcess.TabIndex = 1;
            this.btnProcess.Text = "Process";
            this.btnProcess.UseVisualStyleBackColor = true;
            this.btnProcess.Click += new System.EventHandler(this.btnProcess_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(847, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // gbxOptions
            // 
            this.gbxOptions.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gbxOptions.Controls.Add(this.tbxAmount);
            this.gbxOptions.Controls.Add(this.lblError);
            this.gbxOptions.Controls.Add(this.label8);
            this.gbxOptions.Controls.Add(this.rbAvg);
            this.gbxOptions.Controls.Add(this.label7);
            this.gbxOptions.Controls.Add(this.rbRandom);
            this.gbxOptions.Controls.Add(this.btnGen);
            this.gbxOptions.Controls.Add(this.label6);
            this.gbxOptions.Controls.Add(this.label4);
            this.gbxOptions.Controls.Add(this.label3);
            this.gbxOptions.Controls.Add(this.label2);
            this.gbxOptions.Controls.Add(this.label1);
            this.gbxOptions.Controls.Add(this.rbPool);
            this.gbxOptions.Controls.Add(this.rbRange);
            this.gbxOptions.Controls.Add(this.rbMargin);
            this.gbxOptions.Controls.Add(this.rbStrat);
            this.gbxOptions.Location = new System.Drawing.Point(292, 37);
            this.gbxOptions.Name = "gbxOptions";
            this.gbxOptions.Size = new System.Drawing.Size(263, 491);
            this.gbxOptions.TabIndex = 3;
            this.gbxOptions.TabStop = false;
            this.gbxOptions.Text = "Options";
            // 
            // tbxAmount
            // 
            this.tbxAmount.Location = new System.Drawing.Point(211, 395);
            this.tbxAmount.Name = "tbxAmount";
            this.tbxAmount.Size = new System.Drawing.Size(41, 20);
            this.tbxAmount.TabIndex = 17;
            // 
            // lblError
            // 
            this.lblError.Location = new System.Drawing.Point(12, 371);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(240, 17);
            this.lblError.TabIndex = 16;
            this.lblError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(9, 118);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(240, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Choosing numbers through statistical curvature.";
            // 
            // rbAvg
            // 
            this.rbAvg.AutoSize = true;
            this.rbAvg.Location = new System.Drawing.Point(9, 97);
            this.rbAvg.Name = "rbAvg";
            this.rbAvg.Size = new System.Drawing.Size(70, 17);
            this.rbAvg.TabIndex = 14;
            this.rbAvg.TabStop = true;
            this.rbAvg.Text = "Averages";
            this.rbAvg.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(9, 42);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(240, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Default random numbers.";
            // 
            // rbRandom
            // 
            this.rbRandom.AutoSize = true;
            this.rbRandom.Location = new System.Drawing.Point(9, 21);
            this.rbRandom.Name = "rbRandom";
            this.rbRandom.Size = new System.Drawing.Size(66, 17);
            this.rbRandom.TabIndex = 12;
            this.rbRandom.TabStop = true;
            this.rbRandom.Text = "Machine";
            this.rbRandom.UseVisualStyleBackColor = true;
            // 
            // btnGen
            // 
            this.btnGen.Location = new System.Drawing.Point(9, 423);
            this.btnGen.Name = "btnGen";
            this.btnGen.Size = new System.Drawing.Size(243, 62);
            this.btnGen.TabIndex = 6;
            this.btnGen.Text = "Generate Numbers";
            this.btnGen.UseVisualStyleBackColor = true;
            this.btnGen.Click += new System.EventHandler(this.btnGen_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 398);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Amount of Tickets:";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(240, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Using more common numbers.";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 232);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(240, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Generating numbers from a range.";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(240, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Measuring distance between margins.";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Splitting number groups into sections.";
            // 
            // rbPool
            // 
            this.rbPool.AutoSize = true;
            this.rbPool.Location = new System.Drawing.Point(9, 59);
            this.rbPool.Name = "rbPool";
            this.rbPool.Size = new System.Drawing.Size(91, 17);
            this.rbPool.TabIndex = 3;
            this.rbPool.TabStop = true;
            this.rbPool.Text = "Number Pools";
            this.rbPool.UseVisualStyleBackColor = true;
            // 
            // rbRange
            // 
            this.rbRange.AutoSize = true;
            this.rbRange.Location = new System.Drawing.Point(9, 211);
            this.rbRange.Name = "rbRange";
            this.rbRange.Size = new System.Drawing.Size(112, 17);
            this.rbRange.TabIndex = 2;
            this.rbRange.TabStop = true;
            this.rbRange.Text = "Range Generation";
            this.rbRange.UseVisualStyleBackColor = true;
            // 
            // rbMargin
            // 
            this.rbMargin.AutoSize = true;
            this.rbMargin.Location = new System.Drawing.Point(9, 173);
            this.rbMargin.Name = "rbMargin";
            this.rbMargin.Size = new System.Drawing.Size(99, 17);
            this.rbMargin.TabIndex = 1;
            this.rbMargin.TabStop = true;
            this.rbMargin.Text = "Margin Spacing";
            this.rbMargin.UseVisualStyleBackColor = true;
            // 
            // rbStrat
            // 
            this.rbStrat.AutoSize = true;
            this.rbStrat.Location = new System.Drawing.Point(9, 135);
            this.rbStrat.Name = "rbStrat";
            this.rbStrat.Size = new System.Drawing.Size(83, 17);
            this.rbStrat.TabIndex = 0;
            this.rbStrat.TabStop = true;
            this.rbStrat.Text = "Stratification";
            this.rbStrat.UseVisualStyleBackColor = true;
            // 
            // tbxLoad
            // 
            this.tbxLoad.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tbxLoad.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxLoad.Location = new System.Drawing.Point(12, 145);
            this.tbxLoad.Multiline = true;
            this.tbxLoad.Name = "tbxLoad";
            this.tbxLoad.ReadOnly = true;
            this.tbxLoad.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbxLoad.Size = new System.Drawing.Size(274, 383);
            this.tbxLoad.TabIndex = 4;
            this.tbxLoad.Text = resources.GetString("tbxLoad.Text");
            // 
            // tbxTickets
            // 
            this.tbxTickets.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.tbxTickets.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxTickets.Location = new System.Drawing.Point(561, 37);
            this.tbxTickets.Multiline = true;
            this.tbxTickets.Name = "tbxTickets";
            this.tbxTickets.ReadOnly = true;
            this.tbxTickets.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbxTickets.Size = new System.Drawing.Size(274, 491);
            this.tbxTickets.TabIndex = 5;
            this.tbxTickets.Text = resources.GetString("tbxTickets.Text");
            // 
            // btnLoad
            // 
            this.btnLoad.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnLoad.Location = new System.Drawing.Point(12, 43);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(274, 33);
            this.btnLoad.TabIndex = 1;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // lblPrompt
            // 
            this.lblPrompt.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblPrompt.Location = new System.Drawing.Point(12, 79);
            this.lblPrompt.Name = "lblPrompt";
            this.lblPrompt.Size = new System.Drawing.Size(274, 23);
            this.lblPrompt.TabIndex = 7;
            this.lblPrompt.Text = "Confirmation Prompt";
            this.lblPrompt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ofdText
            // 
            this.ofdText.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 540);
            this.Controls.Add(this.lblPrompt);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.tbxTickets);
            this.Controls.Add(this.tbxLoad);
            this.Controls.Add(this.gbxOptions);
            this.Controls.Add(this.btnProcess);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(863, 578);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Midas";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.gbxOptions.ResumeLayout(false);
            this.gbxOptions.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnProcess;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.GroupBox gbxOptions;
        private System.Windows.Forms.Button btnGen;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbPool;
        private System.Windows.Forms.RadioButton rbRange;
        private System.Windows.Forms.RadioButton rbMargin;
        private System.Windows.Forms.RadioButton rbStrat;
        private System.Windows.Forms.TextBox tbxLoad;
        private System.Windows.Forms.TextBox tbxTickets;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Label lblPrompt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton rbRandom;
        private System.Windows.Forms.OpenFileDialog ofdText;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton rbAvg;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.TextBox tbxAmount;
    }
}


using System.IO;
using System.ComponentModel;
namespace AGC_DEBUG
{
    partial class CompilerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CompilerForm));
            this.BLoad = new System.Windows.Forms.Button();
            this.BSave = new System.Windows.Forms.Button();
            this.AGCFileLoad = new System.Windows.Forms.OpenFileDialog();
            this.AGCFileSave = new System.Windows.Forms.SaveFileDialog();
            this.BCompile = new System.Windows.Forms.Button();
            this.BNew = new System.Windows.Forms.Button();
            this.OutputBox = new System.Windows.Forms.TextBox();
            this.SourceBox = new System.Windows.Forms.RichTextBox();
            this.sourceCodeLabel = new System.Windows.Forms.Label();
            this.outputLabel = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.labelsOutput = new System.Windows.Forms.RichTextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.consClear = new System.Windows.Forms.Button();
            this.resetAGC = new System.Windows.Forms.Button();
            this.AGCOutput = new System.Windows.Forms.TextBox();
            this.AGCBinLoad = new System.Windows.Forms.Button();
            this.Halt = new System.Windows.Forms.Button();
            this.AGCStep = new System.Windows.Forms.Button();
            this.AGCRunButton = new System.Windows.Forms.Button();
            this.StepCheckBox = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox5 = new AGC_DEBUG.TextBoxInterThread();
            this.textBox6 = new AGC_DEBUG.TextBoxInterThread();
            this.textBox3 = new AGC_DEBUG.TextBoxInterThread();
            this.textBox4 = new AGC_DEBUG.TextBoxInterThread();
            this.textBox2 = new AGC_DEBUG.TextBoxInterThread();
            this.textBox1 = new AGC_DEBUG.TextBoxInterThread();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.compileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BLoad
            // 
            this.BLoad.Location = new System.Drawing.Point(155, 11);
            this.BLoad.Margin = new System.Windows.Forms.Padding(4);
            this.BLoad.Name = "BLoad";
            this.BLoad.Size = new System.Drawing.Size(75, 36);
            this.BLoad.TabIndex = 1;
            this.BLoad.Text = "Load...";
            this.BLoad.UseVisualStyleBackColor = true;
            this.BLoad.Click += new System.EventHandler(this.BLoad_Click);
            // 
            // BSave
            // 
            this.BSave.Location = new System.Drawing.Point(257, 11);
            this.BSave.Margin = new System.Windows.Forms.Padding(4);
            this.BSave.Name = "BSave";
            this.BSave.Size = new System.Drawing.Size(75, 36);
            this.BSave.TabIndex = 2;
            this.BSave.Text = "Save...";
            this.BSave.UseVisualStyleBackColor = true;
            this.BSave.Click += new System.EventHandler(this.BSave_Click);
            // 
            // AGCFileLoad
            // 
            this.AGCFileLoad.Filter = "AGC File|*.agc|Bin File|*.bin";
            this.AGCFileLoad.Tag = "";
            // 
            // AGCFileSave
            // 
            this.AGCFileSave.Filter = "AGC File|*.agc|BIN File|*.bin";
            this.AGCFileSave.Tag = "";
            // 
            // BCompile
            // 
            this.BCompile.Location = new System.Drawing.Point(356, 10);
            this.BCompile.Margin = new System.Windows.Forms.Padding(4);
            this.BCompile.Name = "BCompile";
            this.BCompile.Size = new System.Drawing.Size(77, 38);
            this.BCompile.TabIndex = 3;
            this.BCompile.Text = "Compile";
            this.BCompile.UseVisualStyleBackColor = true;
            this.BCompile.Click += new System.EventHandler(this.BCompile_Click);
            // 
            // BNew
            // 
            this.BNew.Location = new System.Drawing.Point(43, 11);
            this.BNew.Margin = new System.Windows.Forms.Padding(4);
            this.BNew.Name = "BNew";
            this.BNew.Size = new System.Drawing.Size(76, 36);
            this.BNew.TabIndex = 4;
            this.BNew.Text = "New...";
            this.BNew.UseVisualStyleBackColor = true;
            this.BNew.Click += new System.EventHandler(this.BNew_Click);
            // 
            // OutputBox
            // 
            this.OutputBox.Location = new System.Drawing.Point(500, 86);
            this.OutputBox.Margin = new System.Windows.Forms.Padding(4);
            this.OutputBox.Multiline = true;
            this.OutputBox.Name = "OutputBox";
            this.OutputBox.Size = new System.Drawing.Size(459, 420);
            this.OutputBox.TabIndex = 5;
            // 
            // SourceBox
            // 
            this.SourceBox.AcceptsTab = true;
            this.SourceBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.SourceBox.Location = new System.Drawing.Point(43, 86);
            this.SourceBox.Margin = new System.Windows.Forms.Padding(4);
            this.SourceBox.Name = "SourceBox";
            this.SourceBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.SourceBox.Size = new System.Drawing.Size(367, 597);
            this.SourceBox.TabIndex = 6;
            this.SourceBox.Text = "";
            // 
            // sourceCodeLabel
            // 
            this.sourceCodeLabel.AutoSize = true;
            this.sourceCodeLabel.Location = new System.Drawing.Point(73, 66);
            this.sourceCodeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.sourceCodeLabel.Name = "sourceCodeLabel";
            this.sourceCodeLabel.Size = new System.Drawing.Size(90, 17);
            this.sourceCodeLabel.TabIndex = 7;
            this.sourceCodeLabel.Text = "Source Code";
            // 
            // outputLabel
            // 
            this.outputLabel.AutoSize = true;
            this.outputLabel.Location = new System.Drawing.Point(512, 66);
            this.outputLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(51, 17);
            this.outputLabel.TabIndex = 8;
            this.outputLabel.Text = "Output";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(0, 60);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1009, 727);
            this.tabControl1.TabIndex = 9;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tabPage1.Controls.Add(this.SourceBox);
            this.tabPage1.Controls.Add(this.outputLabel);
            this.tabPage1.Controls.Add(this.OutputBox);
            this.tabPage1.Controls.Add(this.sourceCodeLabel);
            this.tabPage1.Controls.Add(this.BNew);
            this.tabPage1.Controls.Add(this.BLoad);
            this.tabPage1.Controls.Add(this.BCompile);
            this.tabPage1.Controls.Add(this.BSave);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(1001, 698);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "YUL";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.labelsOutput);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(1001, 698);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Labels output";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Labels and bank status";
            // 
            // labelsOutput
            // 
            this.labelsOutput.AcceptsTab = true;
            this.labelsOutput.Location = new System.Drawing.Point(19, 38);
            this.labelsOutput.Margin = new System.Windows.Forms.Padding(4);
            this.labelsOutput.Name = "labelsOutput";
            this.labelsOutput.ReadOnly = true;
            this.labelsOutput.Size = new System.Drawing.Size(692, 646);
            this.labelsOutput.TabIndex = 0;
            this.labelsOutput.Text = "";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.consClear);
            this.tabPage3.Controls.Add(this.resetAGC);
            this.tabPage3.Controls.Add(this.AGCOutput);
            this.tabPage3.Controls.Add(this.AGCBinLoad);
            this.tabPage3.Controls.Add(this.Halt);
            this.tabPage3.Controls.Add(this.AGCStep);
            this.tabPage3.Controls.Add(this.AGCRunButton);
            this.tabPage3.Controls.Add(this.StepCheckBox);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Controls.Add(this.textBox5);
            this.tabPage3.Controls.Add(this.textBox6);
            this.tabPage3.Controls.Add(this.textBox3);
            this.tabPage3.Controls.Add(this.textBox4);
            this.tabPage3.Controls.Add(this.textBox2);
            this.tabPage3.Controls.Add(this.textBox1);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1001, 698);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "AGC";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // consClear
            // 
            this.consClear.Location = new System.Drawing.Point(334, 233);
            this.consClear.Name = "consClear";
            this.consClear.Size = new System.Drawing.Size(106, 27);
            this.consClear.TabIndex = 19;
            this.consClear.Text = "Clear console";
            this.consClear.UseVisualStyleBackColor = true;
            this.consClear.Click += new System.EventHandler(this.consClear_Click);
            // 
            // resetAGC
            // 
            this.resetAGC.Enabled = false;
            this.resetAGC.Location = new System.Drawing.Point(334, 200);
            this.resetAGC.Name = "resetAGC";
            this.resetAGC.Size = new System.Drawing.Size(106, 27);
            this.resetAGC.TabIndex = 18;
            this.resetAGC.Text = "resetAGC";
            this.resetAGC.UseVisualStyleBackColor = true;
            this.resetAGC.Click += new System.EventHandler(this.resetAGC_Click);
            // 
            // AGCOutput
            // 
            this.AGCOutput.Location = new System.Drawing.Point(579, 149);
            this.AGCOutput.Multiline = true;
            this.AGCOutput.Name = "AGCOutput";
            this.AGCOutput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.AGCOutput.Size = new System.Drawing.Size(380, 509);
            this.AGCOutput.TabIndex = 17;
            // 
            // AGCBinLoad
            // 
            this.AGCBinLoad.Location = new System.Drawing.Point(809, 70);
            this.AGCBinLoad.Name = "AGCBinLoad";
            this.AGCBinLoad.Size = new System.Drawing.Size(114, 30);
            this.AGCBinLoad.TabIndex = 16;
            this.AGCBinLoad.Text = "Load bin file";
            this.AGCBinLoad.UseVisualStyleBackColor = true;
            this.AGCBinLoad.Click += new System.EventHandler(this.AGCBinLoad_Click);
            // 
            // Halt
            // 
            this.Halt.Enabled = false;
            this.Halt.Location = new System.Drawing.Point(334, 164);
            this.Halt.Name = "Halt";
            this.Halt.Size = new System.Drawing.Size(106, 27);
            this.Halt.TabIndex = 15;
            this.Halt.Text = "Halt";
            this.Halt.UseVisualStyleBackColor = true;
            this.Halt.Click += new System.EventHandler(this.Halt_Click);
            // 
            // AGCStep
            // 
            this.AGCStep.Enabled = false;
            this.AGCStep.Location = new System.Drawing.Point(334, 131);
            this.AGCStep.Name = "AGCStep";
            this.AGCStep.Size = new System.Drawing.Size(106, 27);
            this.AGCStep.TabIndex = 14;
            this.AGCStep.Text = "Step...";
            this.AGCStep.UseVisualStyleBackColor = true;
            this.AGCStep.Click += new System.EventHandler(this.AGCStep_Click);
            // 
            // AGCRunButton
            // 
            this.AGCRunButton.Enabled = false;
            this.AGCRunButton.Location = new System.Drawing.Point(334, 98);
            this.AGCRunButton.Name = "AGCRunButton";
            this.AGCRunButton.Size = new System.Drawing.Size(106, 27);
            this.AGCRunButton.TabIndex = 13;
            this.AGCRunButton.Text = "Run...";
            this.AGCRunButton.UseVisualStyleBackColor = true;
            this.AGCRunButton.Click += new System.EventHandler(this.AGCRunButton_Click);
            // 
            // StepCheckBox
            // 
            this.StepCheckBox.AutoSize = true;
            this.StepCheckBox.Location = new System.Drawing.Point(334, 69);
            this.StepCheckBox.Name = "StepCheckBox";
            this.StepCheckBox.Size = new System.Drawing.Size(111, 21);
            this.StepCheckBox.TabIndex = 12;
            this.StepCheckBox.Text = "Step by Step";
            this.StepCheckBox.UseVisualStyleBackColor = true;
            this.StepCheckBox.CheckedChanged += new System.EventHandler(this.StepCheckBox_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(51, 210);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 17);
            this.label7.TabIndex = 11;
            this.label7.Text = "Reg Z";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(51, 182);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Reg FB";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(51, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Reg EB";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Reg Q";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Reg L";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Reg A";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(104, 149);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(109, 22);
            this.textBox5.TabIndex = 5;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(104, 121);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(109, 22);
            this.textBox6.TabIndex = 4;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(104, 205);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(109, 22);
            this.textBox3.TabIndex = 3;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(104, 177);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(109, 22);
            this.textBox4.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(104, 93);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(109, 22);
            this.textBox2.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(104, 65);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(109, 22);
            this.textBox1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.compileToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1005, 28);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.loadToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(120, 24);
            this.newToolStripMenuItem.Text = "New...";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.BNew_Click);
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(120, 24);
            this.loadToolStripMenuItem.Text = "Load...";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.BLoad_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(120, 24);
            this.saveToolStripMenuItem.Text = "Save...";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.BSave_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(120, 24);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // compileToolStripMenuItem
            // 
            this.compileToolStripMenuItem.Name = "compileToolStripMenuItem";
            this.compileToolStripMenuItem.Size = new System.Drawing.Size(86, 24);
            this.compileToolStripMenuItem.Text = "Compile...";
            this.compileToolStripMenuItem.Click += new System.EventHandler(this.BCompile_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(74, 24);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(62, 24);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // CompilerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 786);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CompilerForm";
            this.Text = "YUL Compiler";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BLoad;
        private System.Windows.Forms.Button BSave;
        private System.Windows.Forms.OpenFileDialog AGCFileLoad;
        private System.Windows.Forms.Button BCompile;
        private System.Windows.Forms.Button BNew;
        private System.Windows.Forms.TextBox OutputBox;
        private System.Windows.Forms.RichTextBox SourceBox;
        private System.Windows.Forms.Label sourceCodeLabel;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.RichTextBox labelsOutput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem compileToolStripMenuItem;
        private System.Windows.Forms.TabPage tabPage3;
        public System.Windows.Forms.SaveFileDialog AGCFileSave;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private TextBoxInterThread textBox5;
        private TextBoxInterThread textBox6;
        private TextBoxInterThread textBox3;
        private TextBoxInterThread textBox4;
        private TextBoxInterThread textBox2;
        private TextBoxInterThread textBox1;
        private System.Windows.Forms.Button AGCStep;
        private System.Windows.Forms.CheckBox StepCheckBox;
        private System.Windows.Forms.Button Halt;
        private System.Windows.Forms.Button AGCBinLoad;
        public System.Windows.Forms.TextBox AGCOutput;
        private System.Windows.Forms.Button AGCRunButton;
        private System.Windows.Forms.Button resetAGC;
        private System.Windows.Forms.Button consClear;
    }
}


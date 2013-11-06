using System.IO;
namespace YULCompiler
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.BCompile = new System.Windows.Forms.Button();
            this.BNew = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.RichTextBox();
            this.saveFileDialog2 = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // BLoad
            // 
            this.BLoad.Location = new System.Drawing.Point(103, 71);
            this.BLoad.Name = "BLoad";
            this.BLoad.Size = new System.Drawing.Size(56, 29);
            this.BLoad.TabIndex = 1;
            this.BLoad.Text = "Load...";
            this.BLoad.UseVisualStyleBackColor = true;
            this.BLoad.Click += new System.EventHandler(this.BLoad_Click);
            // 
            // BSave
            // 
            this.BSave.Location = new System.Drawing.Point(177, 71);
            this.BSave.Name = "BSave";
            this.BSave.Size = new System.Drawing.Size(56, 29);
            this.BSave.TabIndex = 2;
            this.BSave.Text = "Save...";
            this.BSave.UseVisualStyleBackColor = true;
            this.BSave.Click += new System.EventHandler(this.BSave_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "AGC File|*.agc";
            this.openFileDialog1.Tag = "";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "AGC File|*.agc";
            this.saveFileDialog1.Tag = "";
            // 
            // BCompile
            // 
            this.BCompile.Location = new System.Drawing.Point(257, 69);
            this.BCompile.Name = "BCompile";
            this.BCompile.Size = new System.Drawing.Size(58, 31);
            this.BCompile.TabIndex = 3;
            this.BCompile.Text = "Compile";
            this.BCompile.UseVisualStyleBackColor = true;
            this.BCompile.Click += new System.EventHandler(this.BCompile_Click);
            // 
            // BNew
            // 
            this.BNew.Location = new System.Drawing.Point(26, 71);
            this.BNew.Name = "BNew";
            this.BNew.Size = new System.Drawing.Size(57, 29);
            this.BNew.TabIndex = 4;
            this.BNew.Text = "New...";
            this.BNew.UseVisualStyleBackColor = true;
            this.BNew.Click += new System.EventHandler(this.BNew_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(378, 122);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(345, 254);
            this.textBox2.TabIndex = 5;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(38, 121);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(276, 486);
            this.textBox1.TabIndex = 6;
            this.textBox1.Text = "";
            // 
            // saveFileDialog2
            // 
            this.saveFileDialog2.Filter = "Binary File|*.bin";
            this.saveFileDialog2.Tag = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 639);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.BNew);
            this.Controls.Add(this.BCompile);
            this.Controls.Add(this.BSave);
            this.Controls.Add(this.BLoad);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "YUL Compiler";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BLoad;
        private System.Windows.Forms.Button BSave;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button BCompile;
        private System.Windows.Forms.Button BNew;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.RichTextBox textBox1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog2;
    }
}


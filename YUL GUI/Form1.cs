using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using nYUL;

namespace YULCompiler
{
    public partial class Form1 : Form
    {
        string AGCFile;
        string BINFile;
        TextWriter tmp = null;
        
        public Form1()
        {
            InitializeComponent();
            tmp = new TextBoxStreamWriter(textBox2);
            Console.SetOut(tmp);
        }

        private void BLoad_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try { textBox1.Text = File.ReadAllText(openFileDialog1.FileName);
                AGCFile = openFileDialog1.FileName;
                Console.WriteLine("File {0} loaded.", AGCFile);
                }
                catch (Exception ex){ }
            }
        }

        private string getNameOnly(string basestring)
        {
            string[] items;
            items = basestring.Split('\\');
            return items[items.Length-1];
        }

        private void BSave_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try { File.WriteAllText(saveFileDialog1.FileName, textBox1.Text);
                AGCFile = saveFileDialog1.FileName;
                AGCFile = getNameOnly(AGCFile);
                Console.WriteLine("File {0} saved.", AGCFile);
                }
                catch (Exception ex) { }
            }   
        }

        private void BCompile_Click(object sender, EventArgs e)
        {
            if(saveFileDialog2.ShowDialog() == DialogResult.OK)
            {
                if (AGCFile == "") { AGCFile = "default_agc"; }
                File.WriteAllText(AGCFile, textBox1.Text);
                try
                {
                    nYUL.YUL cpler = new YUL(AGCFile, saveFileDialog2.FileName);
                    int error = cpler.compile();
                    Console.WriteLine("File compiled with error : {0} \n", error);
                }
                catch (Exception ex)
                { }
            }
        }

        private void BNew_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            AGCFile = "";
        }
    }

    public class TextBoxStreamWriter : TextWriter
    {
        TextBox _output = null;

        public TextBoxStreamWriter(TextBox output)
        {
            _output = output;
        }

        public override void Write(char value)
        {
            base.Write(value);
            _output.AppendText(value.ToString()); // When character data is written, append it to the text box.
        }

        public override Encoding Encoding
        {
            get { return System.Text.Encoding.UTF8; }
        }
    }
}

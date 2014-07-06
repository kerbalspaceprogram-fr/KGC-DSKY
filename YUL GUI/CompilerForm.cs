using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AGC_DEBUG
{
    public partial class CompilerForm : Form
    {
        string AGCFile;
        public TextWriter YULOut = null;
        public TextWriter AGCOut = null;
        Boolean step = false;
        nAGC.AGC agc;
        Thread t;
        AGC_SUPPORT.Channels chan;
        public delegate void dg(int s);
        public delegate void dhalt();
        public dhalt haltlist;
        public dg List;
        string BinFile;

        public CompilerForm()
        {
            InitializeComponent();
            YULOut = new TextBoxStreamWriter(OutputBox);
            AGCOut = new TextBoxStreamWriter(AGCOutput);
            Console.SetOut(YULOut);
        }

        private void BLoad_Click(object sender, EventArgs e)
        {
            AGCFileLoad.FilterIndex = 1;
            if (AGCFileLoad.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    SourceBox.Text = File.ReadAllText(AGCFileLoad.FileName);
                    AGCFile = Path.GetFileName(AGCFileLoad.FileName);
                    Console.WriteLine("File {0} loaded.", AGCFile);
                }
                catch (Exception ex) { }
            }
        }

        private void BSave_Click(object sender, EventArgs e)
        {
            AGCFileSave.FilterIndex = 1;
            if (AGCFileSave.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    File.WriteAllText(AGCFileSave.FileName, SourceBox.Text);
                    AGCFile = Path.GetFileName(AGCFileSave.FileName);
                    Console.WriteLine("File {0} saved.", AGCFile);
                }
                catch (Exception ex) { }
            }
        }

        private void BCompile_Click(object sender, EventArgs e)
        {
            AGCFileSave.FilterIndex = 2;
            if (AGCFileSave.ShowDialog() == DialogResult.OK)
            {
                string BinFile = AGCFileSave.FileName;
                if (AGCFile == "") { AGCFile = "default_agc"; }
                File.WriteAllText(AGCFile, SourceBox.Text);
                try
                {
                    int error = 0;
                    nYUL.YUL cpler = new nYUL.YUL(AGCFile, BinFile);
                    if (error == 0)
                    {
                        error = cpler.compile();
                        Console.WriteLine("File compiled  successfully");
                        Console.WriteLine("Labels_" + AGCFile);
                        labelsOutput.Text = File.ReadAllText("Labels_" + AGCFile);
                    }
                }
                catch (Exception ex)
                { }
            }
        }

        private void BNew_Click(object sender, EventArgs e)
        {
            SourceBox.Text = "";
            OutputBox.Text = "";
            labelsOutput.Text = "";
            AGCFile = "";
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void StepCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            step = StepCheckBox.Checked;
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(tabControl1.SelectedIndex)
            {
                case 0: Console.SetOut(YULOut); break;
                case 2: Console.SetOut(AGCOut); break;
                default: break;
            }
        }

        private void AGCBinLoad_Click(object sender, EventArgs e)
        {
            AGCFileLoad.FilterIndex = 2;
            if(AGCFileLoad.ShowDialog() == DialogResult.OK)
            {
                BinFile = AGCFileLoad.FileName;
                Console.WriteLine("File {0} loaded.", Path.GetFileName(BinFile));
                initAGC();
            }
        }

        public void read_chan(int index)
        {
            TextBoxInterThread o = new TextBoxInterThread();
            switch(index)
            {
                case 0: o = textBox1; break;
                case 1: o = textBox2; break;
                case 2: o = textBox6; break;
                case 3: o = textBox5; break;
                case 4: o = textBox4; break;
                case 5: o = textBox3; break;
                case 6: t.Abort(); Console.WriteLine("AGC halted");
                    if(this.InvokeRequired)
                    {
                        haltlist = new dhalt(haltDebug);
                        this.Invoke(haltlist);
                    }
                    else { haltDebug(); }
                    break;
                default: break;
            }
            if (o.InvokeRequired)
            {
                int s = chan.get_chan(index);
                List = new dg(o.setBoxText);
                o.Invoke(List, s);
            }
            else
            { o.setBoxText(chan.get_chan(index)); }
        }

        private void haltDebug()
        {
            Halt.Enabled = false;
            AGCStep.Enabled = false;
            AGCBinLoad.Enabled = true;
            resetAGC.Enabled = true;
        }

        private void AGCRunButton_Click(object sender, EventArgs e)
        {
            Halt.Enabled = true;
            AGCStep.Enabled = step;
            resetAGC.Enabled = false;
            AGCBinLoad.Enabled = false;
            t = new Thread(() => agc.start(step));
            t.Start();
        }

        private void AGCStep_Click(object sender, EventArgs e)
        {
            agc.MCT();
        }

        private void Halt_Click(object sender, EventArgs e)
        {
            if (t.IsAlive)
            { t.Abort(); }
            if(agc.isRunning())
            { agc.Halt(); }
            Halt.Enabled = false;
            AGCStep.Enabled = false;
            resetAGC.Enabled = true;
            AGCBinLoad.Enabled = true;
        }

        private void resetAGC_Click(object sender, EventArgs e)
        {
            initAGC();
            resetAGC.Enabled = false;
        }

        public void initAGC()
        {
            chan = new AGC_SUPPORT.Channels();
            chan.regDelegate(this, read_chan);
            agc = new nAGC.AGC(BinFile, chan);
            agc.setDebug(true);
            AGCRunButton.Enabled = true;
        }

        private void consClear_Click(object sender, EventArgs e)
        {
            AGCOutput.Text = "";
        }
    }

    public class TextBoxInterThread : TextBox
    {
        public delegate void del(string s);
        public del dList;

        public void setBoxText(int s)
        {
            this.Text = string.Format("{0:X}",s);
        }
    }

    public class TextBoxStreamWriter : TextWriter
    {
        TextBox _output = null;
        public delegate void d(string s);
        public d List;

        public TextBoxStreamWriter(TextBox output)
        {
            _output = output;
        }

        public override void Write(char value)
        {
            base.Write(value);
            if (_output.InvokeRequired)
            {
                string s = value.ToString();
                List = new d(_output.AppendText);
                _output.Invoke(List, s);
            }
            else
            {
                _output.AppendText(value.ToString());
            }
        }

        public override Encoding Encoding
        {
            get { return System.Text.Encoding.UTF8; }
        }
    }
}

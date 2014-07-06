using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.IO;
using AGC_SUPPORT;
using nAGC;
using DSKY = nDSKY.tDSKY;
using nYUL;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
           /* sWord wword = new sWord((ushort)11, false);
            ushort i = wword.getHex();
            byte[] b = wword.getWord();
            sWord wcyr = new sWord(wword.CYR(), false);
            sWord wcyl = new sWord(wword.CYL(), false);
            sWord wshr = new sWord(wword.SHR(), false);
            sWord wcpl = new sWord(wword.CPL(), false);
            sWord wshl = new sWord(wword.SHL(), false); 
            Console.WriteLine("Init word : {0} :: {1}", wword.getHexS(), wword.getBinS());
            Console.WriteLine("CYR : {0} :: {1}", wcyr.getHexS(), wcyr.getBinS());
            Console.WriteLine("CYL : {0} :: {1}", wcyl.getHexS(), wcyl.getBinS());
            Console.WriteLine("SHR : {0} :: {1}", wshr.getHexS(), wshr.getBinS());
            Console.WriteLine("CPL : {0} :: {1}", wcpl.getHexS(), wcpl.getBinS());
            Console.WriteLine("SHL : {0} :: {1}", wshl.getHexS(), wshl.getBinS());
            Console.ReadLine();*/
            YUL cp = new YUL("AGC_Test.agc", "AGC_Bin.bin");
            int err = cp.compile();
            if (err == 0)
            {
                Console.WriteLine("File Compiled with output : {0}", err);
            }
            Console.ReadLine();
            Channels chan = new Channels();
            AGC agc = new AGC("AGC_Bin.bin", chan);
            DSKY dsky = new DSKY(chan);
            Thread t = new Thread(() => agc.start(false));
            Thread d = new Thread(dsky.DStart);
            d.Start();
            t.Start();
            /*while (true)
            {
                String inp = Console.ReadLine();
                string[] items = inp.Split(' ');
                if (items[0] != "exit")
                {
                    switch(items[0])
                    { case "DSKY" :
                            dsky.write_chan(Int32.Parse(items[1], System.Globalization.NumberStyles.Integer), (ushort)Int16.Parse(items[2], System.Globalization.NumberStyles.Integer));
                            break;
                        case "AGC" :
                            agc.write_chan(Int32.Parse(items[1], System.Globalization.NumberStyles.Integer), (ushort)Int16.Parse(items[2], System.Globalization.NumberStyles.Integer));
                            break;
                        default: Console.WriteLine("Invalid command"); break;
                    }
                }
                else { break; }
            }*/
            Console.ReadLine();
            d.Abort();
            t.Abort();
        }
    }
}

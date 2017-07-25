using DHCP_Gen.Classes;
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
using System.Xml;
using System.Xml.Serialization;

namespace DHCP_Gen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void __writeXml() {
            List<Range> r = new List<Range>();

            r.Add(new Range("test1","test",0,5));

            XmlSerializer ser = new XmlSerializer(r.GetType());
            StringWriter sw = new StringWriter();
            XmlTextWriter tw = new XmlTextWriter(sw);
            ser.Serialize(tw, r);
            File.WriteAllText("test.xml", sw.ToString());
            richTextBox1.AppendText(sw.ToString());

        }

        private void button1_Click(object sender, EventArgs e)
        {
            __writeXml();
        }
    }
}

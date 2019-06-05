using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.IO;
using System.Xml.Linq;

namespace QL_NHAHANG
{
    public partial class frmHuongDanSuDung : Form
    {
        public frmHuongDanSuDung()
        {
            InitializeComponent();
        }
        

        string fileName = "HuongDanSuDung.xml";
        private void button1_Click(object sender, EventArgs e)
        {
            
            XElement xel = XElement.Load(fileName);

            foreach (XElement xmlE in xel.Elements("huongdan"))
            {
                if (xmlE.Attribute("hdsd").Value.ToString() == "sudung")
                {
                    foreach (XElement i in xmlE.Elements("hd"))
                    {
                        listBox1.Items.Add(i.Value);
                    }
                }
                
            }       
        }
    }
}

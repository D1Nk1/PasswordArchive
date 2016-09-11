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

namespace WindowsFormsApplication1
{

    public partial class Form2 : Form
    {

        XmlDocument xmlDoc = new XmlDocument();

        public Form2()
        {
            InitializeComponent();
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            xmlDoc.Load("XMLFile1.xml");
            XmlNodeList siteNodes = xmlDoc.SelectNodes("//body/site");
            foreach (XmlNode siteNode in siteNodes)
            {
                string name = siteNode.Attributes["name"].Value;
                comboBox1.Items.Add(name);
                comboBox1.SelectedIndex = 0;
            }
        }

        private void comboBox1_SelectedIndexChange(object sender, EventArgs e)
        {
          comboBox1.GetItemText(comboBox1.SelectedItem);
                        
        }
        private void button1_Click(object sender, EventArgs e)
        {
            XmlNode singlelogin = xmlDoc.SelectSingleNode("//body/site[@name = '" + comboBox1.GetItemText(comboBox1.SelectedItem) + "']/login");
            XmlNode singlepassword = xmlDoc.SelectSingleNode("//body/site[@name = '" + comboBox1.GetItemText(comboBox1.SelectedItem) + "']/password");
            textBox1.Text = singlelogin.InnerText;
            pwdlst.Text = singlepassword.InnerText;
            
    }

        private void button2_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(pwdlst.Text);
        }


    }
}

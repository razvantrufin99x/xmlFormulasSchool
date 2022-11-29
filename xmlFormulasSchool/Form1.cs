using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace xmlFormulasSchool
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CreateXml();
        }


        public void CreateXml()
        {
            
      



            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Indent = true;
            using (XmlWriter writer = XmlWriter.Create(txtFileName.Text+".xml", settings))
            {
                writer.WriteStartElement("formulaName");
                writer.WriteElementString("denumire", txtFormulaName.Text);
                writer.WriteElementString("domain", txtDomain.Text);
                writer.WriteElementString("formula", txtFormula.Text);
            if (txtp1.Text != "")
                {
                    writer.WriteElementString("param1", txtp1.Text);
                    writer.WriteElementString("explicatia1", exp1.Text);
                    writer.WriteElementString("datatypeparam1", txtdt1.Text);
                
                }
            if (txtp2.Text != "")
                {
                    writer.WriteElementString("param2", txtp2.Text);
                    writer.WriteElementString("explicatia2", exp2.Text);
                    writer.WriteElementString("datatypeparam2", txtdt2.Text);
                } if (txtp3.Text != "")
                {
                writer.WriteElementString("param3", txtp3.Text);
                writer.WriteElementString("explicatia3", exp3.Text);
                writer.WriteElementString("datatypeparam3", txtdt3.Text);
                } 
                if (txtp4.Text != "")
                {
                writer.WriteElementString("param4", txtp4.Text);
                writer.WriteElementString("explicatia4", exp4.Text);
                writer.WriteElementString("datatypeparam4", txtdt4.Text);
                }
                if (txtp5.Text != "")
                {
                writer.WriteElementString("param5", txtp5.Text);
                writer.WriteElementString("explicatia5", exp5.Text);
                writer.WriteElementString("datatypeparam5", txtdt5.Text);
                }
                if (txtp6.Text != "")
                {
                writer.WriteElementString("param6", txtp6.Text);
                writer.WriteElementString("explicatia6", exp6.Text);
                writer.WriteElementString("datatypeparam6", txtdt6.Text);
                }
                if (txtp7.Text != "")
                {
                writer.WriteElementString("param7", txtp7.Text);
                writer.WriteElementString("explicatia7", exp7.Text);
                writer.WriteElementString("datatypeparam7", txtdt7.Text);
                }
                if (txtp8.Text != "")
                {
                writer.WriteElementString("param8", txtp8.Text);
                writer.WriteElementString("explicatia8", exp8.Text);
                writer.WriteElementString("datatypeparam8", txtdt8.Text);
                }
                if (txtp9.Text != "")
                {
                writer.WriteElementString("param9", txtp9.Text);
                writer.WriteElementString("explicatia9", exp9.Text);
                writer.WriteElementString("datatypeparam9", txtdt9.Text);
                }
                if (txtp10.Text != "")
                {
                writer.WriteElementString("param10", txtp10.Text);
                writer.WriteElementString("explicatia10", exp10.Text);
                writer.WriteElementString("datatypeparam10", txtdt10.Text);
                }
                writer.WriteEndElement();
            }


            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

    }
}

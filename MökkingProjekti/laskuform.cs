using iTextSharp.text;
using iTextSharp.text.pdf;
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

namespace MökkingProjekti
{
    public partial class laskuform : Form
    {
        public laskuform()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("rivi 1 :" + textBox1.Text);
            sb.AppendLine("rivi2 :" + textBox2.Text);
            sb.AppendLine("rivi 3 :" + textBox3.Text);
            sb.AppendLine("rivi 4 :" + textBox4.Text);
            sb.AppendLine("rivi 5 :" + textBox5.Text);

            Document document = new Document();
            PdfWriter.GetInstance(document, new FileStream(@"C:\Users\ramia\Downloads\lasku.pdf", FileMode.Create));
            document.Open();

            Paragraph paragraph = new Paragraph();
            paragraph.Alignment = Element.ALIGN_LEFT;
            paragraph.Add(new Chunk(sb.ToString()));

            document.Add(paragraph);
            document.Close();

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace MökkingProjekti
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
            Functions.ifkysymys(Functions.getpath());
            haetaulu();
        }
        

        public void haetaulu()
        {
            //hakee datagridiin tiedot comboboxin kirjoituksen perusteella
            string taulunimi = taulunimicb.Text;
            DataSet tauludata = Functions.paivitadatagrid(taulunimi);
            dataGridView1.DataSource = tauludata.Tables[taulunimi];
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void taulunimicb_SelectedIndexChanged(object sender, EventArgs e)
        {
            haetaulu();
            //muuttaa comboboxissa olevan sanan labelin nimeksi, ja muuttaa ensimmäisen kirjaimen isoksi.
            string taulunnimi = taulunimicb.Text;
            taulunnimi = char.ToUpper(taulunnimi[0]) + taulunnimi.Substring(1);
            taulunimi.Text = taulunnimi;
        }

        private void laskubtn_Click(object sender, EventArgs e)
        {
            Form laskuform = new laskuform();
            laskuform.ShowDialog();
        }

        private void lisaabtn_Click(object sender, EventArgs e)
        {

        }

        private void tietokannanTiedostopolkuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Functions.folderpath(Functions.getpath());
        }

        private void btreservation_Click(object sender, EventArgs e)
        {
            bool allTextboxesFilled = true;
            foreach (Control control in Pvaraus.Controls)
            {
                if (control is TextBox && string.IsNullOrEmpty((control as TextBox).Text))
                {
                    if (control is ComboBox && string.IsNullOrEmpty((control as ComboBox).Text))
                    {
                        if (control is DateTimePicker && (control as DateTimePicker).Value == DateTimePicker.MinimumDateTime) 
                        {
                            allTextboxesFilled = false;
                            break;
                        }
                            
                    }
                    
                }
            }
            if (allTextboxesFilled)
            {
                MessageBox.Show("yes");
            }
            else
            {
                MessageBox.Show("no");
            }
        }
    }
}

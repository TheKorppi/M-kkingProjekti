using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
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
    }
}

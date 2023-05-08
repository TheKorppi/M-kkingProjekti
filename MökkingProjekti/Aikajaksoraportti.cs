using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MökkingProjekti
{
    public partial class Aikajaksoraportti : Form
    {
        public Aikajaksoraportti()
        {
            InitializeComponent();
        }

        private void aikajaksopanel_Click(object sender, EventArgs e)
        {
            
        }

        private void Aikajaksoraportti_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mokkingDBDataSet.alue' table. You can move, or remove it, as needed.
            this.alueTableAdapter.Fill(this.mokkingDBDataSet.alue);

        }

        private void aikajaksoetsibtn_Click(object sender, EventArgs e)
        {
            DateTime alkamispaiva = alkamispvmdatetime.Value.Date;
            DateTime paattymispaiva = paattymispaivadatetime.Value.Date;
            string aluenimi = aikaraportticb.Text;

            //Esittää majoitustiedot
            if (majoittumisetradio.Checked == true)
            {               
                string taulunimi = "varausview";
                DataSet tauludata = Functions.paivitadatagrid(taulunimi, alkamispaiva, paattymispaiva, aluenimi);
                aikajaksoraporttidgv.DataSource = tauludata.Tables[taulunimi];
            }

            //Esittää lisäpalvelut
            else
            {
                string taulunimi = "palveluview";
                DataSet tauludata = Functions.paivitadatagrid(taulunimi, alkamispaiva, paattymispaiva, aluenimi);
                aikajaksoraporttidgv.DataSource = tauludata.Tables[taulunimi];
            }
        }

        private void alkamispvmdatetime_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Aikajaksoraportti_KeyUp(object sender, KeyEventArgs e) //sulkee kyseisen formin pikanäppäimellä ESC
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}

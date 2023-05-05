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
            haetaulu("asiakas");
        }
        

        public void haetaulu(string taulunimi)
        {
            //hakee datagridiin tiedot comboboxin kirjoituksen perusteella
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
            
            //muuttaa comboboxissa olevan sanan labelin nimeksi, ja muuttaa ensimmäisen kirjaimen isoksi.
            string taulunnimi = toolStrip1.Text;
            switch (taulunnimi.ToString())
            {
                case "varaus":
                    Pvaraus.Enabled = true;
                    Pvaraus.Visible = true;
                    Ppalvelu.Enabled = false;
                    Ppalvelu.Visible = false;
                    Pmokki.Enabled = false;
                    Pmokki.Visible = false;
                    Plasku.Enabled = false;
                    Plasku.Visible = false;
                    Pasiakas.Enabled = false;
                    Pasiakas.Visible = false;
                    Palue.Enabled = false;
                    Palue.Visible = false;
                    break;

                case "alue":
                    Pvaraus.Enabled = false;
                    Pvaraus.Visible = false;
                    Ppalvelu.Enabled = false;
                    Ppalvelu.Visible = false;
                    Pmokki.Enabled = false;
                    Pmokki.Visible = false;
                    Plasku.Enabled = false;
                    Plasku.Visible = false;
                    Pasiakas.Enabled = false;
                    Pasiakas.Visible = false;
                    Palue.Enabled = true;
                    Palue.Visible = true;
                    break;

                case "palvelu":
                    Pvaraus.Enabled = false;
                    Pvaraus.Visible = false;
                    Ppalvelu.Enabled = true;
                    Ppalvelu.Visible = true;
                    Pmokki.Enabled = false;
                    Pmokki.Visible = false;
                    Plasku.Enabled = false;
                    Plasku.Visible = false;
                    Pasiakas.Enabled = false;
                    Pasiakas.Visible = false;
                    Palue.Visible = false;
                    Palue.Visible = false;
                    break;

                case "mokki":
                    Pvaraus.Enabled = false;
                    Pvaraus.Visible = false;
                    Ppalvelu.Enabled = false;
                    Ppalvelu.Visible = false;
                    Pmokki.Enabled = true;
                    Pmokki.Visible = true;
                    Plasku.Enabled = false;
                    Plasku.Visible = false;
                    Pasiakas.Enabled = false;
                    Pasiakas.Visible = false;
                    Palue.Visible = false;
                    Palue.Enabled = false;
                    break;

                case "lasku":
                    Pvaraus.Enabled = false;
                    Pvaraus.Visible = false;
                    Ppalvelu.Enabled = false;
                    Ppalvelu.Visible = false;
                    Pmokki.Enabled = false;
                    Pmokki.Visible = false;
                    Plasku.Enabled = true;
                    Plasku.Visible = true;
                    Pasiakas.Enabled = false;
                    Pasiakas.Visible = false;
                    Palue.Enabled = false;
                    Palue.Visible = false;
                    break;

                case "asiakas":
                    Pvaraus.Enabled = false;
                    Pvaraus.Visible = false;
                    Ppalvelu.Enabled = false;
                    Ppalvelu.Visible = false;
                    Pmokki.Enabled = false;
                    Pmokki.Visible = false;
                    Plasku.Enabled = false;
                    Plasku.Visible = false;
                    Pasiakas.Enabled = true;
                    Pasiakas.Visible = true;
                    Palue.Enabled = false;
                    Palue.Visible = false;
                    break;

            }
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

       

        private void Pvaraus_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void aikajaksobtn_Click(object sender, EventArgs e)
        {
            Form aikajaksoraportti = new Aikajaksoraportti();
            aikajaksoraportti.ShowDialog();
        }

        private void tsbtnalueetjamökit_Click(object sender, EventArgs e)
        {
            Pvaraus.Enabled = false;
            Pvaraus.Visible = false;
            Ppalvelu.Enabled = false;
            Ppalvelu.Visible = false;
            Pmokki.Enabled = false;
            Pmokki.Visible = false;
            Plasku.Enabled = false;
            Plasku.Visible = false;
            Pasiakas.Enabled = false;
            Pasiakas.Visible = false;
            Palue.Enabled = true;
            Palue.Visible = true;
            haetaulu("mokki");
            
        }

        private void tsbtnasiakkaat_Click(object sender, EventArgs e)
        {
            Pvaraus.Enabled = false;
            Pvaraus.Visible = false;
            Ppalvelu.Enabled = false;
            Ppalvelu.Visible = false;
            Pmokki.Enabled = false;
            Pmokki.Visible = false;
            Plasku.Enabled = false;
            Plasku.Visible = false;
            Pasiakas.Enabled = true;
            Pasiakas.Visible = true;
            Palue.Enabled = false;
            Palue.Visible = false;
            haetaulu("asiakas");
            
        }

        private void tsbtnvaraukset_Click(object sender, EventArgs e)
        {
            Pvaraus.Enabled = true;
            Pvaraus.Visible = true;
            Ppalvelu.Enabled = false;
            Ppalvelu.Visible = false;
            Pmokki.Enabled = false;
            Pmokki.Visible = false;
            Plasku.Enabled = false;
            Plasku.Visible = false;
            Pasiakas.Enabled = false;
            Pasiakas.Visible = false;
            Palue.Enabled = false;
            Palue.Visible = false;
            haetaulu("varaus");
        }

        private void tsbtnlaskut_Click(object sender, EventArgs e)
        {
            Pvaraus.Enabled = false;
            Pvaraus.Visible = false;
            Ppalvelu.Enabled = false;
            Ppalvelu.Visible = false;
            Pmokki.Enabled = false;
            Pmokki.Visible = false;
            Plasku.Enabled = true;
            Plasku.Visible = true;
            Pasiakas.Enabled = false;
            Pasiakas.Visible = false;
            Palue.Enabled = false;
            Palue.Visible = false;
            haetaulu("lasku");
        }

        private void tsbtnpalvelut_Click(object sender, EventArgs e)
        {
            Pvaraus.Enabled = false;
            Pvaraus.Visible = false;
            Ppalvelu.Enabled = true;
            Ppalvelu.Visible = true;
            Pmokki.Enabled = false;
            Pmokki.Visible = false;
            Plasku.Enabled = false;
            Plasku.Visible = false;
            Pasiakas.Enabled = false;
            Pasiakas.Visible = false;
            Palue.Visible = false;
            Palue.Visible = false;
            haetaulu("palvelu");
        }

        private void jotainToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Functions.folderpath(Functions.getpath());
        }

        private void suljeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult vastaus = MessageBox.Show("Haluatko varmasti sulkea ohjelman?", "Vahvista", MessageBoxButtons.YesNo);

            if (vastaus == DialogResult.Yes)
            {
                Application.Exit();
            }
            else if (vastaus == DialogResult.No)
            {
                // this.Close();
            }
        }

        private void btnasiakaslisaa_Click(object sender, EventArgs e)
        {

        }

        private void btnmuokkaa_Click(object sender, EventArgs e)
        {

        }

        private void btnasiakasperuuta_Click(object sender, EventArgs e)
        {

        }

        private void btnpoistaasiakas_Click(object sender, EventArgs e)
        {

        }




        private void btnlisaalasku_Click(object sender, EventArgs e)
        {

        }

        private void btnperuutalasku_Click(object sender, EventArgs e)
        {

        }

        private void btnmuokkaalasku_Click(object sender, EventArgs e)
        {

        }

        private void btnpoistalasku_Click(object sender, EventArgs e)
        {

        }

       

        private void btnmuokkaaalue_Click(object sender, EventArgs e)
        {

        }

        private void btnlisaaalue_Click(object sender, EventArgs e)
        {

        }

        private void btnperuutaalue_Click(object sender, EventArgs e)
        {

        }

        private void btnpoistaalue_Click(object sender, EventArgs e)
        {

        }



        private void btnlisaapalvelu_Click(object sender, EventArgs e)
        {

        }

        private void btnmuokkaapalvelu_Click(object sender, EventArgs e)
        {

        }

        private void btnperuutapalvelu_Click(object sender, EventArgs e)
        {

        }

        private void btnpoistapalvelu_Click(object sender, EventArgs e)
        {

        }




        private void btnmuokkaavaraus_Click(object sender, EventArgs e)
        {

        }

        private void btnperuutavaraus_Click(object sender, EventArgs e)
        {

        }

        private void btnpoistavaraus_Click(object sender, EventArgs e)
        {

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

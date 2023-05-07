﻿using System;
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
        public string mode="asiakas";
       
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
            switch (mode)
            {
                case "asiakas":
                   
                   tbasiakasnimi.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                   tbasiakassnimi.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                   tbasiakaspuhnum.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                   tbasiakassposti.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                   tbasiakasosoite.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                   tbasiakaspostinum.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
                   break;

                case "a":
                    break;

            }
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

        private void laskubtn_Click(object sender, EventArgs e) // aukasee LASKUT formin
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

        private void aikajaksobtn_Click(object sender, EventArgs e) // aukasee aikajaksoRAPORTIT formille 
        {
            Form aikajaksoraportti = new Aikajaksoraportti();
            aikajaksoraportti.ShowDialog();
        }


        // toolstrip painikkeesta aukasee ALUEET JA MÖKIT paneelin ja sulkee muut
        private void tsbtnalueetjamökit_Click(object sender, EventArgs e)
        {
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
            Palue.Enabled = true;
            Palue.Visible = true;
            haetaulu("mokki");
            mode = "mokki";
            taulunimi.Text = "Mökit";
            
        }

        // toolstrip painikkeesta aukasee ASIAKKAAAAT paneelin ja sulkee muut
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
            mode = "asiakas";
            taulunimi.Text = "Asiakkat";
        }


        // toolstrip painikkeesta aukasee VARAUKSET paneelin ja sulkee muut
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
            mode = "varaus";
            taulunimi.Text = "Varaukset";
        }

        // toolstrip painikkeesta aukasee LASKUT paneelin ja sulkee muut
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
            mode = "lasku";
            taulunimi.Text = "Laskut";
        }


        // toolstrip painikkeesta aukasee PALVELUT paneelin ja sulkee muut
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
            mode = "palvelu";
            taulunimi.Text = "Palvelu";
        }


        // aukasee käyttäjän koneelta tiedostopolun ohjelmiston tietokannalle 
        private void jotainToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Functions.folderpath(Functions.getpath());
        }

        private void suljeToolStripMenuItem_Click(object sender, EventArgs e) // sulkee ohjelman 
        {
            DialogResult vastaus = MessageBox.Show("Haluatko varmasti sulkea ohjelman?", "Vahvista", MessageBoxButtons.YesNo);
            
            // tekee varmistuksen sulkemiselle,
            if (vastaus == DialogResult.Yes)  // KYLLÄ sulkee ohjelman
            {
                Application.Exit();
            }
            else if (vastaus == DialogResult.No) // EI jatkaa ohjelmaa
            {
                // this.Close();
            }
        }


        // asiakas paneelin painikkeet 

        private void btnasiakaslisaa_Click(object sender, EventArgs e)
        {
            Functions.lisaaasiakas(tbasiakasnimi.Text, tbasiakassnimi.Text, tbasiakaspuhnum.Text, tbasiakassposti.Text, tbasiakasosoite.Text, tbasiakaspostinum.Text);
            haetaulu(mode);
        }

        private void btnmuokkaa_Click(object sender, EventArgs e)
        {

        }

        private void btnasiakasperuuta_Click(object sender, EventArgs e)
        {
            tbasiakasnimi.Clear();
            tbasiakassnimi.Clear();
            tbasiakaspuhnum.Clear();
            tbasiakassposti.Clear();
            tbasiakasosoite.Clear();
            tbasiakaspostinum.Clear();
        } //    TYHJENTÄÄ KYSEISEN PANEELIN TEKSTIKENTÄT

        private void btnpoistaasiakas_Click(object sender, EventArgs e)
        {
            Functions.poistaasiakas(tbasiakasnimi.Text, tbasiakassnimi.Text, tbasiakaspuhnum.Text, tbasiakassposti.Text, tbasiakasosoite.Text, tbasiakaspostinum.Text);
            haetaulu(mode);
        }



        // Lasku paneelin painikkeet

        private void btnlisaalasku_Click(object sender, EventArgs e)
        {

        }

        private void btnperuutalasku_Click(object sender, EventArgs e)
        {
            tblaskusvarausid.Clear();
            tblaskusumma.Clear();
            tblaskualv.Clear();
        }//TYHJENTÄÄ KYSEISEN PANEELIN TEKSTIKENTÄT

        private void btnmuokkaalasku_Click(object sender, EventArgs e)
        {

        }

        private void btnpoistalasku_Click(object sender, EventArgs e)
        {

        }


       // alue paneelin painikkeet

        private void btnmuokkaaalue_Click(object sender, EventArgs e)
        {

        }

        private void btnlisaaalue_Click(object sender, EventArgs e)
        {

        }

        private void btnperuutaalue_Click(object sender, EventArgs e) //TYHJENTÄÄ KYSEISEN PANEELIN TEKSTIKENTÄT
        {
            tbaluenimi.Clear();
        }

        private void btnpoistaalue_Click(object sender, EventArgs e)
        {

        }


        // Palvelu paneelin painikkeet

        private void btnlisaapalvelu_Click(object sender, EventArgs e)
        {

        }

        private void btnmuokkaapalvelu_Click(object sender, EventArgs e)
        {

        }

        private void btnperuutapalvelu_Click(object sender, EventArgs e) // TYHJENTÄÄ KYSEISEN PANEELIN TEKSTIKENTÄT
        {
            tbpalvelunimi.Clear();
            tbpalvelutyyppi.Clear();
            tbpalvelukuvaus.Clear();
            tbpalvelualv.Clear();
            tbpalveluhinta.Clear();
        }

        private void btnpoistapalvelu_Click(object sender, EventArgs e)
        {

        }


        // varaus paneelin painikkeet

        private void btnmuokkaavaraus_Click(object sender, EventArgs e)
        {

        }

        private void btnperuutavaraus_Click(object sender, EventArgs e) //TYHJENTÄÄ KYSEISEN PANEELIN TEKSTIKENTÄT
        {
            tbvarausetunimi.Clear();
            tbvaraussukunimi.Clear();
            tbvaraussahkoposti.Clear();
            tbvarauspuhelinnumero.Clear();
            tbvaraajanosoite.Clear();
            tbvaraajanpostinumero.Clear();
            dtplahtopaiva.Value = DateTime.Today;
            dtptulopaiva.Value = DateTime.Today;
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

        
        // mökki paneelin painikkeet

        private void btnperuutamokki_Click(object sender, EventArgs e)
        {
            tbmokkialuenimi.Clear();
            tbmokkinimi.Clear();
            tbmokkiosoite.Clear();
            tbmokkipostinumero.Clear();
            tbmokkivarustelu.Clear();
            tbmokkikuvaus.Clear();
            tbmokkihinta.Clear();
        }  // TYHJENTÄÄ KYSEISEN PANEELIN TEKSTIKENTÄT

        private void btnlisaamokki_Click(object sender, EventArgs e)
        {

        }

        private void btnmuokkaamokki_Click(object sender, EventArgs e)
        {

        }

        private void btnpoistamokki_Click(object sender, EventArgs e)
        {

        }






        private void Plasku_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

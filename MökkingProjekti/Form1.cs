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
        public string mode="asiakas";
        public int ID = 0;
        public int IDhelp = 0;
        public bool haku = true;

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
        public void haeaputaulu(string taulunimi)
        {
            //hakee datagridiin tiedot comboboxin kirjoituksen perusteella
            DataSet tauludata = Functions.paivitadatagrid(taulunimi);
            dataGridView2.DataSource = tauludata.Tables[taulunimi];
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
                    ID = (int)dataGridView1.Rows[e.RowIndex].Cells[0].Value;
                    break;

                case "varaus":
                    //tbvarausetunimi.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                    //tbvaraussukunimi.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                    //tbvarauspuhelinnumero.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                    //tbvaraussahkoposti.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                    //tbvaraajanosoite.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                    //tbvaraajanpostinumero.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
                    //ID = (int)dataGridView1.Rows[e.RowIndex].Cells[0].Value;
                   
                    
                    if (haku)
                    {
                        tbvarausetunimi.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                        tbvaraussukunimi.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                        tbvarauspuhelinnumero.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                        tbvaraussahkoposti.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                        tbvaraajanosoite.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                        tbvaraajanpostinumero.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
                        ID = (int)dataGridView1.Rows[e.RowIndex].Cells[0].Value;
                        haetaulu("varaus");
                        haku = false;
                    }
                    else
                    {
                        ID = (int)dataGridView1.Rows[e.RowIndex].Cells[0].Value;
                    }
                    break;

                case "palvelu":
                    tbpalvelunimi.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                    tbpalvelutyyppi.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                    tbpalvelukuvaus.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                    tbpalveluhinta.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                    ID = (int)dataGridView1.Rows[e.RowIndex].Cells[0].Value;
                    break;

                case "mokki":
                    tbmokkialuenimi.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                    tbmokkinimi.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                    tbmokkiosoite.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                    tbmokkipostinumero.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                    tbmokkivarustelu.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
                    tbmokkikuvaus.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
                    tbmokkihinta.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                    tbmokkihenkilomaara.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
                    ID = (int)dataGridView1.Rows[e.RowIndex].Cells[0].Value;
                    break;


                case "lasku":
                    tblaskualv.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                    tblaskusumma.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                    tblaskusvarausid.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                    ID = (int)dataGridView1.Rows[e.RowIndex].Cells[0].Value;
                    break;


            }
        }
        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            switch (mode)
            {               
                case "varaus":

                    IDhelp = (int)dataGridView2.Rows[e.RowIndex].Cells[0].Value;
                    cbalue.Text = dataGridView2.Rows[e.RowIndex].Cells[1].Value.ToString();
                    cbmokki.Text = dataGridView2.Rows[e.RowIndex].Cells[0].Value.ToString();
                    //haetaulu("varaus");
                    break;

                case "palvelu":
                    cmbpalvelualue.Text = dataGridView2.Rows[e.RowIndex].Cells[0].Value.ToString();
                    IDhelp = (int)dataGridView2.Rows[e.RowIndex].Cells[0].Value;
                    break;

                case "mokki":
                    tbaluenimi.Text = dataGridView2.Rows[e.RowIndex].Cells[1].Value.ToString();
                    IDhelp = (int)dataGridView2.Rows[e.RowIndex].Cells[0].Value;
                   
                    break;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ToolTip toolTip1 = new ToolTip();

            // Set up the delays for the ToolTip.
            toolTip1.AutoPopDelay = 5000;
            toolTip1.InitialDelay = 1000;
            toolTip1.ReshowDelay = 500;
            // Force the ToolTip text to be displayed whether or not the form is active.
            toolTip1.ShowAlways = true;
            toolTip1.SetToolTip(this.btnasiakaslisaa, "Lisää asiakas Tauluun");
            toolTip1.SetToolTip(this.btnasiakasperuuta, "Tyhjennä Laatikot");
            toolTip1.SetToolTip(this.btnmuokkaa, "Muokkaa Taulukosta Valittua Asiakasta");
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
            haeaputaulu("alue");
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
            haetaulu("asiakas");
            haeaputaulu("mokkihelp");
            mode = "varaus";
            taulunimi.Text = "Varaukset";
            haku = true;
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
            dataGridView1.DataSource = null;
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
            dataGridView1.DataSource = null;
            haetaulu("palvelu");
            haeaputaulu("alue");
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
            Functions.paivatiaasiakas(tbasiakasnimi.Text, tbasiakassnimi.Text, tbasiakaspuhnum.Text, tbasiakassposti.Text, tbasiakasosoite.Text, tbasiakaspostinum.Text, ID);
            haetaulu("asiakas");
            //DataSet dataa = Functions.haetieto(tbasiakasnimi.Text, tbasiakassnimi.Text, tbasiakaspuhnum.Text, tbasiakassposti.Text, tbasiakasosoite.Text, tbasiakaspostinum.Text, "asiakas");
            //dataGridView1.DataSource = dataa.Tables["asiakas"];
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
            Functions.lisaalasku(tblaskusvarausid.Text, tblaskusumma.Text, tblaskualv.Text);
            haetaulu("lasku");
        }

        private void btnperuutalasku_Click(object sender, EventArgs e)
        {
            tblaskusvarausid.Clear();
            tblaskusumma.Clear();
            tblaskualv.Clear();
        }//TYHJENTÄÄ KYSEISEN PANEELIN TEKSTIKENTÄT

        private void btnmuokkaalasku_Click(object sender, EventArgs e)
        {
            Functions.paivitalasku(tblaskusvarausid.Text, tblaskusumma.Text, tblaskualv.Text, ID);
            haetaulu("lasku");
        }

        private void btnpoistalasku_Click(object sender, EventArgs e)
        {
            Functions.poistalasku(tblaskusvarausid.Text, tblaskusumma.Text, tblaskualv.Text);
            haetaulu("lasku");


            
        }


       // alue paneelin painikkeet

        private void btnmuokkaaalue_Click(object sender, EventArgs e)
        {
            Functions.paivitaalue(tbaluenimi.Text, IDhelp);
            haeaputaulu("alue");

        }

        private void btnlisaaalue_Click(object sender, EventArgs e)
        {
            Functions.lisaaalue(tbaluenimi.Text);
            haeaputaulu("alue");
            haetaulu(mode);
        }

        private void btnperuutaalue_Click(object sender, EventArgs e) //TYHJENTÄÄ KYSEISEN PANEELIN TEKSTIKENTÄT
        {
            tbaluenimi.Clear();
        }

        private void btnpoistaalue_Click(object sender, EventArgs e)
        {
            Functions.poistaalue(tbaluenimi.Text);
            haetaulu(mode);
        }


        // Palvelu paneelin painikkeet

        private void btnlisaapalvelu_Click(object sender, EventArgs e)
        {
            Functions.lisaapalvelu(cmbpalvelualue.Text, tbpalvelunimi.Text, tbpalvelutyyppi.Text, tbpalvelukuvaus.Text, tbpalveluhinta.Text, tbpalvelualv.Text);
            haetaulu("palvelu");
        }

        private void btnmuokkaapalvelu_Click(object sender, EventArgs e)
        {
            Functions.paivitapalvelu(cmbpalvelualue.Text, tbpalvelunimi.Text, tbpalvelutyyppi.Text, tbpalvelukuvaus.Text, tbpalveluhinta.Text, tbpalvelualv.Text, ID);
            haetaulu("palvelu");
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
            Functions.poistapalvelu(ID);
            haetaulu("palvelu");
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
            haku = true;
            haetaulu("asiakas");
        }

        private void btnpoistavaraus_Click(object sender, EventArgs e)
        {
            Functions.poistavaraus(ID.ToString());
            haetaulu("varaus");
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
                Functions.lisaavaraus(ID.ToString(), cbmokki.Text, dtptulopaiva.Value.ToString("MM/dd/yyyy"), dtplahtopaiva.Value.ToString("MM/dd/yyyy"));
                haetaulu("varaus");
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
            tbmokkihenkilomaara.Clear();
        }  // TYHJENTÄÄ KYSEISEN PANEELIN TEKSTIKENTÄT

        private void btnlisaamokki_Click(object sender, EventArgs e)
        {
            Functions.lisaamokki(tbmokkialuenimi.Text, tbmokkinimi.Text, tbmokkiosoite.Text, tbmokkipostinumero.Text, tbmokkivarustelu.Text, tbmokkikuvaus.Text, tbmokkihenkilomaara.Text, tbmokkihinta.Text);
            haetaulu(mode);
        } // onnistuu mökin lisääminen tietokantaan ja näyttää datagripviewissä

        private void btnmuokkaamokki_Click(object sender, EventArgs e)
        {
            Functions.paivitamokki(tbmokkialuenimi.Text, tbmokkinimi.Text, tbmokkiosoite.Text, tbmokkipostinumero.Text, tbmokkivarustelu.Text, tbmokkikuvaus.Text, tbmokkihinta.Text, tbmokkihenkilomaara.Text, ID);
            haetaulu("mokki");
        }

        private void btnpoistamokki_Click(object sender, EventArgs e)
        {
            Functions.poistamokki(tbmokkialuenimi.Text, tbmokkinimi.Text, tbmokkiosoite.Text,tbmokkipostinumero.Text, tbmokkivarustelu.Text, tbmokkikuvaus.Text,tbmokkihinta.Text,tbmokkihenkilomaara.Text);
            haetaulu(mode);
        }






        private void Plasku_Paint(object sender, PaintEventArgs e)
        {

        }



        // VARMISTUKSIA, ei voi syöttää  kuin numeroita ja tietyn verran

        private void tbasiakaspostinum_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Tarkistetaan, että käyttäjä syöttää vain numeroita ja backspacea
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

            // Tarkistetaan, että merkkijonon pituus ei ylitä 10
            if (tbasiakaspostinum.Text.Length >= 5 && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void tbasiakaspuhnum_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Tarkistetaan, että käyttäjä syöttää vain numeroita ja backspacea
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

            // Tarkistetaan, että merkkijonon pituus ei ylitä 10
            if (tbasiakaspuhnum.Text.Length >= 10 && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void tbvaraajanpostinumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Tarkistetaan, että käyttäjä syöttää vain numeroita ja backspacea
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

            // Tarkistetaan, että merkkijonon pituus ei ylitä 10
            if (tbvaraajanpostinumero.Text.Length >= 5 && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void tbvarauspuhelinnumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Tarkistetaan, että käyttäjä syöttää vain numeroita ja backspacea
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

            // Tarkistetaan, että merkkijonon pituus ei ylitä 10
            if (tbvarauspuhelinnumero.Text.Length >= 10 && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void tbmokkipostinumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Tarkistetaan, että käyttäjä syöttää vain numeroita ja backspacea
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

            // Tarkistetaan, että merkkijonon pituus ei ylitä 10
            if (tbmokkipostinumero.Text.Length >= 5 && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }
        
        private void tbmokkihenkilomaara_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }


        private void btnhaeasiakas_Click(object sender, EventArgs e)
        {
            DataSet dataa = Functions.haetieto(tbasiakasnimi.Text, tbasiakassnimi.Text, tbasiakaspuhnum.Text, tbasiakassposti.Text, tbasiakasosoite.Text, tbasiakaspostinum.Text, "asiakas");
            dataGridView1.DataSource = dataa.Tables["asiakas"];
        }

        // Pika näppäin ohjelmallisesti lisätty, pääseen textbokseissa liikkumaan taaksepäin Tab + shift

        private void textBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Tab && e.Modifiers == Keys.Shift)
            {
                this.ProcessTabKey(false);
                e.SuppressKeyPress = true;
            }
        }

        
    }
}

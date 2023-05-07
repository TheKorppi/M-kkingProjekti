using iTextSharp.text;
using iTextSharp.text.pdf;
using MökkingProjekti.MokkingDBDataSetTableAdapters;
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
    public partial class laskuform : Form
    {
        public laskuform()
        {
            InitializeComponent();
            
        }

        
        private void tulostalaskubtn_Click(object sender, EventArgs e)
        {
            //Tämä napin painallus tulostaa pdf documentin filestreamin jälkeen olevaan osoitteeseen
            StringBuilder sb = new StringBuilder();

            Document document = new Document();
            string laskunimi = asiakaannimitb.Text + "_" + mokinnimitb.Text + "_Laskuid" + varauksenidtb.Text + "_LASKU.pdf";

            PdfWriter.GetInstance(document, new FileStream(@"C:\temp\"+laskunimi, FileMode.Create));
            document.Open();

            //Lisätään yrityksen tiedot
            DateTime laskutuspaiva = DateTime.Today;

            Paragraph yritystiedot = new Paragraph("Village Newbies Oy                                               Päiväys:" + laskutuspaiva.ToString ("d") + 
                "\nSiilokatu 1\n90700 Oulu\nPuh. 044 1234567\nvillagenewbies@excamlpe.com\nTilinumero: FI1234567890\nViitenumero: varausID \n\n" +
                "Käytä maksaessa viitenumerona varausID numeroa tekstikentässä.\nMaksa lasku 14 pv kuluessa, välttääksesi 8% viivästyskorko + 5e laskutuslisä");
            yritystiedot.Alignment = Element.ALIGN_LEFT;
            yritystiedot.SpacingAfter = 20f;
            document.Add(yritystiedot);



            sb.AppendLine("Asiakkaan nimi: "+asiakaannimitb.Text);
            sb.AppendLine("Varauksen ID: " + varauksenidtb.Text);
            sb.AppendLine("Mökin nimi: " + mokinnimitb.Text);
            sb.AppendLine("Toimipaikka: " + toimipaikkatb.Text);
            sb.AppendLine("Palveluiden määrä: " + palveluidenlkmtb.Text);
            sb.AppendLine("Varauksen alkamispvm: " + alkamispvmtb.Text);
            sb.AppendLine("Varauksen loppumispvm: " + loppumispvmtb.Text);
            sb.AppendLine("Laskun summa: " + laskunsummatb.Text);
            
            
            Paragraph paragraph = new Paragraph();
            paragraph.Alignment = Element.ALIGN_LEFT;
            paragraph.Add(new Chunk(sb.ToString()));

            document.Add(paragraph);



            document.Close();

            DialogResult dialogResult = MessageBox.Show("Haluatko tulostaa muita laskuja?", "Lasku tallennettu!", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                
            }
            else if (dialogResult == DialogResult.No)
            {
                this.Close();
            }

        }

        private void laskuform_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mokkingDBDataSet.asiakas' table. You can move, or remove it, as needed.
            //this.asiakasTableAdapter.Fill(this.mokkingDBDataSet.asiakas);
            //formin latautuessa ottaa server explorerista laskukokonaisuus viewin, ja lataa sen sisällön datagridiin
            SqlConnection connection = new SqlConnection(Functions.getDatasource());
            connection.Open();
            SqlCommand command = new SqlCommand("SELECT * FROM laskukokonaisuus", connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            varausdgv.DataSource = dataTable;
            tulostalaskubtn.Enabled = false;

        }

        private void varausdgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < varausdgv.Rows.Count - 1)
            {
                DataGridViewRow row = varausdgv.Rows[e.RowIndex];

                asiakaannimitb.Text = row.Cells["Asiakkaan_nimi"].Value.ToString();
                mokinnimitb.Text = row.Cells["Mökin_nimi"].Value.ToString();
                toimipaikkatb.Text = row.Cells["Toimipaikka"].Value.ToString();
                palveluidenlkmtb.Text = row.Cells["Palveluiden_määrä"].Value.ToString();
                alkamispvmtb.Text = row.Cells["Varauksen_alkamispvm"].Value.ToString();
                loppumispvmtb.Text = row.Cells["Varauksen_loppimspvm"].Value.ToString();
                laskunsummatb.Text = row.Cells["Laskun_summa"].Value.ToString();
                varauksenidtb.Text = row.Cells["varaus_id"].Value.ToString();
                varausdgv.ClearSelection();
                row.Selected = true;
                tulostalaskubtn.Enabled = true;
            }

        }

    }
}

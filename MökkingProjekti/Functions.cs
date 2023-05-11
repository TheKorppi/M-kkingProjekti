using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Runtime.Remoting.Contexts;
using System.IO;
using iTextSharp.text.pdf.parser;
using Org.BouncyCastle.Utilities.Collections;
using static MökkingProjekti.MokkingDBDataSet;
using System.Collections;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using Org.BouncyCastle.Asn1.X500;

namespace MökkingProjekti
{

    internal class Functions
    {
        public static void ifkysymys(string path)
        {
            if (!File.Exists(path))
            {
                MessageBox.Show("Emme havainneet tietokantaa, etsi tietokannan tiedostopolku.");
                folderpath(path);
            }
        }
        public static void folderpath(string path)
        {
            //Tässä ongelma vielä, jos käyttäjä vaihtaa tietokannan pathia, se tallentuu samaan tiedostoon aiemman kanssa joka ei toimi
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Database Files (*.mdf)|*.mdf|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                filePath = filePath.Substring(0, filePath.Length - 23);

                filePath = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=" + filePath + "MokkingDB.mdf;Integrated Security=True;Connect Timeout=30";
                File.WriteAllText(path, filePath);
            }
        }
        public static DataSet paivitadatagrid(string taulunimi, DateTime alkudate = default(DateTime), DateTime loppudate = default(DateTime), string aluenimi1 = "")
        {

            string connection = getDatasource();
            string query = "";
            if (alkudate != default(DateTime) && loppudate != default(DateTime))
            {
                query += "SELECT * FROM " + taulunimi + " WHERE varattu_alkupvm >= @alkudate AND varattu_loppupvm <= @loppudate AND aluenimi = @aluenimi";
            }
            else
            {
                query = "SELECT * FROM " + taulunimi;
            }

            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            DataSet dataSet = new DataSet();
            if (alkudate != default(DateTime) && loppudate != default(DateTime))
            {
                adapter.SelectCommand.Parameters.AddWithValue("@alkudate", alkudate);
                adapter.SelectCommand.Parameters.AddWithValue("@loppudate", loppudate);
                adapter.SelectCommand.Parameters.AddWithValue("@aluenimi", aluenimi1);
            }
            adapter.Fill(dataSet, taulunimi);
            return dataSet;

        }
        //lisää asiakas tietokantaan ja varmistaa onko aluetta ennestään tietokannassa
        public static void lisaaasiakas(string nimi, string sukunimi, string puhnum, string email, string lahiosoite, string postinum)
        {
            /*
            string connection = getDatasource();
            string query = "insert into asiakas(etunimi, sukunimi, puhelinnro, email, lahiosoite, postinro)  values" + "('" + nimi + "','" + sukunimi + "','" + puhnum + "','" + email + "','" + lahiosoite + "','" + postinum + "');";
            SqlConnection con = new SqlConnection(connection);
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            con.Close();
            */

            string connection = getDatasource();
            string query = "SELECT COUNT(*) FROM asiakas WHERE etunimi='" + nimi + "' AND sukunimi='" + sukunimi + "' AND puhelinnro='" + puhnum + "' AND email='" + email + "' AND lahiosoite='" + lahiosoite + "' AND postinro='" + postinum + "';";
            SqlConnection con = new SqlConnection(connection);
            con.Open();
            SqlCommand command = new SqlCommand(query, con);
            int count = (int)command.ExecuteScalar();
            con.Close();

            // Jos asiakasta ei ole jo tietokannassa, suorita lisäys
            if (count == 0)
            {
                con.Open();
                query = "INSERT INTO asiakas(etunimi, sukunimi, puhelinnro, email, lahiosoite, postinro)  values" + "('" + nimi + "','" + sukunimi + "','" + puhnum + "','" + email + "','" + lahiosoite + "','" + postinum + "');";
                command = new SqlCommand(query, con);
                command.ExecuteNonQuery();
                con.Close();
            }
            else
            {
                MessageBox.Show("Asiakas nimellä " + nimi + " " + sukunimi + " on jo tietokannassa!");
            }
        }
        //lisää palvelun tietokantaan ja varmistaa onko aluetta ennestään tietokannassa
        public static void lisaapalvelu(string alueid, string nimi, string typpi, string kuvaus, string hinta, string alv)
        {
            {/*
            string connection = getDatasource();
            string query = "insert into palvelu(alue_id, nimi, tyyppi, kuvaus, hinta, alv)  values" + "(" + alueid + ",'" + nimi + "'," + typpi + ",'" + kuvaus + "'," + hinta + "," + alv + ");";
            SqlConnection con = new SqlConnection(connection);
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            con.Close();
            */
            }

            string connection = getDatasource();
            string query = "SELECT COUNT(*) FROM palvelu WHERE nimi='" + nimi + "' AND alue_id='" + alueid + "' AND kuvaus='" + kuvaus + "';";
            SqlConnection con = new SqlConnection(connection);
            con.Open();
            SqlCommand command = new SqlCommand(query, con);
            int count = (int)command.ExecuteScalar();
            con.Close();

            // Jos palvelu ei ole jo tietokannassa, suorita lisäys
            if (count == 0)
            {
                query = "insert into palvelu(alue_id, nimi, tyyppi, kuvaus, hinta, alv)  values" + "(" + alueid + ",'" + nimi + "'," + typpi + ",'" + kuvaus + "'," + hinta + "," + alv + ");";
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            else
            {
                MessageBox.Show("Palvelu nimellä " + nimi + ", alueella " + alueid + " ja kuvauksella " + kuvaus + " on jo tietokannassa!");
            }
        }
        public static void lisaalasku(string id, string hinta, string alv)
        {
            string connection = getDatasource();
            string query = "insert into lasku(varaus_id, summa, alv)  values" + "("+ id+", "+hinta+", "+alv+");";
            SqlConnection con = new SqlConnection(connection);
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public static void lisaavaraus(string asiakasid, string mokkiid, string varausalku,string varausloppu)
        {
            string connection = getDatasource();
            string query = "insert into varaus(asiakas_id,mokki_mokki_id , varattu_pvm, vahvistus_pvm, varattu_alkupvm, varattu_loppupvm )  values" + "(" + asiakasid + ", " + mokkiid + ", '" + DateTime.Now.ToString("MM/dd/yyyy") + "', '"+ DateTime.Now.ToString("MM/dd/yyyy") +"' ,'"+varausalku+"' , '"+varausloppu+"'); ";
            SqlConnection con = new SqlConnection(connection);
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        //lisää mökin tietokantaan ja näyttää datagripviewissä
        public static void lisaamokki(string alue_id, string mokkinimi,string katuosoite, string postinro, string varustelu, string kuvaus, string hinta, string henkilomaara)
        {   
            /*
            string connection = getDatasource();
            string query = "insert into mokki(alue_id, mokkinimi, katuosoite, postinro, varustelu, kuvaus, hinta, henkilomaara) values" + "('" + alue_id + "','" + mokkinimi + "','" + katuosoite + "','" + postinro + "','" + varustelu + "','" + kuvaus + "','" + henkilomaara + "','" + hinta + "');";
            SqlConnection con = new SqlConnection(connection);
            con.Open();
            SqlCommand command = new SqlCommand(query, con);
            command.ExecuteNonQuery();
            */ //yksinkertainen versio

            //mökin lisäys varmistuksen kanssa, ei lisää jos tiedo löytyvät

            string connection = getDatasource();
            string query = "SELECT COUNT(*) FROM mokki WHERE alue_id='" + alue_id + "' AND mokkinimi='" + mokkinimi + "' AND katuosoite='" + katuosoite + "' AND postinro='" + postinro + "' AND varustelu='" + varustelu + "' AND kuvaus='" + kuvaus  + "'";
            SqlConnection conn = new SqlConnection(connection);
            conn.Open();
            SqlCommand command = new SqlCommand(query, conn);
            int count = (int)command.ExecuteScalar();
            conn.Close();

            // jos mokki ei olo jo tietokannassa,suorita lisäys
            if(count == 0)
            {
                conn.Open();
                query = "INSERT INTO mokki (alue_id, mokkinimi, katuosoite, postinro, varustelu, kuvaus, hinta, henkilomaara) VALUES (" + alue_id + " ,'" + mokkinimi + "','" + katuosoite + "','" + postinro + "','" + varustelu + "','" + kuvaus + "', " + henkilomaara + ", " + hinta  + ");";
                command = new SqlCommand(query, conn);
                command.ExecuteNonQuery();
                conn.Close();
            }
            else
            {
                MessageBox.Show("Mökki nimellä ja kuvauksella " + mokkinimi + "  " + kuvaus + " on jo tietokannassa");
            }
        }
        //lisää alueen tietokantaan ja varmistaa onko aluetta ennestään tietokannassa
        public static void lisaaalue(string nimi)
        {
            string connection = getDatasource();
            string query = "SELECT COUNT(*) FROM alue WHERE nimi='" + nimi + "';";
            SqlConnection con = new SqlConnection(connection);
            con.Open();
            SqlCommand command = new SqlCommand(query, con);
            int count = (int)command.ExecuteScalar();
            con.Close();

            // Jos alue ei ole jo tietokannassa, suorita lisäys
            if (count == 0)
            {
                con.Open();
                query = "INSERT INTO alue(nimi) VALUES('" + nimi + "');";
                command = new SqlCommand(query, con);
                command.ExecuteNonQuery();
                con.Close();
            }
            else
            {
                MessageBox.Show("Alue nimellä " + nimi + " on jo tietokannassa!");
            }
        }
        public static void lisaavarauspalvelu(string varaus_id, string palvelu_id, string lkm)
        {
            string connection = getDatasource();
            string query = "insert into varauksen_palvelut(varaus_id, palvelu_id,lkm) values("+varaus_id+","+palvelu_id+","+lkm+"); ";
            SqlConnection con = new SqlConnection(connection);
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }


        public static void poistaasiakas(string nimi, string sukunimi, string puhnum, string email, string lahiosoite, string postinum)
        {
            SqlConnection con = new SqlConnection(getDatasource());
            string query = "DELETE FROM asiakas WHERE etunimi = '" + nimi + "' AND sukunimi = '" + sukunimi + "' AND puhelinnro = '" + puhnum + "';";
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public static void poistapalvelu(int ID)
        {
            SqlConnection con = new SqlConnection(getDatasource());
            string query = "DELETE FROM palvelu WHERE palvelu_id = " +ID;
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public static void poistalasku(string varausid, string summa, string alv)
        {
            SqlConnection con = new SqlConnection(getDatasource());
            string query = "DELETE FROM lasku WHERE varaus_id = " + varausid + " AND summa = " + summa + " AND alv = " + alv + " ;";
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public static void poistavaraus(string varausid)
        {
            SqlConnection con = new SqlConnection(getDatasource());
            string query = "DELETE FROM varaus WHERE varaus_id = " + varausid + ";";
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        // mökin poisto varmistuksella 
        public static void poistamokki(string alue_id, string mokkinimi, string katuosoite, string postinro, string varustelu, string kuvaus, string hinta, string henkilomaara)
        {
            /*
            SqlConnection con = new SqlConnection(getDatasource());
            string query = "DELETE FROM mokki WHERE mokkinimi='" + mokkinimi + "' AND kuvaus= '" + kuvaus + "';";
            con.Open();
            SqlCommand command = new SqlCommand(query, con);    
            command.ExecuteNonQuery();
            con.Close();
            */

            DialogResult result = MessageBox.Show("Haluatko varmasti poistaa tämän mökin?", "Vahvistus", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                SqlConnection con = new SqlConnection(getDatasource());
                string query = "DELETE FROM mokki WHERE mokkinimi='" + mokkinimi + "' AND kuvaus= '" + kuvaus + "';";
                con.Open();
                SqlCommand command = new SqlCommand(query, con);
                command.ExecuteNonQuery();
                con.Close();
            }

        }
        // alueen poisto varmistuksella 
        public static void poistaalue(string nimi)
        {
            DialogResult result = MessageBox.Show("Haluatko varmasti poistaa alueen?", "Vahvista poisto", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                SqlConnection con = new SqlConnection(getDatasource());
                string query = "DELETE FROM alue WHERE nimi = '" + nimi + "';";
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }
        public static void poistavarauspalvelu(string varaus_id, string palvelu_id, string lkm)
        {
            SqlConnection con = new SqlConnection(getDatasource());
            string query = "DELETE FROM varauksen_palvelut WHERE varaus_id = " + varaus_id + " and palvelu_id = "+palvelu_id+" and lkm = "+lkm+";";
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
       
        public static void paivatiaasiakas(string nimi, string sukunimi, string puhnum, string email, string lahiosoite, string postinum,int ID)
        {
            SqlConnection con = new SqlConnection(getDatasource());
            string query = "UPDATE asiakas SET etunimi = '"+nimi+"' , sukunimi = '"+sukunimi+"', puhelinnro = '"+puhnum+"', email = '"+email+"', lahiosoite = '" +lahiosoite+"', postinro = '"+ postinum+"' WHERE asiakas_id = "+ID;
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public static void paivitalasku(string varausid, string summa, string alv, int ID)
        {
            SqlConnection con = new SqlConnection(getDatasource());
            string query = "UPDATE lasku SET varaus_id = " + varausid + " , summa = " + summa + ", alv = " + alv + " WHERE lasku_id = " + ID;
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public static void paivitamokki(string alue_id, string mokkinimi, string katuosoite, string postinro, string varustelu, string kuvaus, string hinta, string henkilomaara,int ID)
        {
            SqlConnection con = new SqlConnection(getDatasource());
            string query = "UPDATE mokki SET alue_id = "+alue_id+", mokkinimi ='" + mokkinimi + "' , katuosoite = '" + katuosoite + "', postinro = '" + postinro + "', varustelu = '" + varustelu + "', kuvaus = '" + kuvaus + "', hinta = " + hinta+ " , henkilomaara= "+henkilomaara +" WHERE mokki_id = " + ID;
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public static void paivitapalvelu(string alueid, string nimi, string typpi, string kuvaus, string hinta, string alv,int ID)
        {
            SqlConnection con = new SqlConnection(getDatasource());
            string query = "UPDATE palvelu SET alue_id = " + alueid + ", nimi ='" + nimi + "' , tyyppi = " + typpi + ", kuvaus = '" + kuvaus + "', hinta = " + hinta + ", alv = " + alv + " WHERE palvelu_id = " + ID;
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public static void paivitaalue(string nimi, int id)
        {
            SqlConnection con = new SqlConnection(getDatasource());
            string query = "UPDATE alue SET nimi = '" + nimi + "' WHERE alue_id = " + id;
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public static void paivitavarauspalvelu(string varaus_id, string palvelu_id, string lkm, string varaus_id2, string palvelu_id2, string lkm2)
        {
            SqlConnection con = new SqlConnection(getDatasource());
            string query = "UPDATE varausten_palvelut SET varaus_id = " + varaus_id + ", palvelu_id=" + palvelu_id + "lkm= " + lkm + "  WHERE varaus_id = " + varaus_id2 + ", palvelu_id=" + palvelu_id2 + "lkm= " + lkm2 + " ;";
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }


        public static DataSet haetieto(string nimi, string sukunimi, string puhnum, string email, string lahiosoite, string postinum, string taulunimi)
        {
            int count = 0;
            string query = "SELECT * FROM " + taulunimi + " WHERE "; //etunimi = @nimi and sukunimi = @sukunimi and puhelinnro = @puhnum and email = @email and lahiosoite = @lahiosoite and postinro = @postinum";
            if (nimi != "") 
            {
               
                if (count == 0)
                {
                    query = query + "etunimi = @nimi ";
                    count++;
                }
                else
                {
                    query = query + "and etunimi = @nimi ";
                }
                
            }
            if (sukunimi != "")
            {

                if (count == 0)
                {
                    query = query + "sukunimi = @sukunimi ";
                    count++;
                }
                else
                {
                    query = query + "and sukunimi = @sukunimi ";
                }
            }
            if (puhnum != "")
            {

                if (count == 0)
                {
                    query = query + "puhelinnro = @puhnum ";
                    count++;
                }
                else
                {
                    query = query + "and puhelinnro = @puhnum ";
                }
            }
            if (email != "")
            {

                if (count == 0)
                {
                    query = query + "email = @email ";
                    count++;
                }
                else
                {
                    query = query + "and email = @email ";
                }
            }
            if (lahiosoite != "")
            {

                if (count == 0)
                {
                    query = query + "lahiosoite = @lahiosoite ";
                    count++;
                }
                else
                {
                    query = query + "and lahiosoite = @lahiosoite ";
                }
            }
            if (postinum != "")
            {

                if (count == 0)
                {
                    query = query + "postinro = @postinum ";
                    count++;
                }
                else
                {
                    query = query + "and postinro = @postinum ";
                }
            }

            SqlDataAdapter adapter = new SqlDataAdapter(query, getDatasource());
            DataSet dataSet = new DataSet();
            adapter.SelectCommand.Parameters.AddWithValue("@nimi", nimi);
            adapter.SelectCommand.Parameters.AddWithValue("@sukunimi", sukunimi);
            adapter.SelectCommand.Parameters.AddWithValue("@puhnum", puhnum);
            adapter.SelectCommand.Parameters.AddWithValue("@email", email);
            adapter.SelectCommand.Parameters.AddWithValue("@lahiosoite", lahiosoite);
            adapter.SelectCommand.Parameters.AddWithValue("@postinum", postinum);
            adapter.Fill(dataSet, taulunimi);
            return dataSet;
        }
        public static DataSet haemokkitieto(string alueid, string mokkinimi, string katuosoite, string postinro, string varustelu, string kuvaus,  string hinta, string henkilomaara, string taulunimi)
        {
            int count = 0;
            string query = "SELECT * FROM " + taulunimi + " WHERE "; //alue_id = alueid and postinro = @postinro and mokkinimi = @mokkinimi and kuvaus = @kuvaus and katuosoite = @katuosoite and hinta = @hinta" and henkilomaara = @henkilomaara and =a;
            if (alueid != "")
            {

                if (count == 0)
                {
                    query = query + "alue_id = @alueid ";
                    count++;
                }
                else
                {
                    query = query + "and alue_id = @alueid ";
                }

            }
            else
                alueid = null;
            if (postinro != "")
            {

                if (count == 0)
                {
                    query = query + "postinro = @postinro ";
                    count++;
                }
                else
                {
                    query = query + "and postinro = @postinro ";
                }
            }
            if (mokkinimi != "")
            {

                if (count == 0)
                {
                    query = query + "mokkinimi = @mokkinimi ";
                    count++;
                }
                else
                {
                    query = query + "and mokkinimi = @mokkinimi ";
                }
            }
            if (kuvaus != "")
            {

                if (count == 0)
                {
                    query = query + "kuvaus = @kuvaus ";
                    count++;
                }
                else
                {
                    query = query + "and kuvaus = @kuvaus ";
                }
            }
            if (katuosoite != "")
            {

                if (count == 0)
                {
                    query = query + "katuosoite = @katuosoite ";
                    count++;
                }
                else
                {
                    query = query + "and katuosoite = @katuosoite ";
                }
            }
            if (hinta != "")
            {

                if (count == 0)
                {
                    query = query + "hinta = @hinta ";
                    count++;
                }
                else
                {
                    query = query + "and hinta = @hinta ";
                }
            }
            else
                hinta = null;
            if (henkilomaara != "")
            {

                if (count == 0)
                {
                    query = query + "henkilomaara = @henkilomaara ";
                    count++;
                }
                else
                {
                    query = query + "and henkilomaara = @henkilomaara ";
                }
            }
            else
            henkilomaara = null;
            if (varustelu != "")
            {

                if (count == 0)
                {
                    query = query + "varustelu = @varustelu ";
                    count++;
                }
                else
                {
                    query = query + "and varustelu = @varustelu ";
                }
            }

            SqlDataAdapter adapter = new SqlDataAdapter(query, getDatasource());
            DataSet dataSet = new DataSet();
            adapter.SelectCommand.Parameters.AddWithValue("@alueid", Convert.ToInt32(alueid));
            adapter.SelectCommand.Parameters.AddWithValue("@postinro", postinro);
            adapter.SelectCommand.Parameters.AddWithValue("@mokkinimi", mokkinimi);
            adapter.SelectCommand.Parameters.AddWithValue("@kuvaus", kuvaus);
            adapter.SelectCommand.Parameters.AddWithValue("@katuosoite", katuosoite);
            adapter.SelectCommand.Parameters.AddWithValue("@hinta",Convert.ToDouble(hinta));
            adapter.SelectCommand.Parameters.AddWithValue("@henkilomaara", Convert.ToInt32(henkilomaara));
            adapter.SelectCommand.Parameters.AddWithValue("@varustelu", varustelu);
            adapter.Fill(dataSet, taulunimi);
            return dataSet;

        }
        public static DataSet haelaskutieto(string varaus_id, string summa, string alv, string taulunimi)
        {
            int count = 0;
            string query = "SELECT * FROM " + taulunimi + " WHERE "; //varaus_id = alueid and summa = @summa and alv = @alv and kuvaus = @kuvaus and katuosoite = @katuosoite and hinta = @hinta" and henkilomaara = @henkilomaara and =a;
            if (varaus_id != "")
            {

                if (count == 0)
                {
                    query = query + "varaus_id = @varaus_id ";
                    count++;
                }
                else
                {
                    query = query + "and varaus_id = @varaus_id ";
                }

            }
            else
                varaus_id = null;
            if (summa != "")
            {

                if (count == 0)
                {
                    query = query + "summa = @summa ";
                    count++;
                }
                else
                {
                    query = query + "and summa = @summa ";
                }
            }
            else
                summa = null;
            if (alv != "")
            {

                if (count == 0)
                {
                    query = query + "alv = @alv ";
                    count++;
                }
                else
                {
                    query = query + "and alv = @alv ";
                }
            }
            else
                alv = null;


            SqlDataAdapter adapter = new SqlDataAdapter(query, getDatasource());
            DataSet dataSet = new DataSet();
            adapter.SelectCommand.Parameters.AddWithValue("@varaus_id", Convert.ToInt32(varaus_id));
            adapter.SelectCommand.Parameters.AddWithValue("@summa", Convert.ToDouble(summa));
            adapter.SelectCommand.Parameters.AddWithValue("@alv", Convert.ToDouble(alv));

            adapter.Fill(dataSet, taulunimi);
            return dataSet;
        }
        public static string reader()
        {
            
            
            SqlConnection con = new SqlConnection(getDatasource());
            string query = "SELECT varaus_id FROM varaus WHERE varaus_id = (SELECT MAX(varaus_id) FROM varaus);";
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader rdr = cmd.ExecuteReader();
            
            while (rdr.Read())
            {
                string id = rdr["varaus_id"].ToString();
                return id;
                
            }
            con.Close();
            return null;

        }
        public static DataSet haepalvelutieto(string alueid, string nimi, string tyyppi, string kuvaus, string hinta, string alv, string taulunimi)
        {
            int count = 0;
            string query = "SELECT * FROM " + taulunimi + " WHERE "; //alue_id = alueid and nimi = @nimi and tyyppi = @tyyppi and kuvaus = @kuvaus and hinta = @hinta and hinta = @hinta" and alv = @alv and =a;
            if (alueid != "")
            {

                if (count == 0)
                {
                    query = query + "alue_id = @alueid ";
                    count++;
                }
                else
                {
                    query = query + "and alue_id = @alueid ";
                }

            }
            else 
                alueid = null;
            if (nimi != "")
            {

                if (count == 0)
                {
                    query = query + "nimi = @nimi ";
                    count++;
                }
                else
                {
                    query = query + "and nimi = @nimi ";
                }
            }
            if (tyyppi != "")
            {

                if (count == 0)
                {
                    query = query + "tyyppi = @tyyppi ";
                    count++;
                }
                else
                {
                    query = query + "and tyyppi = @tyyppi ";
                }
            }
            else
                tyyppi = null;
            if (kuvaus != "")
            {

                if (count == 0)
                {
                    query = query + "kuvaus = @kuvaus ";
                    count++;
                }
                else
                {
                    query = query + "and kuvaus = @kuvaus ";
                }
            }
            if (hinta != "")
            {

                if (count == 0)
                {
                    query = query + "hinta = @hinta ";
                    count++;
                }
                else
                {
                    query = query + "and hinta = @hinta ";
                }
            }
            else
                hinta = null;

            if (alv != "")
            {

                if (count == 0)
                {
                    query = query + "alv = @alv ";
                    count++;
                }
                else
                {
                    query = query + "and alv = @alv ";
                }
            }
            else
                alv = null;


            SqlDataAdapter adapter = new SqlDataAdapter(query, getDatasource());
            DataSet dataSet = new DataSet();
            adapter.SelectCommand.Parameters.AddWithValue("alueid",Convert.ToInt32(alueid));
            adapter.SelectCommand.Parameters.AddWithValue("@nimi", nimi);
            adapter.SelectCommand.Parameters.AddWithValue("@tyyppi", Convert.ToInt32(tyyppi));
            adapter.SelectCommand.Parameters.AddWithValue("@kuvaus", kuvaus);
            adapter.SelectCommand.Parameters.AddWithValue("@hinta", Convert.ToDouble(hinta));
            adapter.SelectCommand.Parameters.AddWithValue("@alv", Convert.ToDouble(alv));
            adapter.Fill(dataSet, taulunimi);
            return dataSet;

        }
        public static string getDatasource()
        {
            StreamReader sr = new StreamReader(getpath());
            string path = sr.ReadLine();
            sr.Close();
            return (path);
            
        }
        public static string getpath()
        {
            return ("C:/temp/tiedostopolku.txt");
        }



    }
}

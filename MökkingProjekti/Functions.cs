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

        public static void lisaaasiakas(string nimi, string sukunimi, string puhnum, string email, string lahiosoite, string postinum)
        {
            string connection = getDatasource();
            string query = "insert into asiakas(etunimi, sukunimi, puhelinnro, email, lahiosoite, postinro)  values" + "('" + nimi + "','" + sukunimi + "','" + puhnum + "','" + email + "','" + lahiosoite + "','" + postinum + "');";
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
                query = "INSERT INTO mokki (alue_id, mokkinimi, katuosoite, postinro, varustelu, kuvaus, hinta, henkilomaara) VALUES ('" + alue_id + "','" + mokkinimi + "','" + katuosoite + "','" + postinro + "','" + varustelu + "','" + kuvaus + "','" + henkilomaara + "','" + hinta + "');";
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


        public static void poistaasiakas(string nimi, string sukunimi, string puhnum, string email, string lahiosoite, string postinum)
        {
            SqlConnection con = new SqlConnection(getDatasource());
            string query = "DELETE FROM asiakas WHERE etunimi = '" + nimi + "' AND sukunimi = '" + sukunimi + "' AND puhelinnro = '" + puhnum + "';";
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
        public static void paivatiaasiakas(string nimi, string sukunimi, string puhnum, string email, string lahiosoite, string postinum,int ID)
        {
            SqlConnection con = new SqlConnection(getDatasource());
            string query = "UPDATE asiakas SET etunimi = '"+nimi+"' , sukunimi = '"+sukunimi+"', puhelinnro = '"+puhnum+"', email = '"+email+"', lahiosoite = '" +lahiosoite+"', postinro = '"+ postinum+"' WHERE asiakas_id = "+ID;
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

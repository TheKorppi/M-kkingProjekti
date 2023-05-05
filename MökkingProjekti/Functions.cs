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

namespace MökkingProjekti
{

    internal class Functions
    {
        public static void ifkysymys(string path)
        {
            if(!File.Exists(path))
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
        public static DataSet paivitadatagrid(string taulunimi, DateTime alkudate = default(DateTime), DateTime loppudate = default(DateTime), string aluenimi1 ="")
        {

            string connection = getDatasource();
            string query = "";
            if (alkudate != default(DateTime) && loppudate != default(DateTime))
            {
                query += "SELECT * FROM "+taulunimi+ " WHERE varattu_alkupvm >= @alkudate AND varattu_loppupvm <= @loppudate AND aluenimi = @aluenimi";
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

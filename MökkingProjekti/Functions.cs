using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MökkingProjekti
{
    internal class Functions
    {
        
        public static DataSet paivitadatagrid(string taulunimi)
        {
            string connection = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\ramia\\Source\\Repos\\TheKorppi\\M-kkingProjekti\\MökkingProjekti\\MokkingDB.mdf;Integrated Security=True;Connect Timeout=30";
            string query = "SELECT * FROM " + taulunimi;
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet, taulunimi);
            return dataSet;

        }
    }
}

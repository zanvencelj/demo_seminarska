
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data;

/*************************************************************************
 *                                                                      *
 *              Se ne uporablja zaradi varosti strežnika                *
 *                                                                      *
 *                                                                      *
 *                                                                      *
 *                                                                      *
 * **********************************************************************/



namespace Demo
{
    /*
    public class Database
    {
        string ConectionString = ""; 
        public MySqlConnection connection = null;
        public string server = "136.243.151.108:3306"; // MySQL host
        public string user = "vanted";        // MySQL user
        public string password = "";        // MySQL password 
        DataSet ds;
        DataTable dt;
        public string Table = "cenejeusers"; // initialize db table
        public string ConnectionType = "";
        string RecordSource = "";

        DataGridView tempdata;

        
    // function to connect to the database

    public void Connect(string database_name)
        {
            try
            {
                // ConectionString = "SERVER=" + server + ";" + "DATABASE=" + database_name + ";" + "UID=" + user + ";" + "PASSWORD=" + password + ";";
                ConectionString = "Server=136.243.151.108;Port=3306;Uid=vanted;Pwd=Hpmwkh65_0zgWqAx;Database=wp_ceneje;";
                connection = new MySqlConnection(ConectionString);
            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message);
            }
        }

        // Function to execute sql statements
        public void ExecuteSql(string Sql_command)
        {

            nowquiee(Sql_command);

        }

        // creates connection to MySQL
        public void nowquiee(string sql_comm)
        {
            try
            {
                MySqlConnection cs = new MySqlConnection(ConectionString);
                cs.Open();
                MySqlCommand myc = new MySqlCommand(sql_comm, cs);
                myc.ExecuteNonQuery();
                cs.Close();


            }
            catch (Exception err)
            {

                MessageBox.Show(err.Message);
            }
        }

        // function to execute delete , insert and update
        public void Execute(string Sql_command)
        {
            RecordSource = Sql_command;
            ConnectionType = Table;
            dt = new DataTable(ConnectionType);
            try
            {
                string command = RecordSource.ToUpper();

                //======================if sql contains select==========================================
                MySqlDataAdapter da2 = new MySqlDataAdapter(RecordSource, connection);

                DataSet tempds = new DataSet();
                da2.Fill(tempds, ConnectionType);
                da2.Fill(tempds);

                //======================================================================================


            }
            catch (Exception err) { MessageBox.Show(err.Message); }
        }

        // function to bring selected results based on column name and row index
        public string Results(int ROW, string COLUMN_NAME)
        {
            try
            {
                return dt.Rows[ROW][COLUMN_NAME].ToString();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
                return "";

            }
        }

        // function to bring selected results based on column index and row index
        public string Results(int ROW, int COLUMN_NAME)
        {
            try
            {
                return dt.Rows[ROW][COLUMN_NAME].ToString();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
                return dt.Rows[ROW][COLUMN_NAME].ToString();

            }
        }

        // Execute select statement
        public void ExecuteSelect(string Sql_command)
        {
            RecordSource = Sql_command;
            ConnectionType = Table;

            dt = new DataTable(ConnectionType);
            try
            {
                string command = RecordSource.ToUpper();
                MySqlDataAdapter da = new MySqlDataAdapter(RecordSource, connection);
                ds = new DataSet();
                da.Fill(ds, ConnectionType);
                da.Fill(dt);
                tempdata = new DataGridView();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }


        }

        // count Number of rows after selecy
        public int Count()
        {
            return dt.Rows.Count;
        }

    }
    */

}

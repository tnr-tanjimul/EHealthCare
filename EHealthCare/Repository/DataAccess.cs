using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace EHealthCare.Repository
{
    public class DataAccess : IDisposable
    {
        private MySqlConnection connection;
        private MySqlCommand command;
        public DataAccess()
        {
            this.ConnectDB();
           
        }

        public void ConnectDB()
        {
            try
            {
                string MySqlConnString = ConfigurationManager.ConnectionStrings["EHealthCareLocal"].ConnectionString;
                //string MySqlConnString = ConfigurationManager.ConnectionStrings["EHealthCareLive"].ConnectionString;
                // string MySqlConnString = "datasource=127.0.0.1;port=3306;username=root;password=;database=tnrsoftc_csharp";
                //string MySqlConnString = "SERVER=69.13.47.36;PORT=3306;UID=tnrsoftc_csAdmin;PASSWORD=Pt543xtzfDUGF46;DATABASE=tnrsoftc_csharp";
                this.connection = new MySqlConnection();
                this.connection.ConnectionString = MySqlConnString;
                this.connection.Open();
                //MessageBox.Show("Connected"); // for development
            }
            catch (Exception e)
            {
                MessageBox.Show("Connection Failed...");  // For Production
                //MessageBox.Show(new System.Diagnostics.StackTrace().ToString()); // For Development
            }
        }



        public MySqlDataReader GetData(string sql)
        {
            this.command = new MySqlCommand(sql, this.connection);
            return this.command.ExecuteReader();
        }

        public int ExecuteQuery(string sql)
        {
            this.command = new MySqlCommand(sql, this.connection);
            try
            {
                //MessageBox.Show(sql);
                return this.command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.ToString());
                return 0;
            }
}

        public void Dispose()
        {
            this.connection.Close();
            //MessageBox.Show("Disconnected");
        }
    }
}

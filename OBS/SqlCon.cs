using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DataAccess
{
    public class SqlConn
    {
        SqlConnection sqlConnection = new SqlConnection(@"Data Source=DESKTOP-BRNH8DO\SQLEXPRESS;Initial Catalog=StudentInformationSystem;Integrated Security=True");
        public SqlConnection Baglanti()
        {

            sqlConnection.Open();
            return sqlConnection;
        }
        public void Close()
        {
            sqlConnection.Close();
        }


    }
}
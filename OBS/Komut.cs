using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OBS
{
    public class Komut
    {

        SqlConn sqlConn = new SqlConn();
        SqlCommand sqlCommand = new SqlCommand();
        SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
        SqlDataReader dr;
        public SqlCommand comm(string Sorgu)
        {
            SqlCommand komut = new SqlCommand(Sorgu, sqlConn.Baglanti());
            return komut;
        }
        public bool Dogrulama(string sorgu)
        {
            sqlConn.Close();
            
            dr = comm(sorgu).ExecuteReader();

            if (dr.Read())
            {

                sqlConn.Close();
                return true;
                
            }
            else
            {

                sqlConn.Close();
                return false;
            }

        }
    }
}

    

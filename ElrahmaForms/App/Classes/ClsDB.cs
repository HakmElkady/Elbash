using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElrahmaForms.App.Classes
{
    internal class ClsDB
    {

        string DBPath ;
        SqlConnection Conn;

        public ClsDB()
        {
            DBPath = "Data Source=HAKM-LAP\\SQLEXPRESS;database=Elrahma;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            Conn = new SqlConnection(DBPath);
        }


        public void Open()
        {
            if (Conn.State == ConnectionState.Closed)
                Conn.Open();
        }


        public void Close()
        {
            if (Conn.State == ConnectionState.Open)
                Conn.Close();
        }

        public bool Check()
        {
            try
            {

                Close();
                Open();
                return true;

            }
            catch
            {

                MessageBox.Show("Connection Problem Call Hakam");
                return false;
            }

        }



        ///////////////////////
        ///

        public void Select(string SqlCommand, SqlParameter[] sqlParameters, DataTable dt)
        {
            SqlCommand Cmd = new SqlCommand();
            Cmd.CommandType = CommandType.Text;
            Cmd.CommandText = SqlCommand;
            Cmd.Connection = Conn;



            if (sqlParameters != null)
                Cmd.Parameters.AddRange(sqlParameters);


            SqlDataAdapter da = new SqlDataAdapter(Cmd);
            da.Fill(dt);
                



        }


        public void Excute(string SqlCommand, SqlParameter[] sqlParameters)
        {
            SqlCommand Cmd = new SqlCommand();
            Cmd.CommandType = CommandType.Text;
            Cmd.CommandText = SqlCommand;
            Cmd.Connection = Conn;



            if (sqlParameters != null)
                Cmd.Parameters.AddRange(sqlParameters);


            Cmd.ExecuteNonQuery();



        }


    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TEST_Project
{
    class LoginHandler
    {
        public bool LoginCheck(string name, string birth, string password)
        {
            SqlConnection conn = new SqlConnection("Server=DESKTOP-R0HJ877; Database=ProjectDB; uid=ks2017848028; pwd=848028");
            SqlDataReader reader = null;
            SqlCommand comm = new SqlCommand();
            comm.CommandText = "SELECT NAME, BIRTHDATE, PASSWORD FROM Sv_user WHERE NAME = @name and BIRTHDATE = @birth and PASSWORD = @password";
            comm.Parameters.Add("@name", SqlDbType.NVarChar, 50).Value = name;
            comm.Parameters.Add("@birth", SqlDbType.Date).Value = birth;
            comm.Parameters.Add("@password", SqlDbType.NChar, 30).Value = password;
            comm.Connection = conn;
            
            conn.Open();
            reader = comm.ExecuteReader();
            
            if (reader.Read())
            {
                reader.Close();
                comm.CommandText = "SELECT NAME, BIRTHDATE FROM Sv_result WHERE NAME = @name and BIRTHDATE = @birth";
                reader = comm.ExecuteReader();
                if (reader.Read())
                {
                    MessageBox.Show("이미 참여하였습니다.");
                    reader.Close();
                    conn.Close();
                    return false;
                }
                else
                {
                    reader.Close();
                    conn.Close();
                    return true;
                }
            }
            else
            {
                reader.Close();
                conn.Close();
                return false;
            }
        }
    }
}

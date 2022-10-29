using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TEST_Project
{
    public partial class Admin : Form
    {
        SqlConnection conn = new SqlConnection("Server=DESKTOP-R0HJ877; Database=ProjectDB; uid=ks2017848028; pwd=848028");
        SqlCommand comm = new SqlCommand();
        public Admin()
        {
            InitializeComponent();
            AdminPw.KeyDown += AdminPw_KeyDown;
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            AdminPw.Focus();
        }


        private void AdminPw_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    AdminCheck();
                    break;
                case Keys.Escape:
                    this.Close();
                    break;
            }
        }
        private void AdminCheck()
        {
            if(AdminPw.Text == "asdf1234")
            {
                pwPanel.Visible = false;
                Finish.Visible = true;
                Unfinish.Visible = true;
            }
            else
            {
                MessageBox.Show("암호를 틀렸습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
                AdminPw.Clear();
                AdminPw.Focus();
            }
        }

        private void Finish_Click(object sender, EventArgs e)
        {
            conn.Open();
            comm.Connection = conn;
            comm.CommandText = "SELECT COUNT(*) FROM Sv_result";
            int finUser = Convert.ToInt32(comm.ExecuteScalar());
            conn.Close();

            MessageBox.Show("총 " + finUser + "명 입니다.", "참여인원");
        }

        private void Unfinish_Click(object sender, EventArgs e)
        {
            conn.Open();
            comm.Connection = conn;
            comm.CommandText = "SELECT COUNT(*) FROM Sv_result";
            int finUser = Convert.ToInt32(comm.ExecuteScalar());
            comm.CommandText = "SELECT COUNT(*) FROM Sv_user";
            int unfinUser = Convert.ToInt32(comm.ExecuteScalar()) - finUser;
            conn.Close();

            MessageBox.Show("총 " + unfinUser + "명 입니다.", "미참여인원");
        }
    }
}

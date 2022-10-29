using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TEST_Project
{
    partial class Survey : Form
    {
        Log_In login;
        int form_height;
        int btn_location;
        string name, date;
        byte user_gender=2, goodbad=2;
        string likecr=null, hatecr = null, likefd = null, hatefd = null;
        public Survey()
        {
            InitializeComponent();
        }
        public void EventMethods(string re_name, string re_date)
        {
            name = re_name;
            date = re_date;
        }
        private void Survey_Load(object sender, EventArgs e)
        {
            form_height = Size.Height;
            btn_location = Finish.Location.Y;
            login = new Log_In();
            login.SendNDEvent += EventMethods;
            login.loginEventHandler += new EventHandler(LoginSuccess);
            switch(login.ShowDialog())
            {
                case DialogResult.OK:
                    login.Close();
                    break;
                case DialogResult.Cancel:
                    Dispose();
                    break;
            }
        }
        private void LoginSuccess(string userName)
        {
            MessageBox.Show(userName+"님 설문조사를 시작하겠습니다.");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            LikeC.BackColor = colorDialog1.Color;
            likecr = colorDialog1.Color.Name;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            HateC.BackColor = colorDialog1.Color;
            hatecr = colorDialog1.Color.Name;
        }
        private void male_CheckedChanged(object sender, EventArgs e)
        {
            user_gender = 1;
        }

        private void female_CheckedChanged(object sender, EventArgs e)
        {
            user_gender = 0;
        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            goodbad = 1;
            Size = new Size(Size.Width, form_height);
            this.Height += 100;
            Finish.Location = new Point(Finish.Location.X, btn_location);
            Finish.Visible = true;
            checkedListBox1.Visible = false;
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
                checkedListBox1.SetItemChecked(i, false);
            checkedListBox1.ClearSelected();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            goodbad = 0;
            Size = new Size(Size.Width, form_height);
            this.Height += 200;
            checkedListBox1.Visible = true;
            Finish.Location = new Point(Finish.Location.X, Finish.Location.Y+100);
            Finish.Visible = true;
        }

        private void Finish_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("정보는 다시 수정이 불가능합니다.\n설문조사를 종료하시겠습니까?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                likefd = LikeF.Text;
                hatefd = HateF.Text;
                if (user_gender == 2 || goodbad == 2 || likecr == null | hatecr == null || likefd == null | hatefd == null)
                {
                    MessageBox.Show("입력되지 않은 항목이 있습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    SqlConnection conn = new SqlConnection("Server=DESKTOP-R0HJ877; Database=ProjectDB; uid=ks2017848028; pwd=848028");
                    conn.Open();
                    SqlCommand comm = new SqlCommand();
                    comm.Connection = conn;
                    comm.Parameters.AddWithValue("@name", name);
                    comm.Parameters.AddWithValue("@birth", date);
                    comm.Parameters.AddWithValue("@gender", user_gender);
                    comm.Parameters.AddWithValue("@likeCr", likecr);
                    comm.Parameters.AddWithValue("@hateCr", hatecr);
                    comm.Parameters.AddWithValue("@likeFd", likefd);
                    comm.Parameters.AddWithValue("@hateFd", hatefd);
                    comm.Parameters.AddWithValue("@goodBad", goodbad);
                    comm.CommandText = "insert into Sv_result(NAME,BIRTHDATE,GENDER,LIKECR,HATECR,LIKEFD,HATEFD,GOODBAD,BCHECK1,BCHECK2,BCHECK3,BCHECK4,BCHECK0) values (@name,@birth,@gender,@likeCr,@hateCr,@likeFd,@hateFd,@goodBad,null,null,null,null,null)";
                    comm.ExecuteNonQuery();
                    if (goodbad == 0)
                    {
                        foreach (int indexChecked in checkedListBox1.CheckedIndices)
                        {
                            if (indexChecked == 0)
                            {
                                comm.CommandText = "UPDATE Sv_result SET BCHECK1 = 1 WHERE NAME = @name and BIRTHDATE = @birth"; comm.ExecuteNonQuery();
                            }
                            if (indexChecked == 1)
                            {
                                comm.CommandText = "UPDATE Sv_result SET BCHECK2 = 1 WHERE NAME = @name and BIRTHDATE = @birth"; comm.ExecuteNonQuery();
                            }
                            if (indexChecked == 2)
                            {
                                comm.CommandText = "UPDATE Sv_result SET BCHECK3 = 1 WHERE NAME = @name and BIRTHDATE = @birth"; comm.ExecuteNonQuery();
                            }
                            if (indexChecked == 3)
                            {
                                comm.CommandText = "UPDATE Sv_result SET BCHECK4 = 1 WHERE NAME = @name and BIRTHDATE = @birth"; comm.ExecuteNonQuery();
                            }
                            if (indexChecked == 4)
                            {
                                comm.CommandText = "UPDATE Sv_result SET BCHECK0 = 1 WHERE NAME = @name and BIRTHDATE = @birth"; comm.ExecuteNonQuery();
                            }
                        }
                    }
                    conn.Close();
                    this.Close();
                }
            }  
        }
    }
}

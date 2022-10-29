using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TEST_Project
{
    public delegate void EventHandler(string userName);
    public partial class Log_In : Form
    {
        public delegate void SendNameDate(string name, string birth);
        public event SendNameDate SendNDEvent;
        public EventHandler loginEventHandler;
        public Log_In()
        {
            InitializeComponent();
            this.LoginName.KeyDown += Log_In_KeyDown;
            this.LoginPw.KeyDown += Log_In_KeyDown;
        }
        String birthDate=null;
        private void Log_In_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }
        private void LoginBtn_Click(object sender, EventArgs e)
        { 
            LoginHandler loginHandler = new LoginHandler();
            if (LoginName.Text == "관리자모드")
            {
                Admin admin = new Admin();
                admin.ShowDialog();
            }
            else
            {
                if (ControlCheck())
                {
                    if (loginHandler.LoginCheck(LoginName.Text, birthDate, LoginPw.Text))
                    {
                        string userName = LoginName.Text;
                        loginEventHandler(userName);
                        string name = string.Empty;
                        string date = string.Empty;
                        name = LoginName.Text;
                        date = birthDate;
                        this.SendNDEvent(name, date);
                        DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        MessageBox.Show("로그인에 실패하였습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        LoginName.Clear();
                        LoginPw.Clear();
                        LoginName.Focus();
                        comboBox1.SelectedIndex = -1;
                        comboBox2.SelectedIndex = -1;
                        comboBox3.SelectedIndex = -1;
                        birthDate = null;
                    }
                }
            }
        }
        private bool ControlCheck()
        {
            if(String.IsNullOrEmpty(LoginName.Text))
            {
                MessageBox.Show("이름을 입력하세요.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                LoginName.Focus();
                return false;
            }
            else if (String.IsNullOrEmpty(birthDate))
            {
                MessageBox.Show("생일을 입력하세요.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if (String.IsNullOrEmpty(LoginPw.Text))
            {
                MessageBox.Show("비밀번호를 입력하세요.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                LoginPw.Focus();
                return false;
            }
            return true;
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
         {
            birthDate = null;
            comboBox2.Items.Clear();
            comboBox3.Items.Clear();
            comboBox2.Text="";
            comboBox3.Text="";
            for (int i = 0; i < 12; i++)
            {
                comboBox2.Items.Add(i + 1);
            }
         }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            birthDate = null;
            comboBox3.Text = "";
            comboBox3.Items.Clear();
            String year_txt = comboBox1.SelectedItem as String;
            int year = int.Parse(year_txt);
            int month = comboBox2.SelectedIndex + 1;
            if ((month < 8 && month % 2 == 1) || (month > 7 && month % 2 == 0)){
                for (int i=0; i<31; i++)
                {
                    comboBox3.Items.Add(i+1);
                }
            }
            else if (month!=2&&((month < 8 && month % 2 == 0) || (month > 7 && month % 2 == 1))){
                for (int i = 0; i < 30; i++)
                {
                    comboBox3.Items.Add(i + 1);
                }
            }
            else
            {
                if (year%4==0)
                    for (int i = 0; i < 29; i++)
                    {
                        comboBox3.Items.Add(i + 1);
                    }
                else
                    for (int i = 0; i < 28; i++)
                    {
                        comboBox3.Items.Add(i + 1);
                    }
            }
        }
        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            birthDate = comboBox1.Text + '-';
            if (int.Parse(comboBox2.Text) < 10) birthDate += '0' + comboBox2.Text + '-';
            else birthDate += comboBox2.Text + '-';
            if (int.Parse(comboBox3.Text) < 10) birthDate += '0' + comboBox3.Text;
            else birthDate += comboBox3.Text;
        }

        private void Log_In_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                LoginBtn_Click(sender, e);
            }
        }
    }
}

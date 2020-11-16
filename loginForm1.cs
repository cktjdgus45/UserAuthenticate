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

namespace UserAuthenticate
{
    public partial class loginForm1 : Form
    {
        public static string SetValueForText = "";
        public loginForm1()
        {
            InitializeComponent();
        }

        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\chase\OneDrive\문서\UserData.mdf;Integrated Security=True;Connect Timeout=30";
        private void LoginBtn_Click(object sender, EventArgs e)
        {
            string query = "Select Count(*) from [User] where UserId='" + textBox_id.Text.Trim() + "' and Password='" + textBox_pw.Text.Trim() + "'";
            try
            {
                SqlConnection sqlConnect = new SqlConnection(connectionString);
                SqlDataAdapter sda = new SqlDataAdapter(query, sqlConnect);
                DataTable dataTable = new DataTable();
                sda.Fill(dataTable);
                if (dataTable.Rows[0][0].ToString() == "1")
                {
                    SetValueForText = textBox_id.Text;
                    MessageBox.Show("로그인 성공!");
                    this.Hide();
                    ProfileForm3 profileForm = new ProfileForm3();
                    profileForm.Show();
                }
                else
                    MessageBox.Show("로그인 실패! 아이디와 비밀번호를 확인해주세요");
            }
            catch (Exception er)
            {
                MessageBox.Show($"error!! : {er.Message}");
            }
        }
        private void textBox_id_Enter(object sender, EventArgs e)
        {
            if (textBox_id.Text == "아이디를 입력하세요")
                textBox_id.Text = "";
            textBox_id.ForeColor = Color.Black;
        }
        private void textBox_password_Enter_1(object sender, EventArgs e)
        {
            if (textBox_pw.Text == "비밀번호를 입력하세요")
                textBox_pw.Text = "";
            textBox_pw.ForeColor = Color.Black;
            textBox_pw.PasswordChar ='●';
        }
        private void showJoinBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            joinForm2 joinForm = new joinForm2();
            joinForm.Show();
        }

        private void textBox_pw_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    LoginBtn_Click(sender, e);
                    textBox_pw.Text = "";
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show($"error!! : {ex.Message}");
            }            
        }

        private void textBox_id_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    LoginBtn_Click(sender, e);
                    textBox_id.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"error!! : {ex.Message}");
            }
        }
    }
}

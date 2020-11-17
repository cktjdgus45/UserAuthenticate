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
    public partial class joinForm2 : Form
    {
        public joinForm2()
        {
            InitializeComponent();
        }
        
        private string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\chase\OneDrive\문서\UserData.mdf;Integrated Security=True;Connect Timeout=30";
        //private string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDBFilename=|DataDirectory|UserData.mdf;Integrated Security = True;Connect Timeout=30";
        private void RegisterBtn_Click(object sender, EventArgs e)
        {
            if (isIdOverlap())
            {
                MessageBox.Show("이미 사용하고 있는 아이디 입니다.");
                Clear();
                placeHolder();
            }
            else if (joinTextBox_pw.Text != joinTextBox_pw2.Text)
                MessageBox.Show("1차비밀번호와 2차비밀번호가 일치하지 않습니다.");
            else if (joinTextBox_id.Text == "아이디를 입력하세요")      //placeholder = " ";
                MessageBox.Show("아이디를 입력해주세요");
            else if (joinTextBox_name.Text == "이름을 입력하세요")
                MessageBox.Show("이름을 입력해주세요");
            else
            {
                try
                {
                    SqlConnection sqlCon = new SqlConnection(connectionString);
                    sqlCon.Open();
                    SqlCommand sqlCmd = new SqlCommand("UserAdd", sqlCon);
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.Parameters.AddWithValue("@UserId", joinTextBox_id.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Password", joinTextBox_pw.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@UserName", joinTextBox_name.Text.Trim());
                    sqlCmd.ExecuteNonQuery();
                    MessageBox.Show("회원가입이 완료되었습니다.");
                    this.Hide();
                    loginForm1 LoginForm = new loginForm1();
                    LoginForm.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"error !! {ex.Message}");
                }
            }
        }

        private void Clear()
        {
            joinTextBox_id.Text = joinTextBox_pw.Text = joinTextBox_pw2.Text = joinTextBox_name.Text = "";
        }

        private void placeHolder()
        {
            joinTextBox_id.Text = "아이디를 입력하세요";
            joinTextBox_pw.Text = "비밀번호를 입력하세요";
            joinTextBox_pw2.Text = "2차 비밀번호를 입력하세요";
            joinTextBox_name.Text = "이름을 입력하세요";
            joinTextBox_pw.PasswordChar = '\0';
            joinTextBox_pw2.PasswordChar = '\0';
        }

        private bool isIdOverlap()
        {
            string UserId;
            string query = "Select UserId from [User] where UserId=@UserId";
            try
            {
                SqlConnection sqlConnect = new SqlConnection(connectionString);
                sqlConnect.Open();
                SqlCommand cmd = new SqlCommand(query, sqlConnect);
                cmd.Parameters.AddWithValue("@UserId", joinTextBox_id.Text);
                SqlDataReader getData = cmd.ExecuteReader();
                while (getData.Read())
                {
                    UserId = getData.GetValue(0).ToString();
                    if (UserId == joinTextBox_id.Text)
                        return true;
                }
            }
            catch (Exception er)
            {
                MessageBox.Show($"error!! : {er.Message}");
            }
            return false;
        }

        private void joinTextBox_id_Enter(object sender, EventArgs e)
        {
            if (joinTextBox_id.Text == "아이디를 입력하세요")
                joinTextBox_id.Text = "";
            joinTextBox_id.ForeColor = Color.Black;
        }

        private void joinTextBox_id_Leave(object sender, EventArgs e)
        {
            if (joinTextBox_id.Text == "")
                joinTextBox_id.Text = "아이디를 입력하세요";
            joinTextBox_id.ForeColor = Color.DarkGray;
        }

        private void joinTextBox_pw_Enter(object sender, EventArgs e)
        {
            if (joinTextBox_pw.Text == "비밀번호를 입력하세요")
                joinTextBox_pw.Text = "";
            joinTextBox_pw.ForeColor = Color.Black;
            joinTextBox_pw.PasswordChar = '●';
        }

        private void joinTextBox_pw_Leave(object sender, EventArgs e)
        {
            joinTextBox_pw.PasswordChar = '\0';
            joinTextBox_pw.ForeColor = Color.DarkGray;

            if (joinTextBox_pw.Text == "")
                joinTextBox_pw.Text = "비밀번호를 입력하세요";
            else
                joinTextBox_pw.PasswordChar = '●';
        }

        private void joinTextBox_pw2_Enter(object sender, EventArgs e)
        {
            if (joinTextBox_pw2.Text == "2차 비밀번호를 입력하세요")
                joinTextBox_pw2.Text = "";
            joinTextBox_pw2.ForeColor = Color.Black;
            joinTextBox_pw2.PasswordChar = '●';
        }

        private void joinTextBox_pw2_Leave(object sender, EventArgs e)
        {
            joinTextBox_pw2.PasswordChar = '\0';
            joinTextBox_pw2.ForeColor = Color.DarkGray;

            if (joinTextBox_pw2.Text == "")
                joinTextBox_pw2.Text = "2차 비밀번호를 입력하세요";
            else
                joinTextBox_pw2.PasswordChar = '●';
        }

        private void joinTextBox_name_Enter(object sender, EventArgs e)
        {
            if (joinTextBox_name.Text == "이름을 입력하세요")
                joinTextBox_name.Text = "";
            joinTextBox_name.ForeColor = Color.Black;
        }

        private void joinTextBox_name_Leave(object sender, EventArgs e)
        {
            if (joinTextBox_name.Text == "")
                joinTextBox_name.Text = "이름을 입력하세요";
            joinTextBox_name.ForeColor = Color.DarkGray;
        }

        private void joinTextBox_id_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                RegisterBtn_Click(sender, e);
                joinTextBox_id.Text = "";
            }
        }

        private void joinTextBox_pw_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                RegisterBtn_Click(sender, e);
                joinTextBox_pw.Text = "";
            }
        }

        private void joinTextBox_pw2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                RegisterBtn_Click(sender, e);
                joinTextBox_pw2.Text = "";
            }
        }

        private void joinTextBox_name_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                RegisterBtn_Click(sender, e);
                joinTextBox_name.Text = "";
            }
        }
    }
}
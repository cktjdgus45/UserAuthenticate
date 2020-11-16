using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace UserAuthenticate
{
    public partial class EditForm4 : Form
    {
        private string fixedId = "";
        public EditForm4()
        {
            InitializeComponent();
            editTextBox_id.Text = ProfileForm3.SetValueForText2;
            fixedId = ProfileForm3.SetValueForText2;
        }
        private void editBtn_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\chase\OneDrive\문서\UserData.mdf;Integrated Security=True;Connect Timeout=30";

                if (editTextBox_pw.Text != editTextBox_pw2.Text)
                    MessageBox.Show("1차비밀번호와 2차비밀번호가 일치하지 않습니다.");
                else if (editTextBox_id.Text != fixedId.Trim())      //placeholder = " ";
                    MessageBox.Show("아이디는 변경할 수 없습니다.");
                else if (editTextBox_name.Text == "이름을 입력하세요")
                    MessageBox.Show("이름을 입력해주세요");
                else
                {
                    try
                    {
                        SqlConnection sqlCon = new SqlConnection(connectionString);                  
                        sqlCon.Open();
                        SqlCommand sqlCmd = new SqlCommand("UserUpdate", sqlCon);
                        sqlCmd.CommandType = CommandType.StoredProcedure;
                        sqlCmd.Parameters.AddWithValue("@UserId", editTextBox_id.Text.Trim());
                        sqlCmd.Parameters.AddWithValue("@Password", editTextBox_pw.Text.Trim());
                        sqlCmd.Parameters.AddWithValue("@UserName", editTextBox_name.Text.Trim());
                        sqlCmd.ExecuteNonQuery();
                        MessageBox.Show("정보수정이 완료되었습니다.");
                        this.Hide();
                        loginForm1 LoginForm = new loginForm1();
                        LoginForm.Show();
                    }catch(Exception er)
                    {
                        MessageBox.Show($"error!! : {er.Message}");
                    }                   
                }          
        }
        private void editTextBox_name_Enter(object sender, EventArgs e)
        {
            if (editTextBox_name.Text == "이름을 입력하세요")
                editTextBox_name.Text = "";
            editTextBox_name.ForeColor = Color.Black;
        }

        private void editTextBox_name_Leave(object sender, EventArgs e)
        {
            if (editTextBox_name.Text == "")
                editTextBox_name.Text = "이름을 입력하세요";
            editTextBox_name.ForeColor = Color.DarkGray;
        }

        private void editTextBox_pw2_Enter(object sender, EventArgs e)
        {
            if (editTextBox_pw2.Text == "2차 비밀번호를 입력하세요")
                editTextBox_pw2.Text = "";
            editTextBox_pw2.ForeColor = Color.Black;
            editTextBox_pw2.PasswordChar = '●';
        }
        private void editTextBox_pw2_Leave(object sender, EventArgs e)
        {
            editTextBox_pw2.PasswordChar = '\0';
            editTextBox_pw2.ForeColor = Color.DarkGray;

            if (editTextBox_pw2.Text == "")
                editTextBox_pw2.Text = "2차 비밀번호를 입력하세요";
            else
                editTextBox_pw2.PasswordChar = '●';
        }
        private void editTextBox_pw_Enter(object sender, EventArgs e)
        {
            if (editTextBox_pw.Text == "비밀번호를 입력하세요")
                editTextBox_pw.Text = "";
            editTextBox_pw.ForeColor = Color.Black;
            editTextBox_pw.PasswordChar = '●';
        }
        private void editTextBox_pw_Leave(object sender, EventArgs e)
        {
            editTextBox_pw.PasswordChar = '\0';
            editTextBox_pw.ForeColor = Color.DarkGray;

            if (editTextBox_pw.Text == "")
                editTextBox_pw.Text = "비밀번호를 입력하세요";
            else
                editTextBox_pw.PasswordChar = '●';
        }
        private void editTextBox_id_Enter(object sender, EventArgs e)
        {
            if (editTextBox_id.Text == "아이디를 입력하세요")
                editTextBox_id.Text = "";
            editTextBox_id.ForeColor = Color.Black;
        }
        private void editTextBox_id_Leave(object sender, EventArgs e)
        {
            if (editTextBox_id.Text == "")
                editTextBox_id.Text = "아이디를 입력하세요";
            editTextBox_id.ForeColor = Color.DarkGray;
        }

        private void editTextBox_id_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    editBtn_Click(sender, e);
                    editTextBox_id.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"error!! : {ex.Message}");
            }
        }

        private void editTextBox_pw_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    editBtn_Click(sender, e);
                    editTextBox_pw.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"error!! : {ex.Message}");
            }
        }

        private void editTextBox_pw2_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    editBtn_Click(sender, e);
                    editTextBox_pw2.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"error!! : {ex.Message}");
            }
        }

        private void editTextBox_name_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    editBtn_Click(sender, e);
                    editTextBox_name.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"error!! : {ex.Message}");
            }
        }
    }
}

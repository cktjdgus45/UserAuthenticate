namespace UserAuthenticate
{
    partial class EditForm4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditForm4));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.editTextBox_pw2 = new System.Windows.Forms.TextBox();
            this.editBtn = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.editTextBox_id = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.editTextBox_name = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.editTextBox_pw = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.panel5);
            this.groupBox2.Controls.Add(this.editBtn);
            this.groupBox2.Controls.Add(this.panel3);
            this.groupBox2.Controls.Add(this.panel6);
            this.groupBox2.Controls.Add(this.panel4);
            this.groupBox2.Location = new System.Drawing.Point(29, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(502, 576);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.Window;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.editTextBox_pw2);
            this.panel5.Location = new System.Drawing.Point(61, 230);
            this.panel5.Name = "panel5";
            this.panel5.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.panel5.Size = new System.Drawing.Size(375, 47);
            this.panel5.TabIndex = 3;
            // 
            // editTextBox_pw2
            // 
            this.editTextBox_pw2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.editTextBox_pw2.Font = new System.Drawing.Font("맑은 고딕", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.editTextBox_pw2.ForeColor = System.Drawing.Color.DarkGray;
            this.editTextBox_pw2.Location = new System.Drawing.Point(-1, 10);
            this.editTextBox_pw2.Multiline = true;
            this.editTextBox_pw2.Name = "editTextBox_pw2";
            this.editTextBox_pw2.Size = new System.Drawing.Size(371, 27);
            this.editTextBox_pw2.TabIndex = 0;
            this.editTextBox_pw2.Text = "2차 비밀번호를 입력하세요";
            this.editTextBox_pw2.Enter += new System.EventHandler(this.editTextBox_pw2_Enter);
            this.editTextBox_pw2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.editTextBox_pw2_KeyDown);
            this.editTextBox_pw2.Leave += new System.EventHandler(this.editTextBox_pw2_Leave);
            // 
            // editBtn
            // 
            this.editBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(223)))), ((int)(((byte)(252)))));
            this.editBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.editBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(223)))), ((int)(((byte)(252)))));
            this.editBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editBtn.Font = new System.Drawing.Font("맑은 고딕", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.editBtn.ForeColor = System.Drawing.Color.White;
            this.editBtn.Location = new System.Drawing.Point(61, 476);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(375, 49);
            this.editBtn.TabIndex = 0;
            this.editBtn.Text = "수정";
            this.editBtn.UseVisualStyleBackColor = false;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Window;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.editTextBox_id);
            this.panel3.Location = new System.Drawing.Point(61, 80);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.panel3.Size = new System.Drawing.Size(375, 47);
            this.panel3.TabIndex = 1;
            // 
            // editTextBox_id
            // 
            this.editTextBox_id.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.editTextBox_id.Font = new System.Drawing.Font("맑은 고딕", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.editTextBox_id.ForeColor = System.Drawing.Color.DarkGray;
            this.editTextBox_id.Location = new System.Drawing.Point(-1, 10);
            this.editTextBox_id.Multiline = true;
            this.editTextBox_id.Name = "editTextBox_id";
            this.editTextBox_id.Size = new System.Drawing.Size(375, 27);
            this.editTextBox_id.TabIndex = 0;
            this.editTextBox_id.Text = "아이디를 입력하세요";
            this.editTextBox_id.Enter += new System.EventHandler(this.editTextBox_id_Enter);
            this.editTextBox_id.KeyDown += new System.Windows.Forms.KeyEventHandler(this.editTextBox_id_KeyDown);
            this.editTextBox_id.Leave += new System.EventHandler(this.editTextBox_id_Leave);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.Window;
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.editTextBox_name);
            this.panel6.Location = new System.Drawing.Point(61, 309);
            this.panel6.Name = "panel6";
            this.panel6.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.panel6.Size = new System.Drawing.Size(375, 47);
            this.panel6.TabIndex = 4;
            // 
            // editTextBox_name
            // 
            this.editTextBox_name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.editTextBox_name.Font = new System.Drawing.Font("맑은 고딕", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.editTextBox_name.ForeColor = System.Drawing.Color.DarkGray;
            this.editTextBox_name.Location = new System.Drawing.Point(-1, 11);
            this.editTextBox_name.Multiline = true;
            this.editTextBox_name.Name = "editTextBox_name";
            this.editTextBox_name.Size = new System.Drawing.Size(371, 27);
            this.editTextBox_name.TabIndex = 0;
            this.editTextBox_name.Text = "이름을 입력하세요";
            this.editTextBox_name.WordWrap = false;
            this.editTextBox_name.Enter += new System.EventHandler(this.editTextBox_name_Enter);
            this.editTextBox_name.KeyDown += new System.Windows.Forms.KeyEventHandler(this.editTextBox_name_KeyDown);
            this.editTextBox_name.Leave += new System.EventHandler(this.editTextBox_name_Leave);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.Window;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.editTextBox_pw);
            this.panel4.Location = new System.Drawing.Point(61, 150);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.panel4.Size = new System.Drawing.Size(375, 47);
            this.panel4.TabIndex = 2;
            // 
            // editTextBox_pw
            // 
            this.editTextBox_pw.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.editTextBox_pw.Font = new System.Drawing.Font("맑은 고딕", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.editTextBox_pw.ForeColor = System.Drawing.Color.DarkGray;
            this.editTextBox_pw.Location = new System.Drawing.Point(-1, 11);
            this.editTextBox_pw.Multiline = true;
            this.editTextBox_pw.Name = "editTextBox_pw";
            this.editTextBox_pw.Size = new System.Drawing.Size(371, 27);
            this.editTextBox_pw.TabIndex = 0;
            this.editTextBox_pw.Text = "비밀번호를 입력하세요";
            this.editTextBox_pw.WordWrap = false;
            this.editTextBox_pw.Enter += new System.EventHandler(this.editTextBox_pw_Enter);
            this.editTextBox_pw.KeyDown += new System.Windows.Forms.KeyEventHandler(this.editTextBox_pw_KeyDown);
            this.editTextBox_pw.Leave += new System.EventHandler(this.editTextBox_pw_Leave);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Location = new System.Drawing.Point(530, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(947, 576);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::UserAuthenticate.Properties.Resources.like;
            this.pictureBox1.Location = new System.Drawing.Point(0, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(937, 567);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // EditForm4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1479, 612);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EditForm4";
            this.Text = "계정 정보 변경";
            this.groupBox2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox editTextBox_pw2;
        private System.Windows.Forms.Button editBtn;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox editTextBox_id;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox editTextBox_name;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox editTextBox_pw;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
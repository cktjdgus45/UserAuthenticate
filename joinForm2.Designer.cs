namespace UserAuthenticate
{
    partial class joinForm2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(joinForm2));
            this.joinTextBox_id = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.joinTextBox_pw = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.joinTextBox_pw2 = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.joinTextBox_name = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.joinBtn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // joinTextBox_id
            // 
            this.joinTextBox_id.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.joinTextBox_id.Font = new System.Drawing.Font("맑은 고딕", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.joinTextBox_id.ForeColor = System.Drawing.Color.DarkGray;
            this.joinTextBox_id.Location = new System.Drawing.Point(-1, 10);
            this.joinTextBox_id.Multiline = true;
            this.joinTextBox_id.Name = "joinTextBox_id";
            this.joinTextBox_id.Size = new System.Drawing.Size(375, 27);
            this.joinTextBox_id.TabIndex = 0;
            this.joinTextBox_id.Text = "아이디를 입력하세요";
            this.joinTextBox_id.Enter += new System.EventHandler(this.joinTextBox_id_Enter);
            this.joinTextBox_id.KeyDown += new System.Windows.Forms.KeyEventHandler(this.joinTextBox_id_KeyDown);
            this.joinTextBox_id.Leave += new System.EventHandler(this.joinTextBox_id_Leave);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Window;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.joinTextBox_id);
            this.panel3.Location = new System.Drawing.Point(61, 80);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.panel3.Size = new System.Drawing.Size(375, 47);
            this.panel3.TabIndex = 1;
            // 
            // joinTextBox_pw
            // 
            this.joinTextBox_pw.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.joinTextBox_pw.Font = new System.Drawing.Font("맑은 고딕", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.joinTextBox_pw.ForeColor = System.Drawing.Color.DarkGray;
            this.joinTextBox_pw.Location = new System.Drawing.Point(-1, 11);
            this.joinTextBox_pw.Multiline = true;
            this.joinTextBox_pw.Name = "joinTextBox_pw";
            this.joinTextBox_pw.Size = new System.Drawing.Size(371, 27);
            this.joinTextBox_pw.TabIndex = 0;
            this.joinTextBox_pw.Text = "비밀번호를 입력하세요";
            this.joinTextBox_pw.WordWrap = false;
            this.joinTextBox_pw.Enter += new System.EventHandler(this.joinTextBox_pw_Enter);
            this.joinTextBox_pw.KeyDown += new System.Windows.Forms.KeyEventHandler(this.joinTextBox_pw_KeyDown);
            this.joinTextBox_pw.Leave += new System.EventHandler(this.joinTextBox_pw_Leave);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.Window;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.joinTextBox_pw);
            this.panel4.Location = new System.Drawing.Point(61, 148);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.panel4.Size = new System.Drawing.Size(375, 47);
            this.panel4.TabIndex = 2;
            // 
            // joinTextBox_pw2
            // 
            this.joinTextBox_pw2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.joinTextBox_pw2.Font = new System.Drawing.Font("맑은 고딕", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.joinTextBox_pw2.ForeColor = System.Drawing.Color.DarkGray;
            this.joinTextBox_pw2.Location = new System.Drawing.Point(-1, 10);
            this.joinTextBox_pw2.Multiline = true;
            this.joinTextBox_pw2.Name = "joinTextBox_pw2";
            this.joinTextBox_pw2.Size = new System.Drawing.Size(371, 27);
            this.joinTextBox_pw2.TabIndex = 0;
            this.joinTextBox_pw2.Text = "2차 비밀번호를 입력하세요";
            this.joinTextBox_pw2.Enter += new System.EventHandler(this.joinTextBox_pw2_Enter);
            this.joinTextBox_pw2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.joinTextBox_pw2_KeyDown);
            this.joinTextBox_pw2.Leave += new System.EventHandler(this.joinTextBox_pw2_Leave);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.Window;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.joinTextBox_pw2);
            this.panel5.Location = new System.Drawing.Point(61, 230);
            this.panel5.Name = "panel5";
            this.panel5.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.panel5.Size = new System.Drawing.Size(375, 47);
            this.panel5.TabIndex = 3;
            // 
            // joinTextBox_name
            // 
            this.joinTextBox_name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.joinTextBox_name.Font = new System.Drawing.Font("맑은 고딕", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.joinTextBox_name.ForeColor = System.Drawing.Color.DarkGray;
            this.joinTextBox_name.Location = new System.Drawing.Point(-1, 11);
            this.joinTextBox_name.Multiline = true;
            this.joinTextBox_name.Name = "joinTextBox_name";
            this.joinTextBox_name.Size = new System.Drawing.Size(371, 27);
            this.joinTextBox_name.TabIndex = 0;
            this.joinTextBox_name.Text = "이름을 입력하세요";
            this.joinTextBox_name.WordWrap = false;
            this.joinTextBox_name.Enter += new System.EventHandler(this.joinTextBox_name_Enter);
            this.joinTextBox_name.KeyDown += new System.Windows.Forms.KeyEventHandler(this.joinTextBox_name_KeyDown);
            this.joinTextBox_name.Leave += new System.EventHandler(this.joinTextBox_name_Leave);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.Window;
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.joinTextBox_name);
            this.panel6.Location = new System.Drawing.Point(61, 309);
            this.panel6.Name = "panel6";
            this.panel6.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.panel6.Size = new System.Drawing.Size(375, 47);
            this.panel6.TabIndex = 4;
            // 
            // joinBtn
            // 
            this.joinBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(223)))), ((int)(((byte)(252)))));
            this.joinBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.joinBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(223)))), ((int)(((byte)(252)))));
            this.joinBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.joinBtn.Font = new System.Drawing.Font("맑은 고딕", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.joinBtn.ForeColor = System.Drawing.Color.White;
            this.joinBtn.Location = new System.Drawing.Point(57, 471);
            this.joinBtn.Name = "joinBtn";
            this.joinBtn.Size = new System.Drawing.Size(375, 49);
            this.joinBtn.TabIndex = 0;
            this.joinBtn.Text = "회원가입";
            this.joinBtn.UseVisualStyleBackColor = false;
            this.joinBtn.Click += new System.EventHandler(this.RegisterBtn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.panel5);
            this.groupBox2.Controls.Add(this.joinBtn);
            this.groupBox2.Controls.Add(this.panel3);
            this.groupBox2.Controls.Add(this.panel6);
            this.groupBox2.Controls.Add(this.panel4);
            this.groupBox2.Location = new System.Drawing.Point(30, 17);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(499, 576);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Location = new System.Drawing.Point(526, 17);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(940, 576);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::UserAuthenticate.Properties.Resources.like;
            this.pictureBox1.Location = new System.Drawing.Point(0, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(937, 567);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // joinForm2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1478, 622);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "joinForm2";
            this.Text = "회원가입";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox joinTextBox_id;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox joinTextBox_pw;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox joinTextBox_pw2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox joinTextBox_name;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button joinBtn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
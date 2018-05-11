namespace AirlineApplication
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.userTextBox1 = new System.Windows.Forms.TextBox();
            this.passTextBox2 = new System.Windows.Forms.TextBox();
            this.userName = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.Label();
            this.loginBtn = new System.Windows.Forms.Button();
            this.signupBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.userWLabel = new System.Windows.Forms.Label();
            this.passWLabel = new System.Windows.Forms.Label();
            this.forgotPassBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.DarkGray;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(884, 487);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // userTextBox1
            // 
            this.userTextBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.userTextBox1.Location = new System.Drawing.Point(186, 273);
            this.userTextBox1.Name = "userTextBox1";
            this.userTextBox1.Size = new System.Drawing.Size(176, 20);
            this.userTextBox1.TabIndex = 2;
            // 
            // passTextBox2
            // 
            this.passTextBox2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.passTextBox2.Location = new System.Drawing.Point(186, 344);
            this.passTextBox2.Name = "passTextBox2";
            this.passTextBox2.PasswordChar = '*';
            this.passTextBox2.Size = new System.Drawing.Size(176, 20);
            this.passTextBox2.TabIndex = 3;
            // 
            // userName
            // 
            this.userName.AutoSize = true;
            this.userName.BackColor = System.Drawing.Color.Silver;
            this.userName.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userName.Location = new System.Drawing.Point(61, 273);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(105, 23);
            this.userName.TabIndex = 4;
            this.userName.Text = "Username";
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.BackColor = System.Drawing.Color.Silver;
            this.Password.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password.Location = new System.Drawing.Point(66, 340);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(102, 23);
            this.Password.TabIndex = 5;
            this.Password.Text = "Password";
            this.Password.Click += new System.EventHandler(this.Password_Click);
            // 
            // loginBtn
            // 
            this.loginBtn.BackColor = System.Drawing.Color.SteelBlue;
            this.loginBtn.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.loginBtn.Location = new System.Drawing.Point(167, 419);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(93, 49);
            this.loginBtn.TabIndex = 6;
            this.loginBtn.Text = "Login";
            this.loginBtn.UseVisualStyleBackColor = false;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // signupBtn
            // 
            this.signupBtn.BackColor = System.Drawing.Color.ForestGreen;
            this.signupBtn.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signupBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.signupBtn.Location = new System.Drawing.Point(268, 419);
            this.signupBtn.Name = "signupBtn";
            this.signupBtn.Size = new System.Drawing.Size(111, 49);
            this.signupBtn.TabIndex = 7;
            this.signupBtn.Text = "Sign-Up";
            this.signupBtn.UseVisualStyleBackColor = false;
            this.signupBtn.Click += new System.EventHandler(this.signupBtn_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Teal;
            this.label1.Font = new System.Drawing.Font("Broadway", 29.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(25, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(836, 70);
            this.label1.TabIndex = 8;
            this.label1.Text = "WELCOME  TO  BANGLADESH  AIRLINE";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // userWLabel
            // 
            this.userWLabel.AutoSize = true;
            this.userWLabel.Location = new System.Drawing.Point(388, 273);
            this.userWLabel.Name = "userWLabel";
            this.userWLabel.Size = new System.Drawing.Size(10, 13);
            this.userWLabel.TabIndex = 12;
            this.userWLabel.Text = ".";
            // 
            // passWLabel
            // 
            this.passWLabel.AutoSize = true;
            this.passWLabel.Location = new System.Drawing.Point(388, 347);
            this.passWLabel.Name = "passWLabel";
            this.passWLabel.Size = new System.Drawing.Size(10, 13);
            this.passWLabel.TabIndex = 13;
            this.passWLabel.Text = ".";
            // 
            // forgotPassBtn
            // 
            this.forgotPassBtn.BackColor = System.Drawing.Color.Brown;
            this.forgotPassBtn.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forgotPassBtn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.forgotPassBtn.Location = new System.Drawing.Point(387, 419);
            this.forgotPassBtn.Margin = new System.Windows.Forms.Padding(2);
            this.forgotPassBtn.Name = "forgotPassBtn";
            this.forgotPassBtn.Size = new System.Drawing.Size(214, 49);
            this.forgotPassBtn.TabIndex = 14;
            this.forgotPassBtn.Text = "Forgot Password?";
            this.forgotPassBtn.UseVisualStyleBackColor = false;
            this.forgotPassBtn.Click += new System.EventHandler(this.forgotPassBtn_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(685, 199);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "admin";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(685, 263);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 16;
            this.button2.Text = "passenger";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(685, 340);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 17;
            this.button3.Text = "emp";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 487);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.forgotPassBtn);
            this.Controls.Add(this.passWLabel);
            this.Controls.Add(this.userWLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.signupBtn);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.userName);
            this.Controls.Add(this.passTextBox2);
            this.Controls.Add(this.userTextBox1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox userTextBox1;
        private System.Windows.Forms.TextBox passTextBox2;
        private System.Windows.Forms.Label userName;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.Button signupBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label userWLabel;
        private System.Windows.Forms.Label passWLabel;
        private System.Windows.Forms.Button forgotPassBtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}


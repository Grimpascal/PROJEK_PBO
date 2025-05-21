namespace Agromart
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textUsername = new TextBox();
            label1 = new Label();
            label2 = new Label();
            textPassword = new TextBox();
            loginButton = new Button();
            label3 = new Label();
            checkHide = new CheckBox();
            SuspendLayout();
            // 
            // textUsername
            // 
            textUsername.Location = new Point(476, 215);
            textUsername.Name = "textUsername";
            textUsername.Size = new Size(167, 31);
            textUsername.TabIndex = 0;
            textUsername.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(476, 187);
            label1.Name = "label1";
            label1.Size = new Size(91, 25);
            label1.TabIndex = 1;
            label1.Text = "Username";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(476, 251);
            label2.Name = "label2";
            label2.Size = new Size(87, 25);
            label2.TabIndex = 3;
            label2.Text = "Password";
            // 
            // textPassword
            // 
            textPassword.Location = new Point(476, 279);
            textPassword.Name = "textPassword";
            textPassword.Size = new Size(167, 31);
            textPassword.TabIndex = 2;
            textPassword.UseSystemPasswordChar = true;
            textPassword.TextChanged += textBox2_TextChanged;
            // 
            // loginButton
            // 
            loginButton.Location = new Point(476, 326);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(167, 45);
            loginButton.TabIndex = 4;
            loginButton.Text = "login";
            loginButton.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(509, 140);
            label3.Name = "label3";
            label3.Size = new Size(97, 38);
            label3.TabIndex = 5;
            label3.Text = "LOGIN";
            // 
            // checkHide
            // 
            checkHide.AutoSize = true;
            checkHide.Location = new Point(649, 281);
            checkHide.Name = "checkHide";
            checkHide.Size = new Size(82, 29);
            checkHide.TabIndex = 6;
            checkHide.Text = "Show";
            checkHide.UseVisualStyleBackColor = true;
            checkHide.CheckedChanged += checkHide_CheckedChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1141, 548);
            Controls.Add(checkHide);
            Controls.Add(label3);
            Controls.Add(loginButton);
            Controls.Add(label2);
            Controls.Add(textPassword);
            Controls.Add(label1);
            Controls.Add(textUsername);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textUsername;
        private Label label1;
        private Label label2;
        private TextBox textPassword;
        private Button loginButton;
        private Label label3;
        private CheckBox checkHide;
    }
}

namespace Agromart
{
    partial class formRegister
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
            label1 = new Label();
            label2 = new Label();
            textUser = new TextBox();
            textPass = new TextBox();
            label3 = new Label();
            textTelepon = new TextBox();
            label4 = new Label();
            btnRegister = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 20);
            label1.Name = "label1";
            label1.Size = new Size(109, 32);
            label1.TabIndex = 0;
            label1.Text = "Register!";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 72);
            label2.Name = "label2";
            label2.Size = new Size(91, 25);
            label2.TabIndex = 1;
            label2.Text = "Username";
            // 
            // textUser
            // 
            textUser.Location = new Point(12, 100);
            textUser.Name = "textUser";
            textUser.Size = new Size(150, 31);
            textUser.TabIndex = 2;
            textUser.TextChanged += textUser_TextChanged;
            // 
            // textPass
            // 
            textPass.Location = new Point(12, 163);
            textPass.Name = "textPass";
            textPass.Size = new Size(150, 31);
            textPass.TabIndex = 4;
            textPass.TextChanged += textPass_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 135);
            label3.Name = "label3";
            label3.Size = new Size(87, 25);
            label3.TabIndex = 3;
            label3.Text = "Password";
            label3.Click += label3_Click;
            // 
            // textTelepon
            // 
            textTelepon.Location = new Point(12, 225);
            textTelepon.Name = "textTelepon";
            textTelepon.Size = new Size(150, 31);
            textTelepon.TabIndex = 6;
            textTelepon.TextChanged += textTelepon_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 197);
            label4.Name = "label4";
            label4.Size = new Size(131, 25);
            label4.TabIndex = 5;
            label4.Text = "nomor telepon";
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(12, 276);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(112, 34);
            btnRegister.TabIndex = 7;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // formRegister
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(910, 383);
            Controls.Add(btnRegister);
            Controls.Add(textTelepon);
            Controls.Add(label4);
            Controls.Add(textPass);
            Controls.Add(label3);
            Controls.Add(textUser);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "formRegister";
            Text = "Register";
            Load += Register_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textUser;
        private TextBox textPass;
        private Label label3;
        private TextBox textTelepon;
        private Label label4;
        private Button btnRegister;
    }
}
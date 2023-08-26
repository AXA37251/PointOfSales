using LogicLayer;

namespace PointOfSales
{
    partial class Login
    {
        private System.ComponentModel.IContainer components = null;
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
            label1 = new Label();
            label2 = new Label();
            Input_user = new TextBox();
            Input_password = new TextBox();
            Btn_login = new Button();
            Btn_register = new Button();
            Btn_exit = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 14);
            label1.Name = "label1";
            label1.Size = new Size(30, 15);
            label1.TabIndex = 0;
            label1.Text = "User";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 46);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 1;
            label2.Text = "Password";
            // 
            // Input_user
            // 
            Input_user.Location = new Point(92, 11);
            Input_user.Name = "Input_user";
            Input_user.Size = new Size(237, 23);
            Input_user.TabIndex = 2;
            // 
            // Input_password
            // 
            Input_password.Location = new Point(92, 43);
            Input_password.Name = "Input_password";
            Input_password.Size = new Size(237, 23);
            Input_password.TabIndex = 3;
            Input_password.UseSystemPasswordChar = true;
            // 
            // Btn_login
            // 
            Btn_login.Location = new Point(92, 72);
            Btn_login.Name = "Btn_login";
            Btn_login.Size = new Size(75, 23);
            Btn_login.TabIndex = 4;
            Btn_login.Text = "Login";
            Btn_login.UseVisualStyleBackColor = true;
            Btn_login.Click += Btn_login_Click;
            // 
            // Btn_register
            // 
            Btn_register.Location = new Point(173, 72);
            Btn_register.Name = "Btn_register";
            Btn_register.Size = new Size(75, 23);
            Btn_register.TabIndex = 5;
            Btn_register.Text = "Register";
            Btn_register.UseVisualStyleBackColor = true;
            // 
            // Btn_exit
            // 
            Btn_exit.Location = new Point(254, 72);
            Btn_exit.Name = "Btn_exit";
            Btn_exit.Size = new Size(75, 23);
            Btn_exit.TabIndex = 6;
            Btn_exit.Text = "Exit";
            Btn_exit.UseVisualStyleBackColor = true;
            Btn_exit.Click += Btn_exit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(346, 108);
            Controls.Add(Btn_exit);
            Controls.Add(Btn_register);
            Controls.Add(Btn_login);
            Controls.Add(Input_password);
            Controls.Add(Input_user);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox Input_user;
        private TextBox Input_password;
        private Button Btn_login;
        private Button Btn_register;
        private Button Btn_exit;
    }
}
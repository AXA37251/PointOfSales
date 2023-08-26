namespace PointOfSales
{
    partial class UserAdd
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
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            Input_User = new TextBox();
            Input_Password = new TextBox();
            Input_Name = new TextBox();
            Input_LastName = new TextBox();
            Input_DocNum = new TextBox();
            label6 = new Label();
            Input_Phone = new TextBox();
            Btn_AddUser = new Button();
            Btn_Back = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(9, 20);
            label1.Name = "label1";
            label1.Size = new Size(30, 15);
            label1.TabIndex = 0;
            label1.Text = "User";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(9, 49);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 1;
            label2.Text = "Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(9, 78);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 2;
            label3.Text = "Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(9, 107);
            label4.Name = "label4";
            label4.Size = new Size(60, 15);
            label4.TabIndex = 3;
            label4.Text = "LastName";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(9, 136);
            label5.Name = "label5";
            label5.Size = new Size(63, 15);
            label5.TabIndex = 4;
            label5.Text = "Document";
            // 
            // Input_User
            // 
            Input_User.Location = new Point(75, 12);
            Input_User.Name = "Input_User";
            Input_User.Size = new Size(164, 23);
            Input_User.TabIndex = 5;
            // 
            // Input_Password
            // 
            Input_Password.Location = new Point(75, 41);
            Input_Password.Name = "Input_Password";
            Input_Password.Size = new Size(164, 23);
            Input_Password.TabIndex = 6;
            // 
            // Input_Name
            // 
            Input_Name.Location = new Point(75, 70);
            Input_Name.Name = "Input_Name";
            Input_Name.Size = new Size(164, 23);
            Input_Name.TabIndex = 7;
            // 
            // Input_LastName
            // 
            Input_LastName.Location = new Point(75, 99);
            Input_LastName.Name = "Input_LastName";
            Input_LastName.Size = new Size(164, 23);
            Input_LastName.TabIndex = 8;
            // 
            // Input_DocNum
            // 
            Input_DocNum.Location = new Point(75, 128);
            Input_DocNum.Name = "Input_DocNum";
            Input_DocNum.Size = new Size(164, 23);
            Input_DocNum.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(9, 165);
            label6.Name = "label6";
            label6.Size = new Size(41, 15);
            label6.TabIndex = 10;
            label6.Text = "Phone";
            // 
            // Input_Phone
            // 
            Input_Phone.Location = new Point(75, 157);
            Input_Phone.Name = "Input_Phone";
            Input_Phone.Size = new Size(164, 23);
            Input_Phone.TabIndex = 11;
            // 
            // Btn_AddUser
            // 
            Btn_AddUser.Location = new Point(75, 195);
            Btn_AddUser.Name = "Btn_AddUser";
            Btn_AddUser.Size = new Size(75, 23);
            Btn_AddUser.TabIndex = 12;
            Btn_AddUser.Text = "Add";
            Btn_AddUser.UseVisualStyleBackColor = true;
            Btn_AddUser.Click += Btn_AddUser_Click;
            // 
            // Btn_Back
            // 
            Btn_Back.Location = new Point(164, 195);
            Btn_Back.Name = "Btn_Back";
            Btn_Back.Size = new Size(75, 23);
            Btn_Back.TabIndex = 13;
            Btn_Back.Text = "Back";
            Btn_Back.UseVisualStyleBackColor = true;
            Btn_Back.Click += Btn_Back_Click;
            // 
            // UserAdd
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(255, 232);
            Controls.Add(Btn_Back);
            Controls.Add(Btn_AddUser);
            Controls.Add(Input_Phone);
            Controls.Add(label6);
            Controls.Add(Input_DocNum);
            Controls.Add(Input_LastName);
            Controls.Add(Input_Name);
            Controls.Add(Input_Password);
            Controls.Add(Input_User);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "UserAdd";
            Text = "AddUser";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox Input_User;
        private TextBox Input_Password;
        private TextBox Input_Name;
        private TextBox Input_LastName;
        private TextBox Input_DocNum;
        private Label label6;
        private TextBox Input_Phone;
        private Button Btn_AddUser;
        private Button Btn_Back;
    }
}
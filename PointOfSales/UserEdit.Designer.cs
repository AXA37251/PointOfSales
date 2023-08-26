namespace PointOfSales
{
    partial class UserEdit
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
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            Btn_Edit = new Button();
            Btn_Close = new Button();
            DGV_EditUsers = new DataGridView();
            Input_Name = new TextBox();
            Input_LastName = new TextBox();
            Input_Document = new TextBox();
            Input_Phone = new TextBox();
            label2 = new Label();
            label1 = new Label();
            Input_Password = new TextBox();
            Input_User = new TextBox();
            ((System.ComponentModel.ISupportInitialize)DGV_EditUsers).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(174, 274);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 2;
            label3.Text = "Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(174, 320);
            label4.Name = "label4";
            label4.Size = new Size(60, 15);
            label4.TabIndex = 3;
            label4.Text = "LastName";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(338, 274);
            label5.Name = "label5";
            label5.Size = new Size(63, 15);
            label5.TabIndex = 4;
            label5.Text = "Document";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(338, 320);
            label6.Name = "label6";
            label6.Size = new Size(41, 15);
            label6.TabIndex = 5;
            label6.Text = "Phone";
            // 
            // Btn_Edit
            // 
            Btn_Edit.Location = new Point(597, 293);
            Btn_Edit.Name = "Btn_Edit";
            Btn_Edit.Size = new Size(75, 23);
            Btn_Edit.TabIndex = 6;
            Btn_Edit.Text = "Edit";
            Btn_Edit.TextAlign = ContentAlignment.BottomCenter;
            Btn_Edit.UseVisualStyleBackColor = true;
            Btn_Edit.Click += Btn_Edit_Click;
            // 
            // Btn_Close
            // 
            Btn_Close.Location = new Point(678, 293);
            Btn_Close.Name = "Btn_Close";
            Btn_Close.Size = new Size(75, 23);
            Btn_Close.TabIndex = 7;
            Btn_Close.Text = "Close";
            Btn_Close.UseVisualStyleBackColor = true;
            Btn_Close.Click += Btn_Close_Click;
            // 
            // DGV_EditUsers
            // 
            DGV_EditUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGV_EditUsers.Location = new Point(12, 12);
            DGV_EditUsers.Name = "DGV_EditUsers";
            DGV_EditUsers.RowTemplate.Height = 25;
            DGV_EditUsers.Size = new Size(741, 256);
            DGV_EditUsers.TabIndex = 8;
            DGV_EditUsers.CellClick += DGV_EditUsers_CellContentClick;
            DGV_EditUsers.CellContentClick += DGV_EditUsers_CellContentClick;
            // 
            // Input_Name
            // 
            Input_Name.Location = new Point(174, 294);
            Input_Name.Name = "Input_Name";
            Input_Name.Size = new Size(158, 23);
            Input_Name.TabIndex = 11;
            // 
            // Input_LastName
            // 
            Input_LastName.Location = new Point(174, 338);
            Input_LastName.Name = "Input_LastName";
            Input_LastName.Size = new Size(156, 23);
            Input_LastName.TabIndex = 12;
            // 
            // Input_Document
            // 
            Input_Document.Location = new Point(338, 294);
            Input_Document.Name = "Input_Document";
            Input_Document.Size = new Size(156, 23);
            Input_Document.TabIndex = 13;
            // 
            // Input_Phone
            // 
            Input_Phone.Location = new Point(338, 338);
            Input_Phone.Name = "Input_Phone";
            Input_Phone.Size = new Size(156, 23);
            Input_Phone.TabIndex = 14;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 322);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 1;
            label2.Text = "Password";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 276);
            label1.Name = "label1";
            label1.Size = new Size(30, 15);
            label1.TabIndex = 0;
            label1.Text = "User";
            // 
            // Input_Password
            // 
            Input_Password.Location = new Point(12, 338);
            Input_Password.Name = "Input_Password";
            Input_Password.Size = new Size(156, 23);
            Input_Password.TabIndex = 10;
            // 
            // Input_User
            // 
            Input_User.Location = new Point(12, 294);
            Input_User.Name = "Input_User";
            Input_User.ReadOnly = true;
            Input_User.Size = new Size(156, 23);
            Input_User.TabIndex = 9;
            // 
            // UserEdit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(765, 378);
            Controls.Add(Input_User);
            Controls.Add(Input_Password);
            Controls.Add(label1);
            Controls.Add(Input_Phone);
            Controls.Add(label2);
            Controls.Add(Input_Document);
            Controls.Add(Input_LastName);
            Controls.Add(Input_Name);
            Controls.Add(DGV_EditUsers);
            Controls.Add(Btn_Close);
            Controls.Add(Btn_Edit);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Name = "UserEdit";
            Text = "Edit Users";
            ((System.ComponentModel.ISupportInitialize)DGV_EditUsers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button Btn_Edit;
        private Button Btn_Close;
        private DataGridView DGV_EditUsers;
        private TextBox Input_Name;
        private TextBox Input_LastName;
        private TextBox Input_Document;
        private TextBox Input_Phone;
        private Label label2;
        private Label label1;
        private TextBox Input_Password;
        private TextBox Input_User;
    }
}
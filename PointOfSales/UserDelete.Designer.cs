namespace PointOfSales
{
    partial class UserDelete
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
            DGV_DeleteUsers = new DataGridView();
            Btn_Delete = new Button();
            Btn_Close = new Button();
            label2 = new Label();
            Input_DeleteDocument = new TextBox();
            ((System.ComponentModel.ISupportInitialize)DGV_DeleteUsers).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(35, 15);
            label1.TabIndex = 0;
            label1.Text = "Users";
            // 
            // DGV_DeleteUsers
            // 
            DGV_DeleteUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGV_DeleteUsers.Location = new Point(12, 27);
            DGV_DeleteUsers.Name = "DGV_DeleteUsers";
            DGV_DeleteUsers.RowTemplate.Height = 25;
            DGV_DeleteUsers.Size = new Size(421, 309);
            DGV_DeleteUsers.TabIndex = 2;
            // 
            // Btn_Delete
            // 
            Btn_Delete.Location = new Point(262, 382);
            Btn_Delete.Name = "Btn_Delete";
            Btn_Delete.Size = new Size(75, 23);
            Btn_Delete.TabIndex = 3;
            Btn_Delete.Text = "Delete";
            Btn_Delete.UseVisualStyleBackColor = true;
            Btn_Delete.Click += Btn_Delete_Click;
            // 
            // Btn_Close
            // 
            Btn_Close.Location = new Point(358, 382);
            Btn_Close.Name = "Btn_Close";
            Btn_Close.Size = new Size(75, 23);
            Btn_Close.TabIndex = 4;
            Btn_Close.Text = "Close";
            Btn_Close.UseVisualStyleBackColor = true;
            Btn_Close.Click += Btn_Close_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(113, 356);
            label2.Name = "label2";
            label2.Size = new Size(143, 15);
            label2.TabIndex = 5;
            label2.Text = "Delete user by Document:";
            // 
            // Input_DeleteDocument
            // 
            Input_DeleteDocument.Location = new Point(262, 353);
            Input_DeleteDocument.Name = "Input_DeleteDocument";
            Input_DeleteDocument.Size = new Size(171, 23);
            Input_DeleteDocument.TabIndex = 6;
            // 
            // UserDelete
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(445, 414);
            Controls.Add(Input_DeleteDocument);
            Controls.Add(label2);
            Controls.Add(Btn_Close);
            Controls.Add(Btn_Delete);
            Controls.Add(DGV_DeleteUsers);
            Controls.Add(label1);
            Name = "UserDelete";
            Text = "Delete User";
            ((System.ComponentModel.ISupportInitialize)DGV_DeleteUsers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView DGV_DeleteUsers;
        private Button Btn_Delete;
        private Button Btn_Close;
        private Label label2;
        private TextBox Input_DeleteDocument;
    }
}
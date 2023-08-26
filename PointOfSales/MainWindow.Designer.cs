namespace PointOfSales
{
    partial class MainWindow
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
            Btn_exit = new Button();
            menuStrip1 = new MenuStrip();
            Strip_File = new ToolStripMenuItem();
            File_EnterInvoice = new ToolStripMenuItem();
            Strip_Users = new ToolStripMenuItem();
            Users_Add = new ToolStripMenuItem();
            Users_Edit = new ToolStripMenuItem();
            deleteToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // Btn_exit
            // 
            Btn_exit.Location = new Point(713, 415);
            Btn_exit.Name = "Btn_exit";
            Btn_exit.Size = new Size(75, 23);
            Btn_exit.TabIndex = 0;
            Btn_exit.Text = "Exit";
            Btn_exit.UseVisualStyleBackColor = true;
            Btn_exit.Click += Btn_exit_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { Strip_File, Strip_Users });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // Strip_File
            // 
            Strip_File.DropDownItems.AddRange(new ToolStripItem[] { File_EnterInvoice });
            Strip_File.Name = "Strip_File";
            Strip_File.Size = new Size(37, 20);
            Strip_File.Text = "File";
            // 
            // File_EnterInvoice
            // 
            File_EnterInvoice.Name = "File_EnterInvoice";
            File_EnterInvoice.Size = new Size(142, 22);
            File_EnterInvoice.Text = "Enter Invoice";
            // 
            // Strip_Users
            // 
            Strip_Users.DropDownItems.AddRange(new ToolStripItem[] { Users_Add, Users_Edit, deleteToolStripMenuItem });
            Strip_Users.Name = "Strip_Users";
            Strip_Users.Size = new Size(47, 20);
            Strip_Users.Text = "Users";
            // 
            // Users_Add
            // 
            Users_Add.Name = "Users_Add";
            Users_Add.Size = new Size(180, 22);
            Users_Add.Text = "Add";
            Users_Add.Click += Users_Add_Click;
            // 
            // Users_Edit
            // 
            Users_Edit.Name = "Users_Edit";
            Users_Edit.Size = new Size(180, 22);
            Users_Edit.Text = "Edit";
            Users_Edit.Click += Users_Edit_Click;
            // 
            // deleteToolStripMenuItem
            // 
            deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            deleteToolStripMenuItem.Size = new Size(180, 22);
            deleteToolStripMenuItem.Text = "Delete ";
            deleteToolStripMenuItem.Click += deleteToolStripMenuItem_Click;
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Btn_exit);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "MainWindow";
            Text = "MainWindow";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Btn_exit;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem Strip_File;
        private ToolStripMenuItem File_EnterInvoice;
        private ToolStripMenuItem Strip_Users;
        private ToolStripMenuItem Users_Add;
        private ToolStripMenuItem Users_Edit;
        private ToolStripMenuItem deleteToolStripMenuItem;
    }
}
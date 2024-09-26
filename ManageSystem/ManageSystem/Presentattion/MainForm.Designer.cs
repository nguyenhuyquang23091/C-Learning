namespace ManageSystem
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.sidebarcontainer = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            this.mySqlDataAdapter1 = new MySql.Data.MySqlClient.MySqlDataAdapter();
            this.mySqlCommand2 = new MySql.Data.MySqlClient.MySqlCommand();
            this.mySqlCommand3 = new MySql.Data.MySqlClient.MySqlCommand();
            this.mySqlCommand4 = new MySql.Data.MySqlClient.MySqlCommand();
            this.PanelContainer = new System.Windows.Forms.Panel();
            this.logout = new System.Windows.Forms.Button();
            this.edit = new System.Windows.Forms.Button();
            this.viewgroup = new System.Windows.Forms.Button();
            this.viewall = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.sidebaricon = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.sidebarcontainer.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sidebaricon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // sidebarcontainer
            // 
            this.sidebarcontainer.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.sidebarcontainer.Controls.Add(this.panel2);
            this.sidebarcontainer.Controls.Add(this.logout);
            this.sidebarcontainer.Controls.Add(this.edit);
            this.sidebarcontainer.Controls.Add(this.viewgroup);
            this.sidebarcontainer.Controls.Add(this.viewall);
            this.sidebarcontainer.Controls.Add(this.Add);
            this.sidebarcontainer.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebarcontainer.Location = new System.Drawing.Point(0, 37);
            this.sidebarcontainer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sidebarcontainer.MaximumSize = new System.Drawing.Size(200, 746);
            this.sidebarcontainer.MinimumSize = new System.Drawing.Size(55, 681);
            this.sidebarcontainer.Name = "sidebarcontainer";
            this.sidebarcontainer.Size = new System.Drawing.Size(200, 709);
            this.sidebarcontainer.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1280, 37);
            this.panel1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1247, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "X";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(254, 21);
            this.label3.TabIndex = 1;
            this.label3.Text = "Education Centre System || Home";
            // 
            // mySqlCommand1
            // 
            this.mySqlCommand1.CacheAge = 0;
            this.mySqlCommand1.Connection = null;
            this.mySqlCommand1.EnableCaching = false;
            this.mySqlCommand1.Transaction = null;
            // 
            // mySqlDataAdapter1
            // 
            this.mySqlDataAdapter1.DeleteCommand = null;
            this.mySqlDataAdapter1.InsertCommand = null;
            this.mySqlDataAdapter1.SelectCommand = null;
            this.mySqlDataAdapter1.UpdateCommand = null;
            // 
            // mySqlCommand2
            // 
            this.mySqlCommand2.CacheAge = 0;
            this.mySqlCommand2.Connection = null;
            this.mySqlCommand2.EnableCaching = false;
            this.mySqlCommand2.Transaction = null;
            // 
            // mySqlCommand3
            // 
            this.mySqlCommand3.CacheAge = 0;
            this.mySqlCommand3.Connection = null;
            this.mySqlCommand3.EnableCaching = false;
            this.mySqlCommand3.Transaction = null;
            // 
            // mySqlCommand4
            // 
            this.mySqlCommand4.CacheAge = 0;
            this.mySqlCommand4.Connection = null;
            this.mySqlCommand4.EnableCaching = false;
            this.mySqlCommand4.Transaction = null;
            // 
            // PanelContainer
            // 
            this.PanelContainer.Location = new System.Drawing.Point(200, 41);
            this.PanelContainer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PanelContainer.Name = "PanelContainer";
            this.PanelContainer.Size = new System.Drawing.Size(1080, 704);
            this.PanelContainer.TabIndex = 4;
            this.PanelContainer.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelContainer_Paint);
            // 
            // logout
            // 
            this.logout.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.logout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logout.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight;
            this.logout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logout.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logout.ForeColor = System.Drawing.Color.Black;
            this.logout.Image = global::ManageSystem.Properties.Resources.Aniket_Suvarna_Box_Regular_Bx_log_out_24;
            this.logout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.logout.Location = new System.Drawing.Point(7, 453);
            this.logout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(148, 47);
            this.logout.TabIndex = 8;
            this.logout.Text = "   Log Out";
            this.logout.UseVisualStyleBackColor = false;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // edit
            // 
            this.edit.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.edit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.edit.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight;
            this.edit.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight;
            this.edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.edit.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edit.ForeColor = System.Drawing.Color.Black;
            this.edit.Image = global::ManageSystem.Properties.Resources.Arturo_Wibawa_Akar_Edit_24;
            this.edit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.edit.Location = new System.Drawing.Point(7, 367);
            this.edit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(185, 50);
            this.edit.TabIndex = 6;
            this.edit.Text = "   Edit data";
            this.edit.UseVisualStyleBackColor = false;
            this.edit.Click += new System.EventHandler(this.edit_Click);
            // 
            // viewgroup
            // 
            this.viewgroup.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.viewgroup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.viewgroup.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight;
            this.viewgroup.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight;
            this.viewgroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewgroup.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewgroup.ForeColor = System.Drawing.Color.Black;
            this.viewgroup.Image = global::ManageSystem.Properties.Resources.Picol_Picol_View_24;
            this.viewgroup.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.viewgroup.Location = new System.Drawing.Point(7, 286);
            this.viewgroup.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.viewgroup.Name = "viewgroup";
            this.viewgroup.Size = new System.Drawing.Size(185, 50);
            this.viewgroup.TabIndex = 5;
            this.viewgroup.Text = "      View by role";
            this.viewgroup.UseVisualStyleBackColor = false;
            this.viewgroup.Click += new System.EventHandler(this.viewgroup_Click);
            // 
            // viewall
            // 
            this.viewall.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.viewall.Cursor = System.Windows.Forms.Cursors.Hand;
            this.viewall.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight;
            this.viewall.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight;
            this.viewall.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewall.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewall.ForeColor = System.Drawing.Color.Black;
            this.viewall.Image = global::ManageSystem.Properties.Resources.Picol_Picol_View_24;
            this.viewall.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.viewall.Location = new System.Drawing.Point(7, 209);
            this.viewall.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.viewall.Name = "viewall";
            this.viewall.Size = new System.Drawing.Size(185, 53);
            this.viewall.TabIndex = 4;
            this.viewall.Text = "    View all ";
            this.viewall.UseVisualStyleBackColor = false;
            this.viewall.Click += new System.EventHandler(this.viewall_Click);
            // 
            // Add
            // 
            this.Add.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Add.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight;
            this.Add.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight;
            this.Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Add.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add.ForeColor = System.Drawing.Color.Black;
            this.Add.Image = global::ManageSystem.Properties.Resources.Iconsmind_Outline_Add_User_24;
            this.Add.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Add.Location = new System.Drawing.Point(7, 139);
            this.Add.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(185, 50);
            this.Add.TabIndex = 2;
            this.Add.Text = "       Add new data";
            this.Add.UseVisualStyleBackColor = false;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.sidebaricon);
            this.panel2.Location = new System.Drawing.Point(7, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(185, 100);
            this.panel2.TabIndex = 9;
            // 
            // sidebaricon
            // 
            this.sidebaricon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sidebaricon.Image = global::ManageSystem.Properties.Resources.Amitjakhu_Drip_Menu_24;
            this.sidebaricon.Location = new System.Drawing.Point(6, 3);
            this.sidebaricon.Name = "sidebaricon";
            this.sidebaricon.Size = new System.Drawing.Size(25, 26);
            this.sidebaricon.TabIndex = 0;
            this.sidebaricon.TabStop = false;
            this.sidebaricon.Click += new System.EventHandler(this.sidebaricon_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ManageSystem.Properties.Resources.Iconarchive_Essential_Buildings_School_512;
            this.pictureBox2.Location = new System.Drawing.Point(37, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(135, 97);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // timer2
            // 
            this.timer2.Interval = 10;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 746);
            this.Controls.Add(this.PanelContainer);
            this.Controls.Add(this.sidebarcontainer);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.sidebarcontainer.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sidebaricon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel sidebarcontainer;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button edit;
        private System.Windows.Forms.Button viewgroup;
        private System.Windows.Forms.Button viewall;
        private System.Windows.Forms.Button logout;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        private MySql.Data.MySqlClient.MySqlDataAdapter mySqlDataAdapter1;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand2;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand3;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel PanelContainer;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox sidebaricon;
        private System.Windows.Forms.Timer timer2;
    }
}
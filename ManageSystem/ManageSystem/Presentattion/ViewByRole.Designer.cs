namespace ManageSystem.Presentattion
{
    partial class ViewByRole
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.selectedrolebox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.check = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.roledata1 = new System.Windows.Forms.DataGridView();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roledata1)).BeginInit();
            this.SuspendLayout();
            // 
            // selectedrolebox
            // 
            this.selectedrolebox.FormattingEnabled = true;
            this.selectedrolebox.Items.AddRange(new object[] {
            "Teaching Staff",
            "Administration",
            "Student"});
            this.selectedrolebox.Location = new System.Drawing.Point(31, 14);
            this.selectedrolebox.Name = "selectedrolebox";
            this.selectedrolebox.Size = new System.Drawing.Size(132, 24);
            this.selectedrolebox.TabIndex = 0;
            this.selectedrolebox.SelectedIndexChanged += new System.EventHandler(this.selectedrolebox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(93, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 2;
            // 
            // check
            // 
            this.check.BackColor = System.Drawing.Color.Teal;
            this.check.Cursor = System.Windows.Forms.Cursors.Hand;
            this.check.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight;
            this.check.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.check.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.check.Location = new System.Drawing.Point(188, 7);
            this.check.Name = "check";
            this.check.Size = new System.Drawing.Size(91, 34);
            this.check.TabIndex = 18;
            this.check.Text = "Check";
            this.check.UseVisualStyleBackColor = false;
            this.check.Click += new System.EventHandler(this.check_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel2.Controls.Add(this.roledata1);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.selectedrolebox);
            this.panel2.Controls.Add(this.check);
            this.panel2.Location = new System.Drawing.Point(41, 41);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(850, 366);
            this.panel2.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 22);
            this.label3.TabIndex = 19;
            this.label3.Text = "label3";
            this.label3.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(245, 35);
            this.label2.TabIndex = 20;
            this.label2.Text = "View User By Roles:";
            // 
            // roledata1
            // 
            this.roledata1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.roledata1.Location = new System.Drawing.Point(46, 90);
            this.roledata1.Name = "roledata1";
            this.roledata1.RowHeadersWidth = 51;
            this.roledata1.RowTemplate.Height = 24;
            this.roledata1.Size = new System.Drawing.Size(760, 251);
            this.roledata1.TabIndex = 20;
            this.roledata1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.roledata1_CellContentClick);
            // 
            // ViewByRole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Name = "ViewByRole";
            this.Size = new System.Drawing.Size(933, 437);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roledata1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox selectedrolebox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button check;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView roledata1;
    }
}

namespace ManageSystem.Presentattion
{
    partial class EditAdministration
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtAdminsalary = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Deleteadmin = new System.Windows.Forms.Button();
            this.txtAdminworktype = new System.Windows.Forms.ComboBox();
            this.txtworkinghours = new System.Windows.Forms.TextBox();
            this.UpdateClick = new System.Windows.Forms.Button();
            this.txtAdminEmail = new System.Windows.Forms.TextBox();
            this.txtAdmintelephone = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAdminName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.datagridadmin = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.datagridadmin)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtAdminsalary
            // 
            this.txtAdminsalary.Location = new System.Drawing.Point(481, 129);
            this.txtAdminsalary.Multiline = true;
            this.txtAdminsalary.Name = "txtAdminsalary";
            this.txtAdminsalary.Size = new System.Drawing.Size(160, 28);
            this.txtAdminsalary.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(333, 136);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 21);
            this.label7.TabIndex = 20;
            this.label7.Text = "Salary:";
            // 
            // Deleteadmin
            // 
            this.Deleteadmin.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Deleteadmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Deleteadmin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.Deleteadmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Deleteadmin.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Deleteadmin.Location = new System.Drawing.Point(450, 213);
            this.Deleteadmin.Name = "Deleteadmin";
            this.Deleteadmin.Size = new System.Drawing.Size(91, 44);
            this.Deleteadmin.TabIndex = 19;
            this.Deleteadmin.Text = "Delete";
            this.Deleteadmin.UseVisualStyleBackColor = false;
            this.Deleteadmin.Click += new System.EventHandler(this.Deleteadmin_Click);
            // 
            // txtAdminworktype
            // 
            this.txtAdminworktype.FormattingEnabled = true;
            this.txtAdminworktype.Items.AddRange(new object[] {
            "FullTime",
            "PartTime"});
            this.txtAdminworktype.Location = new System.Drawing.Point(481, 31);
            this.txtAdminworktype.Name = "txtAdminworktype";
            this.txtAdminworktype.Size = new System.Drawing.Size(160, 24);
            this.txtAdminworktype.TabIndex = 16;
            // 
            // txtworkinghours
            // 
            this.txtworkinghours.Location = new System.Drawing.Point(481, 72);
            this.txtworkinghours.Multiline = true;
            this.txtworkinghours.Name = "txtworkinghours";
            this.txtworkinghours.Size = new System.Drawing.Size(160, 28);
            this.txtworkinghours.TabIndex = 15;
            // 
            // UpdateClick
            // 
            this.UpdateClick.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.UpdateClick.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UpdateClick.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight;
            this.UpdateClick.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateClick.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateClick.Location = new System.Drawing.Point(230, 213);
            this.UpdateClick.Name = "UpdateClick";
            this.UpdateClick.Size = new System.Drawing.Size(91, 44);
            this.UpdateClick.TabIndex = 18;
            this.UpdateClick.Text = "Update";
            this.UpdateClick.UseVisualStyleBackColor = false;
            this.UpdateClick.Click += new System.EventHandler(this.UpdateClick_Click);
            // 
            // txtAdminEmail
            // 
            this.txtAdminEmail.Location = new System.Drawing.Point(100, 136);
            this.txtAdminEmail.Multiline = true;
            this.txtAdminEmail.Name = "txtAdminEmail";
            this.txtAdminEmail.Size = new System.Drawing.Size(160, 28);
            this.txtAdminEmail.TabIndex = 14;
            // 
            // txtAdmintelephone
            // 
            this.txtAdmintelephone.Location = new System.Drawing.Point(100, 79);
            this.txtAdmintelephone.Multiline = true;
            this.txtAdmintelephone.Name = "txtAdmintelephone";
            this.txtAdmintelephone.Size = new System.Drawing.Size(160, 28);
            this.txtAdmintelephone.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(333, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 21);
            this.label6.TabIndex = 12;
            this.label6.Text = "Working Hours:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(333, 31);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 21);
            this.label8.TabIndex = 8;
            this.label8.Text = "Work Type:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(9, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 21);
            this.label5.TabIndex = 6;
            this.label5.Text = "Telephone:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 21);
            this.label4.TabIndex = 4;
            this.label4.Text = "Email:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Name:";
            // 
            // txtAdminName
            // 
            this.txtAdminName.Location = new System.Drawing.Point(100, 24);
            this.txtAdminName.Multiline = true;
            this.txtAdminName.Name = "txtAdminName";
            this.txtAdminName.Size = new System.Drawing.Size(160, 28);
            this.txtAdminName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 24);
            this.label2.TabIndex = 0;
            // 
            // datagridadmin
            // 
            this.datagridadmin.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagridadmin.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.datagridadmin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridadmin.Location = new System.Drawing.Point(27, 33);
            this.datagridadmin.Name = "datagridadmin";
            this.datagridadmin.RowHeadersVisible = false;
            this.datagridadmin.RowHeadersWidth = 51;
            this.datagridadmin.RowTemplate.Height = 24;
            this.datagridadmin.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagridadmin.Size = new System.Drawing.Size(767, 245);
            this.datagridadmin.TabIndex = 1;
            this.datagridadmin.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagridadmin_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Administration\'s Data:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.datagridadmin);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(44, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(818, 292);
            this.panel1.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.txtAdminsalary);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.Deleteadmin);
            this.panel2.Controls.Add(this.txtAdminworktype);
            this.panel2.Controls.Add(this.txtworkinghours);
            this.panel2.Controls.Add(this.UpdateClick);
            this.panel2.Controls.Add(this.txtAdminEmail);
            this.panel2.Controls.Add(this.txtAdmintelephone);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtAdminName);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(44, 301);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(818, 292);
            this.panel2.TabIndex = 7;
            // 
            // EditAdministration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "EditAdministration";
            this.Size = new System.Drawing.Size(905, 593);
            ((System.ComponentModel.ISupportInitialize)(this.datagridadmin)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtAdminsalary;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button Deleteadmin;
        private System.Windows.Forms.ComboBox txtAdminworktype;
        private System.Windows.Forms.TextBox txtworkinghours;
        private System.Windows.Forms.Button UpdateClick;
        private System.Windows.Forms.TextBox txtAdminEmail;
        private System.Windows.Forms.TextBox txtAdmintelephone;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAdminName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView datagridadmin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}

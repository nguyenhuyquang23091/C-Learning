namespace ManageSystem
{
    partial class AddStudent
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.studatagrid = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtprevioussubject2 = new System.Windows.Forms.TextBox();
            this.txtprevioussubject1 = new System.Windows.Forms.TextBox();
            this.txtcurrentsubject2 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Clearclick = new System.Windows.Forms.Button();
            this.Addclick = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtcurrentsubject1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtStutelephone = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtStuemail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtStuname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studatagrid)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.studatagrid);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(63, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(818, 292);
            this.panel1.TabIndex = 4;
            // 
            // studatagrid
            // 
            this.studatagrid.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.studatagrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.studatagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studatagrid.Location = new System.Drawing.Point(27, 33);
            this.studatagrid.Name = "studatagrid";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.studatagrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.studatagrid.RowHeadersVisible = false;
            this.studatagrid.RowHeadersWidth = 51;
            this.studatagrid.RowTemplate.Height = 24;
            this.studatagrid.Size = new System.Drawing.Size(767, 245);
            this.studatagrid.TabIndex = 1;
            this.studatagrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.studatagrid_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student\'s Data:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.txtprevioussubject2);
            this.panel2.Controls.Add(this.txtprevioussubject1);
            this.panel2.Controls.Add(this.txtcurrentsubject2);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.Clearclick);
            this.panel2.Controls.Add(this.Addclick);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.txtcurrentsubject1);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txtStutelephone);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txtStuemail);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtStuname);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(63, 338);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(818, 292);
            this.panel2.TabIndex = 5;
            // 
            // txtprevioussubject2
            // 
            this.txtprevioussubject2.Location = new System.Drawing.Point(703, 21);
            this.txtprevioussubject2.Name = "txtprevioussubject2";
            this.txtprevioussubject2.Size = new System.Drawing.Size(100, 22);
            this.txtprevioussubject2.TabIndex = 20;
            // 
            // txtprevioussubject1
            // 
            this.txtprevioussubject1.Location = new System.Drawing.Point(434, 112);
            this.txtprevioussubject1.Name = "txtprevioussubject1";
            this.txtprevioussubject1.Size = new System.Drawing.Size(100, 22);
            this.txtprevioussubject1.TabIndex = 19;
            // 
            // txtcurrentsubject2
            // 
            this.txtcurrentsubject2.Location = new System.Drawing.Point(434, 68);
            this.txtcurrentsubject2.Name = "txtcurrentsubject2";
            this.txtcurrentsubject2.Size = new System.Drawing.Size(100, 22);
            this.txtcurrentsubject2.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(554, 22);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(143, 21);
            this.label10.TabIndex = 17;
            this.label10.Text = "Previous Subject 2:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(292, 112);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(143, 21);
            this.label9.TabIndex = 16;
            this.label9.Text = "Previous Subject 1:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(292, 70);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(136, 21);
            this.label7.TabIndex = 15;
            this.label7.Text = "Current Subject 2:";
            // 
            // Clearclick
            // 
            this.Clearclick.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Clearclick.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight;
            this.Clearclick.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Clearclick.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clearclick.Location = new System.Drawing.Point(422, 225);
            this.Clearclick.Name = "Clearclick";
            this.Clearclick.Size = new System.Drawing.Size(91, 44);
            this.Clearclick.TabIndex = 14;
            this.Clearclick.Text = "Clear";
            this.Clearclick.UseVisualStyleBackColor = false;
            // 
            // Addclick
            // 
            this.Addclick.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Addclick.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight;
            this.Addclick.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Addclick.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Addclick.Location = new System.Drawing.Point(236, 225);
            this.Addclick.Name = "Addclick";
            this.Addclick.Size = new System.Drawing.Size(91, 44);
            this.Addclick.TabIndex = 13;
            this.Addclick.Text = "Add";
            this.Addclick.UseVisualStyleBackColor = false;
            this.Addclick.Click += new System.EventHandler(this.Addclick_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(292, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 21);
            this.label6.TabIndex = 12;
            this.label6.Text = "Current Subject 1:";
            // 
            // txtcurrentsubject1
            // 
            this.txtcurrentsubject1.Location = new System.Drawing.Point(434, 22);
            this.txtcurrentsubject1.Name = "txtcurrentsubject1";
            this.txtcurrentsubject1.Size = new System.Drawing.Size(100, 22);
            this.txtcurrentsubject1.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(9, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 21);
            this.label5.TabIndex = 6;
            this.label5.Text = "Telephone:";
            // 
            // txtStutelephone
            // 
            this.txtStutelephone.Location = new System.Drawing.Point(100, 70);
            this.txtStutelephone.Name = "txtStutelephone";
            this.txtStutelephone.Size = new System.Drawing.Size(100, 22);
            this.txtStutelephone.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 21);
            this.label4.TabIndex = 4;
            this.label4.Text = "Email:";
            // 
            // txtStuemail
            // 
            this.txtStuemail.Location = new System.Drawing.Point(100, 111);
            this.txtStuemail.Name = "txtStuemail";
            this.txtStuemail.Size = new System.Drawing.Size(179, 22);
            this.txtStuemail.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Name:";
            // 
            // txtStuname
            // 
            this.txtStuname.Location = new System.Drawing.Point(100, 25);
            this.txtStuname.Name = "txtStuname";
            this.txtStuname.Size = new System.Drawing.Size(100, 22);
            this.txtStuname.TabIndex = 1;
            this.txtStuname.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
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
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel3.Location = new System.Drawing.Point(15, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(989, 652);
            this.panel3.TabIndex = 6;
            // 
            // AddStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Name = "AddStudent";
            this.Size = new System.Drawing.Size(1020, 671);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studatagrid)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView studatagrid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtcurrentsubject1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtStutelephone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtStuemail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtStuname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Clearclick;
        private System.Windows.Forms.Button Addclick;
        private System.Windows.Forms.TextBox txtprevioussubject1;
        private System.Windows.Forms.TextBox txtcurrentsubject2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtprevioussubject2;
        private System.Windows.Forms.Panel panel3;
    }
}

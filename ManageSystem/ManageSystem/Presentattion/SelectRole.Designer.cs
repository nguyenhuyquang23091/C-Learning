namespace ManageSystem
{
    partial class SelectRole
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
            this.label1 = new System.Windows.Forms.Label();
            this.Teachingstaff = new System.Windows.Forms.RadioButton();
            this.Administration = new System.Windows.Forms.RadioButton();
            this.Student = new System.Windows.Forms.RadioButton();
            this.Next = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select Role:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Teachingstaff
            // 
            this.Teachingstaff.AutoSize = true;
            this.Teachingstaff.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Teachingstaff.Location = new System.Drawing.Point(24, 55);
            this.Teachingstaff.Name = "Teachingstaff";
            this.Teachingstaff.Size = new System.Drawing.Size(114, 20);
            this.Teachingstaff.TabIndex = 1;
            this.Teachingstaff.Text = "Teaching Staff";
            this.Teachingstaff.UseVisualStyleBackColor = true;
            this.Teachingstaff.CheckedChanged += new System.EventHandler(this.Teachingstaff_CheckedChanged);
            // 
            // Administration
            // 
            this.Administration.AutoSize = true;
            this.Administration.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Administration.Location = new System.Drawing.Point(24, 95);
            this.Administration.Name = "Administration";
            this.Administration.Size = new System.Drawing.Size(112, 20);
            this.Administration.TabIndex = 2;
            this.Administration.Text = "Administration";
            this.Administration.UseVisualStyleBackColor = true;
            this.Administration.CheckedChanged += new System.EventHandler(this.Administration_CheckedChanged);
            // 
            // Student
            // 
            this.Student.AutoSize = true;
            this.Student.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Student.Location = new System.Drawing.Point(24, 137);
            this.Student.Name = "Student";
            this.Student.Size = new System.Drawing.Size(73, 20);
            this.Student.TabIndex = 3;
            this.Student.Text = "Student";
            this.Student.UseVisualStyleBackColor = true;
            this.Student.CheckedChanged += new System.EventHandler(this.Student_CheckedChanged);
            // 
            // Next
            // 
            this.Next.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Next.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Next.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Next.ForeColor = System.Drawing.Color.White;
            this.Next.Location = new System.Drawing.Point(294, 137);
            this.Next.Name = "Next";
            this.Next.Size = new System.Drawing.Size(127, 37);
            this.Next.TabIndex = 4;
            this.Next.Text = "Next";
            this.Next.UseVisualStyleBackColor = false;
            this.Next.Click += new System.EventHandler(this.Next_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.Student);
            this.panel1.Controls.Add(this.Next);
            this.panel1.Controls.Add(this.Administration);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Teachingstaff);
            this.panel1.Location = new System.Drawing.Point(33, 45);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(433, 177);
            this.panel1.TabIndex = 5;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(290, 21);
            this.label3.TabIndex = 1;
            this.label3.Text = "Education Centre System || Select Role";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(658, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "X";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(502, 30);
            this.panel2.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(478, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "X";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // SelectRole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(502, 258);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(200, 41);
            this.Name = "SelectRole";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SelectRole";
            this.Load += new System.EventHandler(this.SelectRole_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton Teachingstaff;
        private System.Windows.Forms.RadioButton Administration;
        private System.Windows.Forms.RadioButton Student;
        private System.Windows.Forms.Button Next;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
    }
}
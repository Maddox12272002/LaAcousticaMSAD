﻿namespace LaAcoustica_Final
{
    partial class EmployeeEdit
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
            this.employeeData = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label11 = new System.Windows.Forms.Label();
            this.em = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.accnum = new System.Windows.Forms.TextBox();
            this.at = new System.Windows.Forms.ComboBox();
            this.add = new LaAcoustica_Final.CButton();
            this.label6 = new System.Windows.Forms.Label();
            this.delete = new LaAcoustica_Final.CButton();
            this.edit = new LaAcoustica_Final.CButton();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pass = new System.Windows.Forms.TextBox();
            this.user = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.mi = new System.Windows.Forms.TextBox();
            this.fs = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ls = new System.Windows.Forms.TextBox();
            this.filter_combo = new Guna.UI2.WinForms.Guna2ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.employeeData)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // employeeData
            // 
            this.employeeData.AllowUserToAddRows = false;
            this.employeeData.AllowUserToDeleteRows = false;
            this.employeeData.AllowUserToResizeColumns = false;
            this.employeeData.AllowUserToResizeRows = false;
            this.employeeData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.employeeData.Location = new System.Drawing.Point(456, 80);
            this.employeeData.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.employeeData.MultiSelect = false;
            this.employeeData.Name = "employeeData";
            this.employeeData.ReadOnly = true;
            this.employeeData.RowHeadersWidth = 51;
            this.employeeData.RowTemplate.Height = 24;
            this.employeeData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.employeeData.Size = new System.Drawing.Size(796, 679);
            this.employeeData.TabIndex = 20;
            this.employeeData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SelectRow);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Century Schoolbook", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Maroon;
            this.label9.Location = new System.Drawing.Point(768, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(188, 34);
            this.label9.TabIndex = 23;
            this.label9.Text = "ACCOUNTS";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGray;
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.em);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.accnum);
            this.panel1.Controls.Add(this.at);
            this.panel1.Controls.Add(this.add);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.delete);
            this.panel1.Controls.Add(this.edit);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.pass);
            this.panel1.Controls.Add(this.user);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.mi);
            this.panel1.Controls.Add(this.fs);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.ls);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(443, 785);
            this.panel1.TabIndex = 24;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.EmployeeEdit_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.EmployeeEdit_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.EmployeeEdit_MouseUp);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(388, 535);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(18, 17);
            this.checkBox1.TabIndex = 43;
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Maroon;
            this.label11.Location = new System.Drawing.Point(23, 577);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 23);
            this.label11.TabIndex = 42;
            this.label11.Text = "Email:";
            // 
            // em
            // 
            this.em.Enabled = false;
            this.em.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.em.Location = new System.Drawing.Point(29, 603);
            this.em.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.em.Multiline = true;
            this.em.Name = "em";
            this.em.ReadOnly = true;
            this.em.Size = new System.Drawing.Size(381, 35);
            this.em.TabIndex = 41;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Maroon;
            this.label10.Location = new System.Drawing.Point(27, 62);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(180, 23);
            this.label10.TabIndex = 40;
            this.label10.Text = "Account Number";
            // 
            // accnum
            // 
            this.accnum.Enabled = false;
            this.accnum.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accnum.Location = new System.Drawing.Point(27, 89);
            this.accnum.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.accnum.Multiline = true;
            this.accnum.Name = "accnum";
            this.accnum.ReadOnly = true;
            this.accnum.Size = new System.Drawing.Size(381, 35);
            this.accnum.TabIndex = 39;
            // 
            // at
            // 
            this.at.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.at.Enabled = false;
            this.at.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.at.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.at.FormattingEnabled = true;
            this.at.Items.AddRange(new object[] {
            "Admin",
            "Customer",
            "Main",
            "Employee"});
            this.at.Location = new System.Drawing.Point(32, 383);
            this.at.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.at.Name = "at";
            this.at.Size = new System.Drawing.Size(383, 27);
            this.at.TabIndex = 38;
            // 
            // add
            // 
            this.add.BackColor = System.Drawing.Color.White;
            this.add.BackgroundColor = System.Drawing.Color.White;
            this.add.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.add.BorderRadius = 20;
            this.add.BorderSize = 0;
            this.add.FlatAppearance.BorderSize = 0;
            this.add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add.ForeColor = System.Drawing.Color.DarkRed;
            this.add.Location = new System.Drawing.Point(32, 671);
            this.add.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(112, 62);
            this.add.TabIndex = 37;
            this.add.Text = "Add";
            this.add.TextColor = System.Drawing.Color.DarkRed;
            this.add.UseVisualStyleBackColor = false;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Schoolbook", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Maroon;
            this.label6.Location = new System.Drawing.Point(12, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(284, 27);
            this.label6.TabIndex = 36;
            this.label6.Text = " ACCOUNT MANAGER";
            // 
            // delete
            // 
            this.delete.BackColor = System.Drawing.Color.White;
            this.delete.BackgroundColor = System.Drawing.Color.White;
            this.delete.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.delete.BorderRadius = 20;
            this.delete.BorderSize = 0;
            this.delete.FlatAppearance.BorderSize = 0;
            this.delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete.ForeColor = System.Drawing.Color.DarkRed;
            this.delete.Location = new System.Drawing.Point(286, 671);
            this.delete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(131, 62);
            this.delete.TabIndex = 21;
            this.delete.Text = "Delete";
            this.delete.TextColor = System.Drawing.Color.DarkRed;
            this.delete.UseVisualStyleBackColor = false;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // edit
            // 
            this.edit.BackColor = System.Drawing.Color.White;
            this.edit.BackgroundColor = System.Drawing.Color.White;
            this.edit.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.edit.BorderRadius = 20;
            this.edit.BorderSize = 0;
            this.edit.FlatAppearance.BorderSize = 0;
            this.edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.edit.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edit.ForeColor = System.Drawing.Color.DarkRed;
            this.edit.Location = new System.Drawing.Point(149, 671);
            this.edit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(131, 62);
            this.edit.TabIndex = 22;
            this.edit.Text = "Edit";
            this.edit.TextColor = System.Drawing.Color.DarkRed;
            this.edit.UseVisualStyleBackColor = false;
            this.edit.Click += new System.EventHandler(this.edit_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Maroon;
            this.label8.Location = new System.Drawing.Point(25, 498);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 23);
            this.label8.TabIndex = 33;
            this.label8.Text = "Password:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Maroon;
            this.label7.Location = new System.Drawing.Point(27, 430);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 23);
            this.label7.TabIndex = 32;
            this.label7.Text = "Username:";
            // 
            // pass
            // 
            this.pass.Enabled = false;
            this.pass.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pass.Location = new System.Drawing.Point(29, 526);
            this.pass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pass.Multiline = true;
            this.pass.Name = "pass";
            this.pass.PasswordChar = '*';
            this.pass.ReadOnly = true;
            this.pass.Size = new System.Drawing.Size(381, 35);
            this.pass.TabIndex = 31;
            // 
            // user
            // 
            this.user.Enabled = false;
            this.user.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user.Location = new System.Drawing.Point(29, 455);
            this.user.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.user.Multiline = true;
            this.user.Name = "user";
            this.user.ReadOnly = true;
            this.user.Size = new System.Drawing.Size(381, 35);
            this.user.TabIndex = 30;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(237, 364);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 23);
            this.label5.TabIndex = 29;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Maroon;
            this.label4.Location = new System.Drawing.Point(27, 351);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 23);
            this.label4.TabIndex = 28;
            this.label4.Text = "Account Type";
            // 
            // mi
            // 
            this.mi.Enabled = false;
            this.mi.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mi.Location = new System.Drawing.Point(29, 304);
            this.mi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mi.Multiline = true;
            this.mi.Name = "mi";
            this.mi.ReadOnly = true;
            this.mi.Size = new System.Drawing.Size(381, 35);
            this.mi.TabIndex = 25;
            // 
            // fs
            // 
            this.fs.Enabled = false;
            this.fs.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fs.Location = new System.Drawing.Point(29, 226);
            this.fs.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.fs.Multiline = true;
            this.fs.Name = "fs";
            this.fs.ReadOnly = true;
            this.fs.Size = new System.Drawing.Size(381, 35);
            this.fs.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(25, 278);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 23);
            this.label3.TabIndex = 23;
            this.label3.Text = "Middle Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(25, 201);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 23);
            this.label2.TabIndex = 22;
            this.label2.Text = "First Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(25, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 23);
            this.label1.TabIndex = 21;
            this.label1.Text = "Last Name:";
            // 
            // ls
            // 
            this.ls.Enabled = false;
            this.ls.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ls.Location = new System.Drawing.Point(29, 153);
            this.ls.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ls.Multiline = true;
            this.ls.Name = "ls";
            this.ls.ReadOnly = true;
            this.ls.Size = new System.Drawing.Size(381, 35);
            this.ls.TabIndex = 20;
            // 
            // filter_combo
            // 
            this.filter_combo.BackColor = System.Drawing.Color.Transparent;
            this.filter_combo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.filter_combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.filter_combo.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.filter_combo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.filter_combo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.filter_combo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.filter_combo.ItemHeight = 30;
            this.filter_combo.Items.AddRange(new object[] {
            "Worker",
            "Customer"});
            this.filter_combo.Location = new System.Drawing.Point(1061, 28);
            this.filter_combo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.filter_combo.Name = "filter_combo";
            this.filter_combo.Size = new System.Drawing.Size(188, 36);
            this.filter_combo.TabIndex = 25;
            this.filter_combo.SelectedIndexChanged += new System.EventHandler(this.filter_combo_SelectedIndexChanged);
            // 
            // EmployeeEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1264, 785);
            this.Controls.Add(this.filter_combo);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.employeeData);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "EmployeeEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EmployeeEdit";
            this.Load += new System.EventHandler(this.EmployeeEdit_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.EmployeeEdit_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.EmployeeEdit_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.EmployeeEdit_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.employeeData)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView employeeData;
        private CButton delete;
        private CButton edit;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel1;
        private CButton add;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox pass;
        private System.Windows.Forms.TextBox user;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox mi;
        private System.Windows.Forms.TextBox fs;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ls;
        private System.Windows.Forms.ComboBox at;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox accnum;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox em;
        private System.Windows.Forms.CheckBox checkBox1;
        private Guna.UI2.WinForms.Guna2ComboBox filter_combo;
    }
}
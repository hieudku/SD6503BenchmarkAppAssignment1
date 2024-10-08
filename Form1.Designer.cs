﻿namespace SD6503BenchmarkAppAssignment1
{
    partial class Form1
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
            this.btnLoad = new System.Windows.Forms.Button();
            this.stsStatus = new System.Windows.Forms.StatusStrip();
            this.tslStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.loadAndToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sortAToZToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sortZToAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAndSearchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSortZA = new System.Windows.Forms.Button();
            this.lstStaff = new System.Windows.Forms.ListBox();
            this.btnSortAZ = new System.Windows.Forms.Button();
            this.tbxSearch = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lstSearch = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dateSelect = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tbxSalary = new System.Windows.Forms.TextBox();
            this.tbxEmail = new System.Windows.Forms.TextBox();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.tbxID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.ttpToolTips = new System.Windows.Forms.ToolTip(this.components);
            this.stsStatus.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(22, 694);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(148, 57);
            this.btnLoad.TabIndex = 0;
            this.btnLoad.Text = "Load";
            this.ttpToolTips.SetToolTip(this.btnLoad, "Load a list of existing staff record");
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // stsStatus
            // 
            this.stsStatus.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.stsStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslStatus});
            this.stsStatus.Location = new System.Drawing.Point(0, 910);
            this.stsStatus.Name = "stsStatus";
            this.stsStatus.Padding = new System.Windows.Forms.Padding(2, 0, 14, 0);
            this.stsStatus.Size = new System.Drawing.Size(1886, 32);
            this.stsStatus.TabIndex = 2;
            this.stsStatus.Text = "statusStrip1";
            // 
            // tslStatus
            // 
            this.tslStatus.Name = "tslStatus";
            this.tslStatus.Size = new System.Drawing.Size(60, 25);
            this.tslStatus.Text = "Ready";
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadAndToolStripMenuItem,
            this.saveAndSearchToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(6, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1886, 33);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // loadAndToolStripMenuItem
            // 
            this.loadAndToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadToolStripMenuItem,
            this.sortAToZToolStripMenuItem,
            this.sortZToAToolStripMenuItem});
            this.loadAndToolStripMenuItem.Name = "loadAndToolStripMenuItem";
            this.loadAndToolStripMenuItem.Size = new System.Drawing.Size(140, 29);
            this.loadAndToolStripMenuItem.Text = "Load and Sort";
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(201, 34);
            this.loadToolStripMenuItem.Text = "Load";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // sortAToZToolStripMenuItem
            // 
            this.sortAToZToolStripMenuItem.Name = "sortAToZToolStripMenuItem";
            this.sortAToZToolStripMenuItem.Size = new System.Drawing.Size(201, 34);
            this.sortAToZToolStripMenuItem.Text = "Sort A to Z";
            this.sortAToZToolStripMenuItem.Click += new System.EventHandler(this.btnSortAZ_Click);
            // 
            // sortZToAToolStripMenuItem
            // 
            this.sortZToAToolStripMenuItem.Name = "sortZToAToolStripMenuItem";
            this.sortZToAToolStripMenuItem.Size = new System.Drawing.Size(201, 34);
            this.sortZToAToolStripMenuItem.Text = "Sort Z to A";
            this.sortZToAToolStripMenuItem.Click += new System.EventHandler(this.btnSortZA_Click);
            // 
            // saveAndSearchToolStripMenuItem
            // 
            this.saveAndSearchToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.searchToolStripMenuItem});
            this.saveAndSearchToolStripMenuItem.Name = "saveAndSearchToolStripMenuItem";
            this.saveAndSearchToolStripMenuItem.Size = new System.Drawing.Size(157, 29);
            this.saveAndSearchToolStripMenuItem.Text = "Save and Search";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(166, 34);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(166, 34);
            this.searchToolStripMenuItem.Text = "Search";
            this.searchToolStripMenuItem.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.btnSortZA);
            this.groupBox1.Controls.Add(this.lstStaff);
            this.groupBox1.Controls.Add(this.btnSortAZ);
            this.groupBox1.Controls.Add(this.btnLoad);
            this.groupBox1.Location = new System.Drawing.Point(483, 95);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(670, 774);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Load and Sort";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(407, 42);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(76, 20);
            this.label11.TabIndex = 10;
            this.label11.Text = "Salary ($)";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(294, 42);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 20);
            this.label10.TabIndex = 10;
            this.label10.Text = "Email";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(208, 42);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 20);
            this.label9.TabIndex = 10;
            this.label9.Text = "DoB";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(104, 42);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 20);
            this.label8.TabIndex = 11;
            this.label8.Text = "Name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 42);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 20);
            this.label7.TabIndex = 10;
            this.label7.Text = "ID";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(177, 694);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(148, 57);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Delete Selected";
            this.ttpToolTips.SetToolTip(this.btnDelete, "Remove selected staff from record and list");
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSortZA
            // 
            this.btnSortZA.Location = new System.Drawing.Point(502, 694);
            this.btnSortZA.Name = "btnSortZA";
            this.btnSortZA.Size = new System.Drawing.Size(148, 57);
            this.btnSortZA.TabIndex = 6;
            this.btnSortZA.Text = "Sort Z to A";
            this.ttpToolTips.SetToolTip(this.btnSortZA, "Sort staff by name in ascending order");
            this.btnSortZA.UseVisualStyleBackColor = true;
            this.btnSortZA.Click += new System.EventHandler(this.btnSortZA_Click);
            // 
            // lstStaff
            // 
            this.lstStaff.FormattingEnabled = true;
            this.lstStaff.ItemHeight = 20;
            this.lstStaff.Location = new System.Drawing.Point(22, 85);
            this.lstStaff.Name = "lstStaff";
            this.lstStaff.Size = new System.Drawing.Size(626, 584);
            this.lstStaff.TabIndex = 1;
            // 
            // btnSortAZ
            // 
            this.btnSortAZ.Location = new System.Drawing.Point(348, 694);
            this.btnSortAZ.Name = "btnSortAZ";
            this.btnSortAZ.Size = new System.Drawing.Size(148, 57);
            this.btnSortAZ.TabIndex = 5;
            this.btnSortAZ.Text = "Sort A to Z";
            this.ttpToolTips.SetToolTip(this.btnSortAZ, "Sort staff by name in descending order");
            this.btnSortAZ.UseVisualStyleBackColor = true;
            this.btnSortAZ.Click += new System.EventHandler(this.btnSortAZ_Click);
            // 
            // tbxSearch
            // 
            this.tbxSearch.Location = new System.Drawing.Point(112, 43);
            this.tbxSearch.Name = "tbxSearch";
            this.tbxSearch.Size = new System.Drawing.Size(268, 26);
            this.tbxSearch.TabIndex = 5;
            this.ttpToolTips.SetToolTip(this.tbxSearch, "Enter keyword to search for staff from record");
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSearch);
            this.groupBox2.Controls.Add(this.tbxSearch);
            this.groupBox2.Location = new System.Drawing.Point(1184, 678);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(676, 192);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Search";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(112, 112);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(148, 57);
            this.btnSearch.TabIndex = 16;
            this.btnSearch.Text = "Search";
            this.ttpToolTips.SetToolTip(this.btnSearch, "Search based on keyword entered");
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.button1_Click);
            // 
            // lstSearch
            // 
            this.lstSearch.FormattingEnabled = true;
            this.lstSearch.ItemHeight = 20;
            this.lstSearch.Location = new System.Drawing.Point(22, 42);
            this.lstSearch.Name = "lstSearch";
            this.lstSearch.Size = new System.Drawing.Size(630, 484);
            this.lstSearch.TabIndex = 7;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dateSelect);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.btnSave);
            this.groupBox3.Controls.Add(this.btnAdd);
            this.groupBox3.Controls.Add(this.tbxSalary);
            this.groupBox3.Controls.Add(this.tbxEmail);
            this.groupBox3.Controls.Add(this.tbxName);
            this.groupBox3.Controls.Add(this.tbxID);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(12, 95);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(408, 774);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Add and Edit";
            // 
            // dateSelect
            // 
            this.dateSelect.Location = new System.Drawing.Point(112, 383);
            this.dateSelect.Name = "dateSelect";
            this.dateSelect.Size = new System.Drawing.Size(268, 26);
            this.dateSelect.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(110, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "Enter Staff Details to Add";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(232, 694);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(148, 57);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Save";
            this.ttpToolTips.SetToolTip(this.btnSave, "Save selected staff into text file");
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(26, 694);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(148, 57);
            this.btnAdd.TabIndex = 15;
            this.btnAdd.Text = "Add";
            this.ttpToolTips.SetToolTip(this.btnAdd, "Add to current record list to view (not saved yet)");
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tbxSalary
            // 
            this.tbxSalary.Location = new System.Drawing.Point(112, 572);
            this.tbxSalary.Name = "tbxSalary";
            this.tbxSalary.Size = new System.Drawing.Size(268, 26);
            this.tbxSalary.TabIndex = 14;
            // 
            // tbxEmail
            // 
            this.tbxEmail.Location = new System.Drawing.Point(112, 478);
            this.tbxEmail.Name = "tbxEmail";
            this.tbxEmail.Size = new System.Drawing.Size(268, 26);
            this.tbxEmail.TabIndex = 13;
            // 
            // tbxName
            // 
            this.tbxName.Location = new System.Drawing.Point(112, 280);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(268, 26);
            this.tbxName.TabIndex = 11;
            // 
            // tbxID
            // 
            this.tbxID.Location = new System.Drawing.Point(112, 185);
            this.tbxID.Name = "tbxID";
            this.tbxID.Size = new System.Drawing.Size(268, 26);
            this.tbxID.TabIndex = 10;
            this.tbxID.TextChanged += new System.EventHandler(this.tbxID_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(38, 575);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "Salary";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 482);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 383);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "DoB";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 283);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Full Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Staff ID";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lstSearch);
            this.groupBox4.Location = new System.Drawing.Point(1184, 95);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(676, 555);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Search Results";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1886, 942);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.stsStatus);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.stsStatus.ResumeLayout(false);
            this.stsStatus.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.StatusStrip stsStatus;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem loadAndToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sortAToZToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sortZToAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAndSearchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSortZA;
        private System.Windows.Forms.Button btnSortAZ;
        private System.Windows.Forms.TextBox tbxSearch;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox lstSearch;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox tbxID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox tbxSalary;
        private System.Windows.Forms.TextBox tbxEmail;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateSelect;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ListBox lstStaff;
        private System.Windows.Forms.ToolStripStatusLabel tslStatus;
        private System.Windows.Forms.ToolTip ttpToolTips;
    }
}


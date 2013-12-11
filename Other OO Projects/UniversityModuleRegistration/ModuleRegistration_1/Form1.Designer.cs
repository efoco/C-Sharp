namespace ModuleRegistration_1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textboxID = new System.Windows.Forms.TextBox();
            this.textboxsurname = new System.Windows.Forms.TextBox();
            this.textboxname = new System.Windows.Forms.TextBox();
            this.lbl_ID = new System.Windows.Forms.Label();
            this.lbl_surname = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.submit = new System.Windows.Forms.Button();
            this.listOfChosenModules = new System.Windows.Forms.ListBox();
            this.listOfModules = new System.Windows.Forms.ListBox();
            this.btn_remove = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.lbl_selected_modules = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.schedule2 = new System.Windows.Forms.TableLayoutPanel();
            this.schedule1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.labelTutorial = new System.Windows.Forms.Label();
            this.labelLecture = new System.Windows.Forms.Label();
            this.labelPrerequisites = new System.Windows.Forms.Label();
            this.labelSemester = new System.Windows.Forms.Label();
            this.labelCapacity = new System.Windows.Forms.Label();
            this.labelModname = new System.Windows.Forms.Label();
            this.labelCode = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textboxID);
            this.groupBox1.Controls.Add(this.textboxsurname);
            this.groupBox1.Controls.Add(this.textboxname);
            this.groupBox1.Controls.Add(this.lbl_ID);
            this.groupBox1.Controls.Add(this.lbl_surname);
            this.groupBox1.Controls.Add(this.lbl_name);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(696, 50);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Student Details:";
            // 
            // textboxID
            // 
            this.textboxID.Location = new System.Drawing.Point(539, 18);
            this.textboxID.Name = "textboxID";
            this.textboxID.Size = new System.Drawing.Size(100, 20);
            this.textboxID.TabIndex = 5;
            // 
            // textboxsurname
            // 
            this.textboxsurname.Location = new System.Drawing.Point(276, 18);
            this.textboxsurname.Name = "textboxsurname";
            this.textboxsurname.Size = new System.Drawing.Size(100, 20);
            this.textboxsurname.TabIndex = 4;
            // 
            // textboxname
            // 
            this.textboxname.Location = new System.Drawing.Point(55, 19);
            this.textboxname.Name = "textboxname";
            this.textboxname.Size = new System.Drawing.Size(100, 20);
            this.textboxname.TabIndex = 3;
            // 
            // lbl_ID
            // 
            this.lbl_ID.AutoSize = true;
            this.lbl_ID.Location = new System.Drawing.Point(472, 21);
            this.lbl_ID.Name = "lbl_ID";
            this.lbl_ID.Size = new System.Drawing.Size(61, 13);
            this.lbl_ID.TabIndex = 2;
            this.lbl_ID.Text = "Student ID:";
            // 
            // lbl_surname
            // 
            this.lbl_surname.AutoSize = true;
            this.lbl_surname.Location = new System.Drawing.Point(218, 21);
            this.lbl_surname.Name = "lbl_surname";
            this.lbl_surname.Size = new System.Drawing.Size(52, 13);
            this.lbl_surname.TabIndex = 1;
            this.lbl_surname.Text = "Surname:";
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(11, 21);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(38, 13);
            this.lbl_name.TabIndex = 0;
            this.lbl_name.Text = "Name:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.submit);
            this.groupBox2.Controls.Add(this.listOfChosenModules);
            this.groupBox2.Controls.Add(this.listOfModules);
            this.groupBox2.Controls.Add(this.btn_remove);
            this.groupBox2.Controls.Add(this.btn_add);
            this.groupBox2.Controls.Add(this.lbl_selected_modules);
            this.groupBox2.Location = new System.Drawing.Point(12, 65);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(696, 275);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Select Modules:";
            // 
            // submit
            // 
            this.submit.Location = new System.Drawing.Point(300, 235);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(90, 23);
            this.submit.TabIndex = 7;
            this.submit.Text = "Submit";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // listOfChosenModules
            // 
            this.listOfChosenModules.FormattingEnabled = true;
            this.listOfChosenModules.Location = new System.Drawing.Point(406, 46);
            this.listOfChosenModules.Name = "listOfChosenModules";
            this.listOfChosenModules.Size = new System.Drawing.Size(262, 212);
            this.listOfChosenModules.TabIndex = 6;
            // 
            // listOfModules
            // 
            this.listOfModules.FormattingEnabled = true;
            this.listOfModules.Location = new System.Drawing.Point(22, 46);
            this.listOfModules.Name = "listOfModules";
            this.listOfModules.Size = new System.Drawing.Size(262, 212);
            this.listOfModules.TabIndex = 5;
            this.listOfModules.SelectedIndexChanged += new System.EventHandler(this.listOfModules_SelectedIndexChanged);
            // 
            // btn_remove
            // 
            this.btn_remove.Location = new System.Drawing.Point(328, 141);
            this.btn_remove.Name = "btn_remove";
            this.btn_remove.Size = new System.Drawing.Size(49, 23);
            this.btn_remove.TabIndex = 4;
            this.btn_remove.Text = "<-";
            this.btn_remove.UseVisualStyleBackColor = true;
            this.btn_remove.Click += new System.EventHandler(this.btn_remove_Click);
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(328, 112);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(49, 23);
            this.btn_add.TabIndex = 3;
            this.btn_add.Text = "->";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // lbl_selected_modules
            // 
            this.lbl_selected_modules.AutoSize = true;
            this.lbl_selected_modules.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_selected_modules.Location = new System.Drawing.Point(474, 16);
            this.lbl_selected_modules.Name = "lbl_selected_modules";
            this.lbl_selected_modules.Size = new System.Drawing.Size(120, 16);
            this.lbl_selected_modules.TabIndex = 0;
            this.lbl_selected_modules.Text = "Selected Modules:";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Controls.Add(this.label2);
            this.groupBox5.Controls.Add(this.schedule2);
            this.groupBox5.Controls.Add(this.schedule1);
            this.groupBox5.Controls.Add(this.label1);
            this.groupBox5.Controls.Add(this.comboBox1);
            this.groupBox5.Location = new System.Drawing.Point(13, 402);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(695, 241);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Timetable";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(554, 24);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "Friday";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(431, 24);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Thrusday";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(312, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Wednesday";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(194, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Tuesday";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(81, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Monday";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "4-6 pm";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "2-4 pm";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "11-1 pm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "9-11";
            // 
            // schedule2
            // 
            this.schedule2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.schedule2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetDouble;
            this.schedule2.ColumnCount = 5;
            this.schedule2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.schedule2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.schedule2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.schedule2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.schedule2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.schedule2.Location = new System.Drawing.Point(52, 40);
            this.schedule2.Name = "schedule2";
            this.schedule2.RowCount = 4;
            this.schedule2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.schedule2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.schedule2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.schedule2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.schedule2.Size = new System.Drawing.Size(587, 183);
            this.schedule2.TabIndex = 9;
            this.schedule2.Visible = false;
            // 
            // schedule1
            // 
            this.schedule1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.schedule1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetDouble;
            this.schedule1.ColumnCount = 5;
            this.schedule1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.schedule1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.schedule1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.schedule1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.schedule1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.schedule1.Location = new System.Drawing.Point(52, 40);
            this.schedule1.Name = "schedule1";
            this.schedule1.RowCount = 4;
            this.schedule1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.schedule1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.schedule1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.schedule1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.schedule1.Size = new System.Drawing.Size(584, 183);
            this.schedule1.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(601, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Semester:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "1",
            "2"});
            this.comboBox1.Location = new System.Drawing.Point(657, 16);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(35, 21);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.Text = "1";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // labelTutorial
            // 
            this.labelTutorial.AutoSize = true;
            this.labelTutorial.Location = new System.Drawing.Point(445, 376);
            this.labelTutorial.Name = "labelTutorial";
            this.labelTutorial.Size = new System.Drawing.Size(66, 13);
            this.labelTutorial.TabIndex = 13;
            this.labelTutorial.Text = "Tutorial Slot:";
            // 
            // labelLecture
            // 
            this.labelLecture.AutoSize = true;
            this.labelLecture.Location = new System.Drawing.Point(444, 353);
            this.labelLecture.Name = "labelLecture";
            this.labelLecture.Size = new System.Drawing.Size(67, 13);
            this.labelLecture.TabIndex = 12;
            this.labelLecture.Text = "Lecture Slot:";
            // 
            // labelPrerequisites
            // 
            this.labelPrerequisites.AutoSize = true;
            this.labelPrerequisites.Location = new System.Drawing.Point(257, 353);
            this.labelPrerequisites.Name = "labelPrerequisites";
            this.labelPrerequisites.Size = new System.Drawing.Size(65, 13);
            this.labelPrerequisites.TabIndex = 11;
            this.labelPrerequisites.Text = "Prerequisite:";
            // 
            // labelSemester
            // 
            this.labelSemester.AutoSize = true;
            this.labelSemester.Location = new System.Drawing.Point(614, 376);
            this.labelSemester.Name = "labelSemester";
            this.labelSemester.Size = new System.Drawing.Size(54, 13);
            this.labelSemester.TabIndex = 10;
            this.labelSemester.Text = "Semester:";
            // 
            // labelCapacity
            // 
            this.labelCapacity.AutoSize = true;
            this.labelCapacity.Location = new System.Drawing.Point(257, 376);
            this.labelCapacity.Name = "labelCapacity";
            this.labelCapacity.Size = new System.Drawing.Size(51, 13);
            this.labelCapacity.TabIndex = 9;
            this.labelCapacity.Text = "Capacity:";
            // 
            // labelModname
            // 
            this.labelModname.AutoSize = true;
            this.labelModname.Location = new System.Drawing.Point(23, 376);
            this.labelModname.Name = "labelModname";
            this.labelModname.Size = new System.Drawing.Size(38, 13);
            this.labelModname.TabIndex = 8;
            this.labelModname.Text = "Name:";
            // 
            // labelCode
            // 
            this.labelCode.AutoSize = true;
            this.labelCode.Location = new System.Drawing.Point(23, 353);
            this.labelCode.Name = "labelCode";
            this.labelCode.Size = new System.Drawing.Size(35, 13);
            this.labelCode.TabIndex = 7;
            this.labelCode.Text = "Code:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 655);
            this.Controls.Add(this.labelTutorial);
            this.Controls.Add(this.labelLecture);
            this.Controls.Add(this.labelPrerequisites);
            this.Controls.Add(this.labelSemester);
            this.Controls.Add(this.labelCapacity);
            this.Controls.Add(this.labelModname);
            this.Controls.Add(this.labelCode);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textboxID;
        private System.Windows.Forms.TextBox textboxsurname;
        private System.Windows.Forms.TextBox textboxname;
        private System.Windows.Forms.Label lbl_ID;
        private System.Windows.Forms.Label lbl_surname;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox listOfChosenModules;
        private System.Windows.Forms.ListBox listOfModules;
        private System.Windows.Forms.Button btn_remove;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Label lbl_selected_modules;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label labelTutorial;
        private System.Windows.Forms.Label labelLecture;
        private System.Windows.Forms.Label labelPrerequisites;
        private System.Windows.Forms.Label labelSemester;
        private System.Windows.Forms.Label labelCapacity;
        private System.Windows.Forms.Label labelModname;
        private System.Windows.Forms.Label labelCode;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.TableLayoutPanel schedule1;
        private System.Windows.Forms.TableLayoutPanel schedule2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}


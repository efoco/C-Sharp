namespace GradePrediction_1
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
            this.lbl_courseName = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.lbl_db = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_reset = new System.Windows.Forms.Button();
            this.txt_courseName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.radio_lvl6 = new System.Windows.Forms.RadioButton();
            this.radio_lvl5 = new System.Windows.Forms.RadioButton();
            this.radio_lvl4 = new System.Windows.Forms.RadioButton();
            this.go1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.tbl_tot0 = new System.Windows.Forms.TableLayoutPanel();
            this.add_lev4 = new System.Windows.Forms.Button();
            this.tbl_level4 = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_level4 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.add_lev5 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tbl_tot1 = new System.Windows.Forms.TableLayoutPanel();
            this.tbl_level5 = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_level5 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.add_lev6 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tbl_tot2 = new System.Windows.Forms.TableLayoutPanel();
            this.tbl_level6 = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_level6 = new System.Windows.Forms.Label();
            this.btn_calculate = new System.Windows.Forms.Button();
            this.btn_calculate2 = new System.Windows.Forms.Button();
            this.btn_calculate3 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_courseName
            // 
            this.lbl_courseName.AutoSize = true;
            this.lbl_courseName.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_courseName.Location = new System.Drawing.Point(412, 9);
            this.lbl_courseName.Name = "lbl_courseName";
            this.lbl_courseName.Size = new System.Drawing.Size(206, 33);
            this.lbl_courseName.TabIndex = 1;
            this.lbl_courseName.Text = "Course Name";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(12, 45);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1118, 379);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.lbl_db);
            this.tabPage3.Controls.Add(this.groupBox1);
            this.tabPage3.Controls.Add(this.go1);
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1110, 353);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Start";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // lbl_db
            // 
            this.lbl_db.AutoSize = true;
            this.lbl_db.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_db.ForeColor = System.Drawing.Color.Red;
            this.lbl_db.Location = new System.Drawing.Point(48, 54);
            this.lbl_db.Name = "lbl_db";
            this.lbl_db.Size = new System.Drawing.Size(304, 25);
            this.lbl_db.TabIndex = 5;
            this.lbl_db.Text = "The database was NOT found.";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_reset);
            this.groupBox1.Controls.Add(this.txt_courseName);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.radio_lvl6);
            this.groupBox1.Controls.Add(this.radio_lvl5);
            this.groupBox1.Controls.Add(this.radio_lvl4);
            this.groupBox1.Location = new System.Drawing.Point(837, 162);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(239, 135);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Course Information";
            this.groupBox1.Visible = false;
            // 
            // btn_reset
            // 
            this.btn_reset.Location = new System.Drawing.Point(133, 102);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(100, 21);
            this.btn_reset.TabIndex = 9;
            this.btn_reset.Text = "Reset";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // txt_courseName
            // 
            this.txt_courseName.Location = new System.Drawing.Point(133, 26);
            this.txt_courseName.Name = "txt_courseName";
            this.txt_courseName.Size = new System.Drawing.Size(100, 20);
            this.txt_courseName.TabIndex = 7;
            this.txt_courseName.TextChanged += new System.EventHandler(this.txt_courseName_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Enter your Course Name:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(133, 77);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Module Manager";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // radio_lvl6
            // 
            this.radio_lvl6.AutoSize = true;
            this.radio_lvl6.Location = new System.Drawing.Point(6, 106);
            this.radio_lvl6.Name = "radio_lvl6";
            this.radio_lvl6.Size = new System.Drawing.Size(60, 17);
            this.radio_lvl6.TabIndex = 2;
            this.radio_lvl6.TabStop = true;
            this.radio_lvl6.Text = "Level 6";
            this.radio_lvl6.UseVisualStyleBackColor = true;
            // 
            // radio_lvl5
            // 
            this.radio_lvl5.AutoSize = true;
            this.radio_lvl5.Location = new System.Drawing.Point(6, 83);
            this.radio_lvl5.Name = "radio_lvl5";
            this.radio_lvl5.Size = new System.Drawing.Size(60, 17);
            this.radio_lvl5.TabIndex = 1;
            this.radio_lvl5.TabStop = true;
            this.radio_lvl5.Text = "Level 5";
            this.radio_lvl5.UseVisualStyleBackColor = true;
            // 
            // radio_lvl4
            // 
            this.radio_lvl4.AutoSize = true;
            this.radio_lvl4.Checked = true;
            this.radio_lvl4.Location = new System.Drawing.Point(6, 60);
            this.radio_lvl4.Name = "radio_lvl4";
            this.radio_lvl4.Size = new System.Drawing.Size(60, 17);
            this.radio_lvl4.TabIndex = 0;
            this.radio_lvl4.TabStop = true;
            this.radio_lvl4.Text = "Level 4";
            this.radio_lvl4.UseVisualStyleBackColor = true;
            // 
            // go1
            // 
            this.go1.Location = new System.Drawing.Point(1002, 126);
            this.go1.Name = "go1";
            this.go1.Size = new System.Drawing.Size(75, 23);
            this.go1.TabIndex = 3;
            this.go1.Text = "Go";
            this.go1.UseVisualStyleBackColor = true;
            this.go1.Click += new System.EventHandler(this.go1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(819, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "Build your course";
            // 
            // tabPage1
            // 
            this.tabPage1.AutoScroll = true;
            this.tabPage1.Controls.Add(this.btn_calculate);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.tbl_tot0);
            this.tabPage1.Controls.Add(this.add_lev4);
            this.tabPage1.Controls.Add(this.tbl_level4);
            this.tabPage1.Controls.Add(this.lbl_level4);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1110, 353);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Year 1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(979, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Grade :";
            // 
            // tbl_tot0
            // 
            this.tbl_tot0.BackColor = System.Drawing.Color.Transparent;
            this.tbl_tot0.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.InsetDouble;
            this.tbl_tot0.ColumnCount = 1;
            this.tbl_tot0.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 144F));
            this.tbl_tot0.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tbl_tot0.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tbl_tot0.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tbl_tot0.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tbl_tot0.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tbl_tot0.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tbl_tot0.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tbl_tot0.Location = new System.Drawing.Point(930, 38);
            this.tbl_tot0.Name = "tbl_tot0";
            this.tbl_tot0.RowCount = 8;
            this.tbl_tot0.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tbl_tot0.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tbl_tot0.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tbl_tot0.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tbl_tot0.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tbl_tot0.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tbl_tot0.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tbl_tot0.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tbl_tot0.Size = new System.Drawing.Size(132, 594);
            this.tbl_tot0.TabIndex = 6;
            // 
            // add_lev4
            // 
            this.add_lev4.Location = new System.Drawing.Point(8, 9);
            this.add_lev4.Name = "add_lev4";
            this.add_lev4.Size = new System.Drawing.Size(108, 23);
            this.add_lev4.TabIndex = 5;
            this.add_lev4.Text = "Module Manager";
            this.add_lev4.UseVisualStyleBackColor = true;
            this.add_lev4.Click += new System.EventHandler(this.add_Click);
            // 
            // tbl_level4
            // 
            this.tbl_level4.BackColor = System.Drawing.Color.White;
            this.tbl_level4.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetPartial;
            this.tbl_level4.ColumnCount = 7;
            this.tbl_level4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.7678F));
            this.tbl_level4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.92443F));
            this.tbl_level4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.92443F));
            this.tbl_level4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.59584F));
            this.tbl_level4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.59584F));
            this.tbl_level4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.59584F));
            this.tbl_level4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.22872F));
            this.tbl_level4.Location = new System.Drawing.Point(8, 38);
            this.tbl_level4.Name = "tbl_level4";
            this.tbl_level4.RowCount = 8;
            this.tbl_level4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tbl_level4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tbl_level4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tbl_level4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tbl_level4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tbl_level4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tbl_level4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tbl_level4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tbl_level4.Size = new System.Drawing.Size(916, 573);
            this.tbl_level4.TabIndex = 2;
            // 
            // lbl_level4
            // 
            this.lbl_level4.AutoSize = true;
            this.lbl_level4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_level4.Location = new System.Drawing.Point(354, 3);
            this.lbl_level4.Name = "lbl_level4";
            this.lbl_level4.Size = new System.Drawing.Size(213, 25);
            this.lbl_level4.TabIndex = 2;
            this.lbl_level4.Text = "Level 4: (Average) %";
            // 
            // tabPage2
            // 
            this.tabPage2.AutoScroll = true;
            this.tabPage2.Controls.Add(this.btn_calculate2);
            this.tabPage2.Controls.Add(this.add_lev5);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.tbl_tot1);
            this.tabPage2.Controls.Add(this.tbl_level5);
            this.tabPage2.Controls.Add(this.lbl_level5);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1110, 353);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Year2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // add_lev5
            // 
            this.add_lev5.Location = new System.Drawing.Point(7, 7);
            this.add_lev5.Name = "add_lev5";
            this.add_lev5.Size = new System.Drawing.Size(100, 23);
            this.add_lev5.TabIndex = 8;
            this.add_lev5.Text = "Module Manager";
            this.add_lev5.UseVisualStyleBackColor = true;
            this.add_lev5.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1029, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Grade :";
            // 
            // tbl_tot1
            // 
            this.tbl_tot1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.InsetDouble;
            this.tbl_tot1.ColumnCount = 1;
            this.tbl_tot1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 144F));
            this.tbl_tot1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tbl_tot1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tbl_tot1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tbl_tot1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tbl_tot1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tbl_tot1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tbl_tot1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tbl_tot1.Location = new System.Drawing.Point(980, 31);
            this.tbl_tot1.Name = "tbl_tot1";
            this.tbl_tot1.RowCount = 8;
            this.tbl_tot1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tbl_tot1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tbl_tot1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tbl_tot1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tbl_tot1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tbl_tot1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tbl_tot1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tbl_tot1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tbl_tot1.Size = new System.Drawing.Size(132, 601);
            this.tbl_tot1.TabIndex = 6;
            // 
            // tbl_level5
            // 
            this.tbl_level5.BackColor = System.Drawing.Color.White;
            this.tbl_level5.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetPartial;
            this.tbl_level5.ColumnCount = 7;
            this.tbl_level5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.94626F));
            this.tbl_level5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.00896F));
            this.tbl_level5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.00896F));
            this.tbl_level5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.00896F));
            this.tbl_level5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.00896F));
            this.tbl_level5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.00896F));
            this.tbl_level5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.00896F));
            this.tbl_level5.Location = new System.Drawing.Point(6, 31);
            this.tbl_level5.Name = "tbl_level5";
            this.tbl_level5.RowCount = 8;
            this.tbl_level5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tbl_level5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tbl_level5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tbl_level5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tbl_level5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tbl_level5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tbl_level5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tbl_level5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tbl_level5.Size = new System.Drawing.Size(973, 692);
            this.tbl_level5.TabIndex = 5;
            // 
            // lbl_level5
            // 
            this.lbl_level5.AutoSize = true;
            this.lbl_level5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_level5.Location = new System.Drawing.Point(385, 3);
            this.lbl_level5.Name = "lbl_level5";
            this.lbl_level5.Size = new System.Drawing.Size(213, 25);
            this.lbl_level5.TabIndex = 4;
            this.lbl_level5.Text = "Level 5: (Average) %";
            // 
            // tabPage4
            // 
            this.tabPage4.AutoScroll = true;
            this.tabPage4.Controls.Add(this.btn_calculate3);
            this.tabPage4.Controls.Add(this.add_lev6);
            this.tabPage4.Controls.Add(this.label4);
            this.tabPage4.Controls.Add(this.tbl_tot2);
            this.tabPage4.Controls.Add(this.tbl_level6);
            this.tabPage4.Controls.Add(this.lbl_level6);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1110, 353);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Year 3";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // add_lev6
            // 
            this.add_lev6.Location = new System.Drawing.Point(6, 4);
            this.add_lev6.Name = "add_lev6";
            this.add_lev6.Size = new System.Drawing.Size(95, 23);
            this.add_lev6.TabIndex = 7;
            this.add_lev6.Text = "Module Manager";
            this.add_lev6.UseVisualStyleBackColor = true;
            this.add_lev6.Click += new System.EventHandler(this.add_lev6_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1100, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Grade :";
            // 
            // tbl_tot2
            // 
            this.tbl_tot2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.InsetDouble;
            this.tbl_tot2.ColumnCount = 1;
            this.tbl_tot2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 144F));
            this.tbl_tot2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tbl_tot2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tbl_tot2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tbl_tot2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tbl_tot2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tbl_tot2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tbl_tot2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tbl_tot2.Location = new System.Drawing.Point(1051, 31);
            this.tbl_tot2.Name = "tbl_tot2";
            this.tbl_tot2.RowCount = 8;
            this.tbl_tot2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tbl_tot2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tbl_tot2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tbl_tot2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tbl_tot2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tbl_tot2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tbl_tot2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tbl_tot2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tbl_tot2.Size = new System.Drawing.Size(132, 601);
            this.tbl_tot2.TabIndex = 5;
            // 
            // tbl_level6
            // 
            this.tbl_level6.BackColor = System.Drawing.Color.White;
            this.tbl_level6.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetPartial;
            this.tbl_level6.ColumnCount = 7;
            this.tbl_level6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.53361F));
            this.tbl_level6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.07773F));
            this.tbl_level6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.07773F));
            this.tbl_level6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.07773F));
            this.tbl_level6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.07773F));
            this.tbl_level6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.07773F));
            this.tbl_level6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.07773F));
            this.tbl_level6.Location = new System.Drawing.Point(6, 31);
            this.tbl_level6.Name = "tbl_level6";
            this.tbl_level6.RowCount = 8;
            this.tbl_level6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tbl_level6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tbl_level6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tbl_level6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tbl_level6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tbl_level6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tbl_level6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tbl_level6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tbl_level6.Size = new System.Drawing.Size(1041, 582);
            this.tbl_level6.TabIndex = 2;
            // 
            // lbl_level6
            // 
            this.lbl_level6.AutoSize = true;
            this.lbl_level6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_level6.Location = new System.Drawing.Point(354, 3);
            this.lbl_level6.Name = "lbl_level6";
            this.lbl_level6.Size = new System.Drawing.Size(213, 25);
            this.lbl_level6.TabIndex = 2;
            this.lbl_level6.Text = "Level 6: (Average) %";
            // 
            // btn_calculate
            // 
            this.btn_calculate.Location = new System.Drawing.Point(898, 9);
            this.btn_calculate.Name = "btn_calculate";
            this.btn_calculate.Size = new System.Drawing.Size(75, 23);
            this.btn_calculate.TabIndex = 8;
            this.btn_calculate.Text = "Calculate";
            this.btn_calculate.UseVisualStyleBackColor = true;
            this.btn_calculate.Click += new System.EventHandler(this.btn_calculate_Click);
            // 
            // btn_calculate2
            // 
            this.btn_calculate2.Location = new System.Drawing.Point(948, 6);
            this.btn_calculate2.Name = "btn_calculate2";
            this.btn_calculate2.Size = new System.Drawing.Size(75, 23);
            this.btn_calculate2.TabIndex = 9;
            this.btn_calculate2.Text = "Calculate";
            this.btn_calculate2.UseVisualStyleBackColor = true;
            this.btn_calculate2.Click += new System.EventHandler(this.btn_calculate2_Click);
            // 
            // btn_calculate3
            // 
            this.btn_calculate3.Location = new System.Drawing.Point(1019, 7);
            this.btn_calculate3.Name = "btn_calculate3";
            this.btn_calculate3.Size = new System.Drawing.Size(75, 23);
            this.btn_calculate3.TabIndex = 10;
            this.btn_calculate3.Text = "Calculate";
            this.btn_calculate3.UseVisualStyleBackColor = true;
            this.btn_calculate3.Click += new System.EventHandler(this.btn_calculate3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1152, 455);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.lbl_courseName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_courseName;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TableLayoutPanel tbl_level4;
        private System.Windows.Forms.Label lbl_level4;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label lbl_level5;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TableLayoutPanel tbl_level6;
        private System.Windows.Forms.Label lbl_level6;
        private System.Windows.Forms.TableLayoutPanel tbl_level5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TableLayoutPanel tbl_tot1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TableLayoutPanel tbl_tot2;
        private System.Windows.Forms.Button add_lev4;
        private System.Windows.Forms.Button add_lev5;
        private System.Windows.Forms.Button add_lev6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel tbl_tot0;
        private System.Windows.Forms.Button go1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_courseName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton radio_lvl6;
        private System.Windows.Forms.RadioButton radio_lvl5;
        private System.Windows.Forms.RadioButton radio_lvl4;
        private System.Windows.Forms.Label lbl_db;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Button btn_calculate;
        private System.Windows.Forms.Button btn_calculate2;
        private System.Windows.Forms.Button btn_calculate3;
    }
}


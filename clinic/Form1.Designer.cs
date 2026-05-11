namespace clinic
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel2 = new System.Windows.Forms.Panel();
            this.button8 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.patientsPanel = new System.Windows.Forms.Panel();
            this.addBtn2 = new System.Windows.Forms.PictureBox();
            this.AddAppointment = new System.Windows.Forms.Button();
            this.addBtn1 = new System.Windows.Forms.PictureBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.appointmentdelete = new System.Windows.Forms.Button();
            this.appointmentedit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.appointmentsGrid = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.datagridAppointments = new System.Windows.Forms.DataGridView();
            this.cLINICDBDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cLINIC_DBDataSet1 = new clinic.CLINIC_DBDataSet1();
            this.datagridPatients = new System.Windows.Forms.DataGridView();
            this.addBtn = new System.Windows.Forms.Button();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.patientsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addBtn2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addBtn1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagridAppointments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLINICDBDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLINIC_DBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagridPatients)).BeginInit();
            this.mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.OldLace;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.button8);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(318, 833);
            this.panel2.TabIndex = 1;
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.Crimson;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button8.Location = new System.Drawing.Point(94, 724);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(139, 23);
            this.button8.TabIndex = 3;
            this.button8.Text = "Log Out";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkCyan;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(94, 160);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(139, 33);
            this.button2.TabIndex = 1;
            this.button2.Text = "Dashboard";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkCyan;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(94, 240);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 33);
            this.button1.TabIndex = 0;
            this.button1.Text = "Patients";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.OldLace;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(318, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1150, 100);
            this.panel3.TabIndex = 2;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.DarkCyan;
            this.panel5.Location = new System.Drawing.Point(454, 48);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(250, 2);
            this.panel5.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label1.Location = new System.Drawing.Point(477, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "DENTAL CLINIC";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // patientsPanel
            // 
            this.patientsPanel.BackColor = System.Drawing.Color.Cornsilk;
            this.patientsPanel.Controls.Add(this.addBtn2);
            this.patientsPanel.Controls.Add(this.AddAppointment);
            this.patientsPanel.Controls.Add(this.addBtn1);
            this.patientsPanel.Controls.Add(this.monthCalendar1);
            this.patientsPanel.Controls.Add(this.appointmentdelete);
            this.patientsPanel.Controls.Add(this.appointmentedit);
            this.patientsPanel.Controls.Add(this.panel1);
            this.patientsPanel.Controls.Add(this.appointmentsGrid);
            this.patientsPanel.Controls.Add(this.panel4);
            this.patientsPanel.Controls.Add(this.label3);
            this.patientsPanel.Controls.Add(this.label2);
            this.patientsPanel.Controls.Add(this.button7);
            this.patientsPanel.Controls.Add(this.button5);
            this.patientsPanel.Controls.Add(this.datagridAppointments);
            this.patientsPanel.Controls.Add(this.datagridPatients);
            this.patientsPanel.Controls.Add(this.addBtn);
            this.patientsPanel.Location = new System.Drawing.Point(0, 0);
            this.patientsPanel.Name = "patientsPanel";
            this.patientsPanel.Size = new System.Drawing.Size(1150, 733);
            this.patientsPanel.TabIndex = 3;
            this.patientsPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // addBtn2
            // 
            this.addBtn2.BackColor = System.Drawing.Color.DarkCyan;
            this.addBtn2.Image = ((System.Drawing.Image)(resources.GetObject("addBtn2.Image")));
            this.addBtn2.Location = new System.Drawing.Point(165, 334);
            this.addBtn2.Name = "addBtn2";
            this.addBtn2.Size = new System.Drawing.Size(25, 25);
            this.addBtn2.TabIndex = 17;
            this.addBtn2.TabStop = false;
            this.addBtn2.Click += new System.EventHandler(this.addBtn2_Click);
            // 
            // AddAppointment
            // 
            this.AddAppointment.BackColor = System.Drawing.Color.DarkCyan;
            this.AddAppointment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddAppointment.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddAppointment.ForeColor = System.Drawing.Color.White;
            this.AddAppointment.Location = new System.Drawing.Point(165, 333);
            this.AddAppointment.Name = "AddAppointment";
            this.AddAppointment.Size = new System.Drawing.Size(25, 25);
            this.AddAppointment.TabIndex = 12;
            this.AddAppointment.UseVisualStyleBackColor = false;
            this.AddAppointment.Click += new System.EventHandler(this.btnAddAppointment_Click);
            // 
            // addBtn1
            // 
            this.addBtn1.BackColor = System.Drawing.Color.DarkCyan;
            this.addBtn1.Image = ((System.Drawing.Image)(resources.GetObject("addBtn1.Image")));
            this.addBtn1.Location = new System.Drawing.Point(117, 27);
            this.addBtn1.Name = "addBtn1";
            this.addBtn1.Size = new System.Drawing.Size(25, 25);
            this.addBtn1.TabIndex = 16;
            this.addBtn1.TabStop = false;
            this.addBtn1.Click += new System.EventHandler(this.addBtn1_Click);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(912, 76);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 15;
            // 
            // appointmentdelete
            // 
            this.appointmentdelete.BackColor = System.Drawing.Color.Crimson;
            this.appointmentdelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.appointmentdelete.ForeColor = System.Drawing.Color.White;
            this.appointmentdelete.Location = new System.Drawing.Point(842, 338);
            this.appointmentdelete.Name = "appointmentdelete";
            this.appointmentdelete.Size = new System.Drawing.Size(58, 23);
            this.appointmentdelete.TabIndex = 14;
            this.appointmentdelete.Text = "Delete";
            this.appointmentdelete.UseVisualStyleBackColor = false;
            this.appointmentdelete.Click += new System.EventHandler(this.appointmentdelete_Click);
            // 
            // appointmentedit
            // 
            this.appointmentedit.BackColor = System.Drawing.Color.DarkCyan;
            this.appointmentedit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.appointmentedit.ForeColor = System.Drawing.Color.White;
            this.appointmentedit.Location = new System.Drawing.Point(778, 338);
            this.appointmentedit.Name = "appointmentedit";
            this.appointmentedit.Size = new System.Drawing.Size(58, 23);
            this.appointmentedit.TabIndex = 13;
            this.appointmentedit.Text = "Edit";
            this.appointmentedit.UseVisualStyleBackColor = false;
            this.appointmentedit.Click += new System.EventHandler(this.appointmentedit_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkCyan;
            this.panel1.Location = new System.Drawing.Point(24, 362);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(135, 2);
            this.panel1.TabIndex = 10;
            // 
            // appointmentsGrid
            // 
            this.appointmentsGrid.AutoSize = true;
            this.appointmentsGrid.Font = new System.Drawing.Font("Gadugi", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appointmentsGrid.Location = new System.Drawing.Point(24, 335);
            this.appointmentsGrid.Name = "appointmentsGrid";
            this.appointmentsGrid.Size = new System.Drawing.Size(135, 24);
            this.appointmentsGrid.TabIndex = 11;
            this.appointmentsGrid.Text = "Appointments";
            this.appointmentsGrid.Click += new System.EventHandler(this.appointmentsGrid_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DarkCyan;
            this.panel4.Location = new System.Drawing.Point(24, 53);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(85, 2);
            this.panel4.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoEllipsis = true;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Gadugi", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(24, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "Patients";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Crimson;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.ForeColor = System.Drawing.Color.White;
            this.button7.Location = new System.Drawing.Point(842, 29);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(58, 23);
            this.button7.TabIndex = 6;
            this.button7.Text = "Delete";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Teal;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(778, 29);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(58, 23);
            this.button5.TabIndex = 4;
            this.button5.Text = "Edit";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // datagridAppointments
            // 
            this.datagridAppointments.AutoGenerateColumns = false;
            this.datagridAppointments.BackgroundColor = System.Drawing.Color.White;
            this.datagridAppointments.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagridAppointments.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.datagridAppointments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridAppointments.DataSource = this.cLINICDBDataSet1BindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.datagridAppointments.DefaultCellStyle = dataGridViewCellStyle2;
            this.datagridAppointments.Location = new System.Drawing.Point(24, 370);
            this.datagridAppointments.Name = "datagridAppointments";
            this.datagridAppointments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagridAppointments.Size = new System.Drawing.Size(876, 208);
            this.datagridAppointments.TabIndex = 1;
            // 
            // cLINICDBDataSet1BindingSource
            // 
            this.cLINICDBDataSet1BindingSource.DataSource = this.cLINIC_DBDataSet1;
            this.cLINICDBDataSet1BindingSource.Position = 0;
            // 
            // cLINIC_DBDataSet1
            // 
            this.cLINIC_DBDataSet1.DataSetName = "CLINIC_DBDataSet1";
            this.cLINIC_DBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // datagridPatients
            // 
            this.datagridPatients.AutoGenerateColumns = false;
            this.datagridPatients.BackgroundColor = System.Drawing.Color.White;
            this.datagridPatients.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagridPatients.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.datagridPatients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridPatients.DataSource = this.cLINICDBDataSet1BindingSource;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.datagridPatients.DefaultCellStyle = dataGridViewCellStyle4;
            this.datagridPatients.Location = new System.Drawing.Point(24, 61);
            this.datagridPatients.Name = "datagridPatients";
            this.datagridPatients.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagridPatients.Size = new System.Drawing.Size(876, 206);
            this.datagridPatients.TabIndex = 0;
            this.datagridPatients.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagridPatients_CellContentClick);
            // 
            // addBtn
            // 
            this.addBtn.BackColor = System.Drawing.Color.DarkCyan;
            this.addBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addBtn.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBtn.ForeColor = System.Drawing.Color.White;
            this.addBtn.Location = new System.Drawing.Point(117, 26);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(25, 25);
            this.addBtn.TabIndex = 3;
            this.addBtn.UseVisualStyleBackColor = false;
            this.addBtn.Click += new System.EventHandler(this.button4_Click);
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.patientsPanel);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(318, 100);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1150, 733);
            this.mainPanel.TabIndex = 13;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(676, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(28, 27);
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(1468, 833);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Name = "Form1";
            this.Text = "Clinic Management";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.patientsPanel.ResumeLayout(false);
            this.patientsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addBtn2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addBtn1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagridAppointments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLINICDBDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLINIC_DBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagridPatients)).EndInit();
            this.mainPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel patientsPanel;
        private System.Windows.Forms.DataGridView datagridPatients;
        private System.Windows.Forms.BindingSource cLINICDBDataSet1BindingSource;
        private CLINIC_DBDataSet1 cLINIC_DBDataSet1;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.DataGridView datagridAppointments;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label appointmentsGrid;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Button AddAppointment;
        private System.Windows.Forms.Button appointmentdelete;
        private System.Windows.Forms.Button appointmentedit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.PictureBox addBtn1;
        private System.Windows.Forms.PictureBox addBtn2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}


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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
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
            this.panel6 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.patientsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addBtn2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addBtn1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagridAppointments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLINICDBDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLINIC_DBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagridPatients)).BeginInit();
            this.mainPanel.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightBlue;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnLogOut);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(312, 778);
            this.panel2.TabIndex = 1;
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.Crimson;
            this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogOut.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnLogOut.Location = new System.Drawing.Point(94, 709);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(139, 23);
            this.btnLogOut.TabIndex = 3;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.button8_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkCyan;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(94, 175);
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
            this.panel3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(312, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1156, 100);
            this.panel3.TabIndex = 2;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
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
            this.patientsPanel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.patientsPanel.Controls.Add(this.panel6);
            this.patientsPanel.Controls.Add(this.addBtn2);
            this.patientsPanel.Controls.Add(this.AddAppointment);
            this.patientsPanel.Controls.Add(this.addBtn1);
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
            this.monthCalendar1.Location = new System.Drawing.Point(-2, 44);
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
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagridAppointments.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.datagridAppointments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridAppointments.DataSource = this.cLINICDBDataSet1BindingSource;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.datagridAppointments.DefaultCellStyle = dataGridViewCellStyle10;
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
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagridPatients.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.datagridPatients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridPatients.DataSource = this.cLINICDBDataSet1BindingSource;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.datagridPatients.DefaultCellStyle = dataGridViewCellStyle12;
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
            this.mainPanel.Location = new System.Drawing.Point(312, 100);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1156, 678);
            this.mainPanel.TabIndex = 13;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel6.Controls.Add(this.label4);
            this.panel6.Controls.Add(this.monthCalendar1);
            this.panel6.Location = new System.Drawing.Point(922, 61);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(222, 206);
            this.panel6.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(73, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 21);
            this.label4.TabIndex = 16;
            this.label4.Text = "Calendar";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(1468, 778);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Clinic Management";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.patientsPanel.ResumeLayout(false);
            this.patientsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addBtn2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addBtn1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagridAppointments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLINICDBDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLINIC_DBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagridPatients)).EndInit();
            this.mainPanel.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
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
        private System.Windows.Forms.Button btnLogOut;
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
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label4;
    }
}


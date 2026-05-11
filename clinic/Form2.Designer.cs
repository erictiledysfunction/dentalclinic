namespace clinic
{
    partial class AddPatient
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
            this.nameTB = new System.Windows.Forms.TextBox();
            this.ageTB = new System.Windows.Forms.TextBox();
            this.patientCancel = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.genderCB = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.addPbtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Patient";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // nameTB
            // 
            this.nameTB.Location = new System.Drawing.Point(20, 92);
            this.nameTB.Name = "nameTB";
            this.nameTB.Size = new System.Drawing.Size(266, 20);
            this.nameTB.TabIndex = 1;
            this.nameTB.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // ageTB
            // 
            this.ageTB.Location = new System.Drawing.Point(20, 168);
            this.ageTB.Name = "ageTB";
            this.ageTB.Size = new System.Drawing.Size(107, 20);
            this.ageTB.TabIndex = 2;
            this.ageTB.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // patientCancel
            // 
            this.patientCancel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientCancel.Location = new System.Drawing.Point(180, 271);
            this.patientCancel.Name = "patientCancel";
            this.patientCancel.Size = new System.Drawing.Size(75, 23);
            this.patientCancel.TabIndex = 4;
            this.patientCancel.Text = "Cancel";
            this.patientCancel.UseVisualStyleBackColor = true;
            this.patientCancel.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Full Name";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Age";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(146, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Gender";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // genderCB
            // 
            this.genderCB.FormattingEnabled = true;
            this.genderCB.Location = new System.Drawing.Point(149, 168);
            this.genderCB.Name = "genderCB";
            this.genderCB.Size = new System.Drawing.Size(137, 21);
            this.genderCB.TabIndex = 11;
            this.genderCB.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Cornsilk;
            this.panel1.Controls.Add(this.addPbtn);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.genderCB);
            this.panel1.Controls.Add(this.patientCancel);
            this.panel1.Controls.Add(this.nameTB);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.ageTB);
            this.panel1.Location = new System.Drawing.Point(2, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(313, 344);
            this.panel1.TabIndex = 12;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // addPbtn
            // 
            this.addPbtn.BackColor = System.Drawing.Color.DarkCyan;
            this.addPbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addPbtn.ForeColor = System.Drawing.Color.White;
            this.addPbtn.Location = new System.Drawing.Point(52, 271);
            this.addPbtn.Name = "addPbtn";
            this.addPbtn.Size = new System.Drawing.Size(75, 23);
            this.addPbtn.TabIndex = 12;
            this.addPbtn.Text = "Save";
            this.addPbtn.UseVisualStyleBackColor = false;
            this.addPbtn.Click += new System.EventHandler(this.addPbtn_Click);
            // 
            // AddPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(315, 342);
            this.Controls.Add(this.panel1);
            this.Name = "AddPatient";
            this.Text = "Add Patient";
            this.Load += new System.EventHandler(this.AddPatient_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nameTB;
        private System.Windows.Forms.TextBox ageTB;
        private System.Windows.Forms.Button patientCancel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox genderCB;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button addPbtn;
    }
}
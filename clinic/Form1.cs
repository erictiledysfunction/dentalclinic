using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace clinic
{
    public partial class Form1 : Form
    {
        private ReportsControl reportsControl;

        private void LoadPatients()
        {
            string connectionString = "Server=localhost\\SQLEXPRESS;Database=CLINIC_DB;Trusted_Connection=True;";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM dbo.Patients", conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                

                datagridPatients.AutoGenerateColumns = true;
                datagridPatients.DataSource = null;
                datagridPatients.DataSource = dt;
                datagridPatients.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }

        }





        public Form1()
        {
            InitializeComponent();
       
        }

        private void datagridPatients_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            AddPatient addPatient = new AddPatient();
            addPatient.ShowDialog();
            LoadPatients();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadPatients();
            LoadAppointments();
            patientsPanel.Visible = false;

            if (reportsControl == null)
            {
                reportsControl = new ReportsControl();
                reportsControl.Dock = DockStyle.Fill;
                this.Controls.Add(reportsControl);
            }

            reportsControl.Visible = true;
            reportsControl.BringToFront();
        


        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LoadForm(Form form)
        {
            mainPanel.Controls.Clear();

            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;

            mainPanel.Controls.Add(form);
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (reportsControl == null)
            {
                reportsControl = new ReportsControl();
                reportsControl.Dock = DockStyle.Fill;
                this.Controls.Add(reportsControl);
            }

            patientsPanel.Visible = false;
            reportsControl.Visible = true;
            reportsControl.BringToFront();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (datagridPatients.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a patient to edit.");
                return;
            }

            DataGridViewRow row = datagridPatients.SelectedRows[0];
            int patientId = Convert.ToInt32(row.Cells["PatientID"].Value);
            string fullName = row.Cells["FullName"].Value.ToString();
            int age = Convert.ToInt32(row.Cells["Age"].Value);
            string gender = row.Cells["Gender"].Value.ToString();

            string phoneNumber = row.Cells["PhoneNumber"].Value?.ToString() ?? "";
            EditPatient editForm = new EditPatient(patientId, fullName, age, gender, phoneNumber);
            editForm.ShowDialog();
            LoadPatients();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (datagridPatients.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a patient to delete.");
                return;
            }

            DataGridViewRow row = datagridPatients.SelectedRows[0];
            int patientId = Convert.ToInt32(row.Cells["PatientID"].Value);
            string fullName = row.Cells["FullName"].Value.ToString();

            DialogResult confirm = MessageBox.Show(
                $"Are you sure you want to delete {fullName}?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (confirm == DialogResult.Yes)
            {
                try
                {
                    string connectionString = "Server=localhost\\SQLEXPRESS;Database=CLINIC_DB;Trusted_Connection=True;";
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();

                        SqlCommand checkCmd = new SqlCommand(
                            "SELECT COUNT(*) FROM dbo.Appointments WHERE PatientID = @ID", conn
                        );
                        checkCmd.Parameters.AddWithValue("@ID", patientId);
                        int count = (int)checkCmd.ExecuteScalar();

                        if (count > 0)
                        {
                            MessageBox.Show($"{fullName} has {count} existing appointment(s). Please delete their appointments first.");
                            return;
                        }

                        SqlCommand cmd = new SqlCommand(
                            "DELETE FROM dbo.Patients WHERE PatientID = @ID", conn
                        );
                        cmd.Parameters.AddWithValue("@ID", patientId);
                        cmd.ExecuteNonQuery();
                    }
                    MessageBox.Show("Patient deleted.");
                    LoadPatients();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to log out?", "Log Out",
        MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                LoginForm login = new LoginForm();
                login.Show();
                this.Close();
            }
        }
        private void LoadAppointments()
        {



            string connectionString = "Server=localhost\\SQLEXPRESS;Database=CLINIC_DB;Trusted_Connection=True;";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(
                    @"SELECT a.AppointmentID, p.FullName AS PatientName, 
              a.Schedule, a.Status, a.Treatment
              FROM dbo.Appointments a
              INNER JOIN dbo.Patients p ON a.PatientID = p.PatientID
              ORDER BY 
                CASE 
                    WHEN CAST(a.Schedule AS DATE) = CAST(GETDATE() AS DATE) THEN 0
                    WHEN CAST(a.Schedule AS DATE) > CAST(GETDATE() AS DATE) THEN 1
                    ELSE 2
                END,
                a.Schedule ASC",
                    conn
                );
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                datagridAppointments.AutoGenerateColumns = true;
                datagridAppointments.DataSource = null;
                datagridAppointments.DataSource = dt;
                datagridAppointments.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                // Apply row coloring based on Status only
                foreach (DataGridViewRow row in datagridAppointments.Rows)
                {
                    if (row.IsNewRow) continue;

                    string status = row.Cells["Status"].Value?.ToString() ?? "";

                    switch (status)
                    {
                        case "Completed":
                            row.DefaultCellStyle.BackColor = Color.LightGray;
                            break;
                        case "Cancelled":
                            row.DefaultCellStyle.BackColor = Color.LightCoral;
                            break;
                        default: // Scheduled
                            row.DefaultCellStyle.BackColor = Color.White;
                            break;
                    }
                }
            }


        }

        private void btnAddAppointment_Click(object sender, EventArgs e)
        {
            AddAppointment addAppointment = new AddAppointment();
            addAppointment.ShowDialog();
            LoadAppointments();
        }

        private void appointmentsGrid_Click(object sender, EventArgs e)
        {

        }

        private void appointmentedit_Click(object sender, EventArgs e)
        {
            if (datagridAppointments.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an appointment to edit.");
                return;
            }

            DataGridViewRow row = datagridAppointments.SelectedRows[0];
            int appointmentId = Convert.ToInt32(row.Cells["AppointmentID"].Value);
            string patientName = row.Cells["PatientName"].Value.ToString();
            DateTime schedule = Convert.ToDateTime(row.Cells["Schedule"].Value);
            string status = row.Cells["Status"].Value.ToString();
            string treatment = row.Cells["Treatment"].Value.ToString();

            EditAppointment editForm = new EditAppointment(appointmentId, patientName, schedule, status, treatment);
            editForm.ShowDialog();
            LoadAppointments();
        }

        private void appointmentdelete_Click(object sender, EventArgs e)
        {
            if (datagridAppointments.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an appointment to delete.");
                return;
            }

            DataGridViewRow row = datagridAppointments.SelectedRows[0];
            int appointmentId = Convert.ToInt32(row.Cells["AppointmentID"].Value);
            string patientName = row.Cells["PatientName"].Value.ToString();

            DialogResult confirm = MessageBox.Show(
                $"Are you sure you want to delete the appointment for {patientName}?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (confirm == DialogResult.Yes)
            {
                try
                {
                    string connectionString = "Server=localhost\\SQLEXPRESS;Database=CLINIC_DB;Trusted_Connection=True;";
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();
                        SqlCommand cmd = new SqlCommand("DELETE FROM dbo.Appointments WHERE AppointmentID = @ID", conn);
                        cmd.Parameters.AddWithValue("@ID", appointmentId);
                        cmd.ExecuteNonQuery();
                    }
                    MessageBox.Show("Appointment deleted.");
                    LoadAppointments();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void addBtn1_Click(object sender, EventArgs e)
        {
            AddPatient addPatient = new AddPatient();
            addPatient.ShowDialog();
            LoadPatients();
        }

        private void addBtn2_Click(object sender, EventArgs e)
        {
            AddAppointment addAppointment = new AddAppointment();
            addAppointment.ShowDialog();
            LoadAppointments();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (reportsControl != null)
                reportsControl.Visible = false;

            patientsPanel.Visible = true;
            patientsPanel.BringToFront();



        }
    }
}

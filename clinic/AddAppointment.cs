using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace clinic
{
    public partial class AddAppointment : Form
    {
        private string connectionString = "Server=localhost\\SQLEXPRESS;Database=CLINIC_DB;Trusted_Connection=True;";

        public AddAppointment()
        {
            InitializeComponent();
        }

        private void AddAppointment_Load(object sender, EventArgs e)
        {
            // Load patients into dropdown
            LoadPatients();

            // Status options
            statusCB.Items.AddRange(new string[] {
                "Scheduled", "Cancelled", "Completed"
            });

            // Treatment options
            treatmentCB.Items.AddRange(new string[] {
                "Cleaning", "Extraction", "Braces", "Root Canal",
                "Filling", "Whitening", "Crown", "Dentures", "X-Ray"
            });

            // Default date to today
            scheduleDTP.Value = DateTime.Now;
        }

        private void LoadPatients()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT PatientID, FullName FROM dbo.Patients", conn);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    patientCB.Items.Add(new PatientItem
                    {
                        PatientID = Convert.ToInt32(reader["PatientID"]),
                        FullName = reader["FullName"].ToString()
                    });
                }
            }
            patientCB.DisplayMember = "FullName";
            patientCB.ValueMember = "PatientID";
        }

        private void btnAddAppointment_Click(object sender, EventArgs e)
        {
            if (patientCB.SelectedItem == null)
            {
                MessageBox.Show("Please select a patient.");
                return;
            }

            if (statusCB.SelectedItem == null)
            {
                MessageBox.Show("Please select a status.");
                return;
            }

            if (treatmentCB.SelectedItem == null)
            {
                MessageBox.Show("Please select a treatment.");
                return;
            }

            int patientId = ((PatientItem)patientCB.SelectedItem).PatientID;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(
                    "INSERT INTO dbo.Appointments (PatientID, Schedule, Status, Treatment) VALUES (@PatientID, @Schedule, @Status, @Treatment)",
                    conn
                );
                cmd.Parameters.AddWithValue("@PatientID", patientId);
                cmd.Parameters.AddWithValue("@Schedule", scheduleDTP.Value);
                cmd.Parameters.AddWithValue("@Status", statusCB.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@Treatment", treatmentCB.SelectedItem.ToString());
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Appointment added!");
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddAppointment_Click_1(object sender, EventArgs e)
        {
            if (patientCB.SelectedItem == null)
            {
                MessageBox.Show("Please select a patient.");
                return;
            }

            if (statusCB.SelectedItem == null)
            {
                MessageBox.Show("Please select a status.");
                return;
            }

            if (treatmentCB.SelectedItem == null)
            {
                MessageBox.Show("Please select a treatment.");
                return;
            }

            try
            {
                int patientId = ((PatientItem)patientCB.SelectedItem).PatientID;

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(
                        "INSERT INTO dbo.Appointments (PatientID, Schedule, Status, Treatment) VALUES (@PatientID, @Schedule, @Status, @Treatment)",
                        conn
                    );
                    cmd.Parameters.AddWithValue("@PatientID", patientId);
                    cmd.Parameters.AddWithValue("@Schedule", scheduleDTP.Value);
                    cmd.Parameters.AddWithValue("@Status", statusCB.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@Treatment", treatmentCB.SelectedItem.ToString());
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Appointment Added!");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void scheduleDTP_ValueChanged(object sender, EventArgs e)
        {

        }
    }

    
    public class PatientItem
    {
        public int PatientID { get; set; }
        public string FullName { get; set; }
    }
}
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

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
            LoadPatients();

            statusCB.Items.AddRange(new string[] {
        "Scheduled", "Cancelled", "Completed"
    });

            treatmentCB.Items.AddRange(new string[] {
        "Cleaning", "Extraction", "Braces", "Root Canal",
        "Filling", "Whitening", "Crown", "Dentures", "X-Ray"
    });

            scheduleDTP.Value = DateTime.Now;

            // Default time to 8AM
            timePicker.Value = DateTime.Today.AddHours(8);
            timePicker.MinDate = DateTime.Today.AddHours(8);
            timePicker.MaxDate = DateTime.Today.AddHours(16);
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

            // Validate time is between 8AM and 4PM
            int selectedHour = timePicker.Value.Hour;
            if (selectedHour < 8 || selectedHour > 16)
            {
                MessageBox.Show("Please select a time between 8 AM and 4 PM.");
                return;
            }

            try
            {
                int patientId = ((PatientItem)patientCB.SelectedItem).PatientID;

                // Combine date and hour only, minutes set to 0
                DateTime combinedSchedule = new DateTime(
                    scheduleDTP.Value.Year,
                    scheduleDTP.Value.Month,
                    scheduleDTP.Value.Day,
                    timePicker.Value.Hour,
                    0,
                    0
                );

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(
                        "INSERT INTO dbo.Appointments (PatientID, Schedule, Status, Treatment) VALUES (@PatientID, @Schedule, @Status, @Treatment)",
                        conn
                    );
                    cmd.Parameters.AddWithValue("@PatientID", patientId);
                    cmd.Parameters.AddWithValue("@Schedule", combinedSchedule);
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
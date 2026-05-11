using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace clinic
{
    public partial class EditAppointment : Form
    {
        private int _appointmentId;
        private string connectionString = "Server=localhost\\SQLEXPRESS;Database=CLINIC_DB;Trusted_Connection=True;";

        public EditAppointment(int appointmentId, string patientName, DateTime schedule, string status, string treatment)
        {
            InitializeComponent();
            _appointmentId = appointmentId;
            _status = status;
            _treatment = treatment;

            patientNameLabel.Text = patientName;
            scheduleDTP.Value = schedule;
        }

        private string _status;
        private string _treatment;

        private void EditAppointment_Load(object sender, EventArgs e)
        {
            statusCB.Items.AddRange(new string[] {
                "Scheduled", "Cancelled", "Completed"
            });

            treatmentCB.Items.AddRange(new string[] {
                "Cleaning", "Extraction", "Braces", "Root Canal",
                "Filling", "Whitening", "Crown", "Dentures", "X-Ray"
            });

            statusCB.SelectedItem = _status;
            treatmentCB.SelectedItem = _treatment;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
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
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(
                        "UPDATE dbo.Appointments SET Schedule = @Schedule, Status = @Status, Treatment = @Treatment WHERE AppointmentID = @ID",
                        conn
                    );
                    cmd.Parameters.AddWithValue("@Schedule", scheduleDTP.Value);
                    cmd.Parameters.AddWithValue("@Status", statusCB.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@Treatment", treatmentCB.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@ID", _appointmentId);
                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("Appointment updated!");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void statusCB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void patientNameLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
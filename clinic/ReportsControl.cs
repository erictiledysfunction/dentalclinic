using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace clinic
{
    public partial class ReportsControl : UserControl
    {
        public ReportsControl()
        {
            InitializeComponent();
        }

        private void LoadStats()
        {
            string connectionString = "Server=localhost\\SQLEXPRESS;Database=CLINIC_DB;Trusted_Connection=True;";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                // Total Patients
                SqlCommand cmdPatients = new SqlCommand("SELECT COUNT(*) FROM dbo.Patients", conn);
                int totalPatients = (int)cmdPatients.ExecuteScalar();
                lblTotalPatients.Text = totalPatients.ToString();

                // Appointments Today
                SqlCommand cmdToday = new SqlCommand(
                    "SELECT COUNT(*) FROM dbo.Appointments WHERE CAST(Schedule AS DATE) = CAST(GETDATE() AS DATE)", conn
                );
                int appointmentsToday = (int)cmdToday.ExecuteScalar();
                lblAppointmentsToday.Text = appointmentsToday.ToString();

                // Completed Treatments
                SqlCommand cmdCompleted = new SqlCommand(
                    "SELECT COUNT(*) FROM dbo.Appointments WHERE Status = 'Completed'", conn
                );
                int completedTreatments = (int)cmdCompleted.ExecuteScalar();
                lblCompletedTreatments.Text = completedTreatments.ToString();
            }
        }
        private void ReportsControl_Load(object sender, EventArgs e)
        {
            LoadStats();
        }
        private void ReportsControl_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible)
                LoadStats();
        }
    }
}

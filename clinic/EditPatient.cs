using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace clinic
{
    public partial class EditPatient : Form
    {
        private int _patientId;
        private string _gender;
        private string connectionString = "Server=localhost\\SQLEXPRESS;Database=CLINIC_DB;Trusted_Connection=True;";

        public EditPatient(int patientId, string fullName, int age, string gender, string phoneNumber)
        {
            InitializeComponent();
            _patientId = patientId;
            _gender = gender;

            nameTB.Text = fullName;
            ageTB.Text = age.ToString();
            phoneTB.Text = phoneNumber;
        }

        private void EditPatient_Load(object sender, EventArgs e)
        {
            genderCB.Items.Add("Male");
            genderCB.Items.Add("Female");
            genderCB.SelectedItem = _gender;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(nameTB.Text))
            {
                MessageBox.Show("Please enter a name.");
                return;
            }

            if (string.IsNullOrWhiteSpace(ageTB.Text))
            {
                MessageBox.Show("Please enter age.");
                return;
            }

            if (ageTB.Text.Length > 3)
            {
                MessageBox.Show("Age must be at most 3 digits.");
                return;
            }

            if (!int.TryParse(ageTB.Text, out int age))
            {
                MessageBox.Show("Age must be numbers only.");
                return;
            }

            if (genderCB.SelectedItem == null)
            {
                MessageBox.Show("Please select a gender.");
                return;
            }

            if (string.IsNullOrWhiteSpace(phoneTB.Text))
            {
                MessageBox.Show("Please enter a phone number.");
                return;
            }

            if (phoneTB.Text.Length > 15)
            {
                MessageBox.Show("Phone number is too long.");
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(
                        "UPDATE dbo.Patients SET FullName = @Name, Age = @Age, Gender = @Gender, PhoneNumber = @Phone WHERE PatientID = @ID",
                        conn
                    );
                    cmd.Parameters.AddWithValue("@Name", nameTB.Text.Trim());
                    cmd.Parameters.AddWithValue("@Age", age);
                    cmd.Parameters.AddWithValue("@Gender", genderCB.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@Phone", phoneTB.Text.Trim());
                    cmd.Parameters.AddWithValue("@ID", _patientId);
                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("Patient updated!");
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

        private void ageTB_TextChanged(object sender, EventArgs e) { }

        private void nameTB_TextChanged(object sender, EventArgs e) { }
    }
}
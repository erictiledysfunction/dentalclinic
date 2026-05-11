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
    public partial class AddPatient : Form
    {
        public AddPatient()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddPatient_Load(object sender, EventArgs e)
        {
            genderCB.Items.Add("Male");
            genderCB.Items.Add("Female");


        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void addPbtn_Click(object sender, EventArgs e)
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

            string gender = genderCB.SelectedItem.ToString();

            string connectionString = @"Server=localhost\SQLEXPRESS;Database=CLINIC_DB;Trusted_Connection=true;";

            using (SqlConnection eric = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO dbo.Patients (FullName, Age, Gender) VALUES (@Name, @Age, @Gender)";

                SqlCommand cmd = new SqlCommand(query, eric);

                cmd.Parameters.AddWithValue("@Name", nameTB.Text.Trim());
                cmd.Parameters.AddWithValue("@Age", age);
                cmd.Parameters.AddWithValue("@Gender", gender);

                eric.Open();
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Patient Added!");
            this.Close();
        
    }
    }
}

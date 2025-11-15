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

namespace TransportServiceApp
{
    public partial class TransportTypeForm : Form
    {
        private string connectionString = @"Data Source=.;Initial Catalog=TransportServiceDB;Integrated Security=True";

        public TransportTypeForm()
        {
            InitializeComponent();
        }

        private void TransportTypeForm_Load(object sender, EventArgs e)
        {
            this.transportTypeTableAdapter.Fill(this.transportServiceDBDataSet.TransportType);
            lblStatus.Text = $"Завантажено {dataGridView1.RowCount} типів транспорту";
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                this.transportTypeTableAdapter.Update(this.transportServiceDBDataSet.TransportType);
                MessageBox.Show("Дані успішно збережено!", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lblStatus.Text = $"Збережено {dataGridView1.RowCount} типів транспорту";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка при збереженні: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Пошук
        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string searchText = txtSearch.Text.Trim();

                if (string.IsNullOrEmpty(searchText))
                {
                    this.transportTypeTableAdapter.Fill(this.transportServiceDBDataSet.TransportType);
                    return;
                }

                string query = @"SELECT * FROM TransportType 
                                WHERE Name LIKE @SearchText
                                ORDER BY Name";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@SearchText", "%" + searchText + "%");

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dataGridView1.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка при пошуку: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Статистика
        private void btnStats_Click(object sender, EventArgs e)
        {
            try
            {
                string query = @"SELECT COUNT(*) FROM TransportType;";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    var result = command.ExecuteScalar();
                    string stats = $"Статистика типів автотранспорту:\n\n" +
                             $"Всього типів: {result.ToString()}";

                    MessageBox.Show(stats, "Статистика", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Усі
        private void btnShowAll_Click(object sender, EventArgs e)
        {
            try
            {
                this.transportTypeTableAdapter.Fill(this.transportServiceDBDataSet.TransportType);
                dataGridView1.DataSource = this.transportTypeBindingSource;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка при завантаженні даних: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


    }
}
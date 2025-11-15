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
    public partial class ServiceTypeForm : Form
    {
        private string connectionString = @"Data Source=.;Initial Catalog=TransportServiceDB;Integrated Security=True";

        public ServiceTypeForm()
        {
            InitializeComponent();
        }

        private void ServiceTypeForm_Load(object sender, EventArgs e)
        {
            this.serviceTypeTableAdapter.Fill(this.transportServiceDBDataSet.ServiceType);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                this.serviceTypeTableAdapter.Update(this.transportServiceDBDataSet.ServiceType);
                MessageBox.Show("Дані успішно збережено!", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    this.serviceTypeTableAdapter.Fill(this.transportServiceDBDataSet.ServiceType);
                    lblStatus.Text = $"Показано всі {dataGridView1.RowCount} типів послуг";
                    return;
                }

                string query = @"SELECT * FROM ServiceType 
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
                string query = @"SELECT COUNT(*) FROM ServiceType;";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    var result = command.ExecuteScalar();
                    string stats = $"Статистика типів послуг:\n\n" +
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
                this.serviceTypeTableAdapter.Fill(this.transportServiceDBDataSet.ServiceType);
                dataGridView1.DataSource = this.serviceTypeBindingSource;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка при завантаженні даних: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
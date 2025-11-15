using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TransportServiceApp
{
    public partial class TransportForm : Form
    {
        private string connectionString = @"Data Source=(local);Initial Catalog=TransportServiceDB;Integrated Security=True";

        public TransportForm()
        {
            InitializeComponent();
        }

        private void TransportForm_Load(object sender, EventArgs e)
        {
            try
            {
                this.transportTableAdapter.Fill(this.transportServiceDBDataSet.Transport);
                lblStatus.Text = "Дані завантажено успішно";

                cmbSortField.SelectedIndex = 0;
                cmbSortOrder.SelectedIndex = 0;
                cmbStatusFilter.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка завантаження даних: {ex.Message}");
                lblStatus.Text = "Помилка завантаження даних";
            }
        }

        private void toolStripButtonSave_Click(object sender, EventArgs e)
        {
            try
            {
                this.transportTableAdapter.Update(this.transportServiceDBDataSet.Transport);
                lblStatus.Text = "Дані збережено успішно";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка збереження: {ex.Message}");
                lblStatus.Text = "Помилка збереження даних";
            }
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            try
            {
                string field = cmbSortField.SelectedItem?.ToString();
                string order = cmbSortOrder.SelectedItem?.ToString();

                if (string.IsNullOrEmpty(field) || string.IsNullOrEmpty(order))
                {
                    MessageBox.Show("Виберіть поле та порядок сортування");
                    return;
                }

                string query = $@"
                    SELECT * 
                    FROM Transport 
                    ORDER BY {field} {order}";

                ExecuteQueryAndDisplay(query);
                lblStatus.Text = $"Дані відсортовано за {field} {order}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка сортування: {ex.Message}");
                lblStatus.Text = "Помилка сортування";
            }
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(txtMinYear.Text, out int minYear) ||
                    !int.TryParse(txtMaxYear.Text, out int maxYear))
                {
                    MessageBox.Show("Введіть коректні числові значення для років");
                    return;
                }

                string query = @"
                    SELECT * 
                    FROM Transport 
                    WHERE Year BETWEEN @MinYear AND @MaxYear";

                using (var connection = new SqlConnection(connectionString))
                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@MinYear", minYear);
                    command.Parameters.AddWithValue("@MaxYear", maxYear);

                    var adapter = new SqlDataAdapter(command);
                    var table = new DataTable();
                    adapter.Fill(table);
                    dataGridViewTransport.DataSource = table;
                }

                lblStatus.Text = $"Відфільтровано записи з роками від {minYear} до {maxYear}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка фільтрації: {ex.Message}");
                lblStatus.Text = "Помилка фільтрації";
            }
        }

        private void btnFilterStatus_Click(object sender, EventArgs e)
        {
            try
            {
                string status = cmbStatusFilter.SelectedItem?.ToString();

                if (string.IsNullOrEmpty(status))
                {
                    MessageBox.Show("Виберіть статус для фільтрації");
                    return;
                }

                string query;
                if (status == "всі")
                {
                    query = "SELECT * FROM Transport";
                }
                else
                {
                    query = "SELECT * FROM Transport WHERE Status = @Status";
                }

                using (var connection = new SqlConnection(connectionString))
                using (var command = new SqlCommand(query, connection))
                {
                    if (status != "всі")
                    {
                        command.Parameters.AddWithValue("@Status", status);
                    }

                    var adapter = new SqlDataAdapter(command);
                    var table = new DataTable();
                    adapter.Fill(table);
                    dataGridViewTransport.DataSource = table;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка фільтрації за статусом: {ex.Message}");
                lblStatus.Text = "Помилка фільтрації";
            }
        }

        private void btnAvg_Click(object sender, EventArgs e) => CalculateAggregate("AVG", "Середня");
        private void btnMax_Click(object sender, EventArgs e) => CalculateAggregate("MAX", "Максимальна");
        private void btnMin_Click(object sender, EventArgs e) => CalculateAggregate("MIN", "Мінімальна");

        private void CalculateAggregate(string function, string description)
        {
            try
            {
                string query = $"SELECT {function}(Seats) as Result FROM Transport";

                using (var connection = new SqlConnection(connectionString))
                using (var command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    var result = command.ExecuteScalar();
                    lblAggregateResult.Text = $"{description}: {result}";
                }

                lblStatus.Text = $"Розраховано {description.ToLower()} кількість місць";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка обчислення: {ex.Message}");
                lblStatus.Text = "Помилка обчислення";
            }
        }

        private void btnJoin_Click(object sender, EventArgs e)
        {
                string query = @"
                    SELECT t.TransportID, t.LicensePlateNumber, t.Brand, t.Model, t.Year,
                           tt.Name as [Тип транспорту], t.Capacity, t.Seats, 
                           t.FuelType, t.FuelCapacity, t.Status
                    FROM Transport t
                    INNER JOIN TransportType tt ON t.TransportTypeID = tt.TransportTypeID";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    try
                    {
                       
                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            connection.Open();
                            SqlDataAdapter adapter = new SqlDataAdapter(command);
                            DataTable dataTable = new DataTable();

                            adapter.Fill(dataTable);
                            dataGridViewTransport.AutoGenerateColumns = true;
                            dataGridViewTransport.DataSource = dataTable;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Помилка виконання запиту: " + ex.Message, "Помилка",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }


        private void ExecuteQueryAndDisplay(string query)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var adapter = new SqlDataAdapter(query, connection))
            {
                var table = new DataTable();
                adapter.Fill(table);
                dataGridViewTransport.DataSource = table;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                this.transportTableAdapter.Fill(this.transportServiceDBDataSet.Transport);
                dataGridViewTransport.DataSource = this.transportBindingSource;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка при завантаженні даних: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
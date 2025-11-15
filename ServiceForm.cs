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
using System.Xml.XPath;

namespace TransportServiceApp
{
    public partial class ServiceForm : Form
    {
        private string connectionString = @"Data Source=.;Initial Catalog=TransportServiceDB;Integrated Security=True";

        public ServiceForm()
        {
            InitializeComponent();
        }

        private void ServiceForm_Load(object sender, EventArgs e)
        {
            this.serviceTableAdapter.Fill(this.transportServiceDBDataSet.Service);

            // Заповнення комбобоксів
            cmbSortField.Items.AddRange(new string[] { "ServiceID", "StartDate", "EndDate", "Price", "ClientID" });
            cmbSortOrder.Items.AddRange(new string[] { "ASC", "DESC" });
            cmbDateField.Items.AddRange(new string[] { "StartDate", "EndDate" });

            cmbSortField.SelectedIndex = 0;
            cmbSortOrder.SelectedIndex = 0;
            cmbDateField.SelectedIndex = 0;

            // Встановлення дат за замовчуванням
            dtpFrom.Value = DateTime.Now.AddMonths(-6);
            dtpTo.Value = DateTime.Now.AddMonths(6);
            dtpSingleDate.Value = DateTime.Now;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                this.serviceTableAdapter.Update(this.transportServiceDBDataSet.Service);
                MessageBox.Show("Дані успішно збережено!", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка при збереженні: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ФІЛЬТРАЦІЯ ЗА ДАТОЮ
        private void btnFilterDate_Click(object sender, EventArgs e)
        {
            try
            {
                string dateField = cmbDateField.SelectedItem.ToString();
                DateTime fromDate = dtpFrom.Value;
                DateTime toDate = dtpTo.Value;

                string query = $@"SELECT * FROM Service 
                                WHERE {dateField} BETWEEN @FromDate AND @ToDate
                                ORDER BY {dateField}";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@FromDate", fromDate);
                    command.Parameters.AddWithValue("@ToDate", toDate);

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dataGridView1.DataSource = dt;
                    lblStatus.Text = $"Знайдено {dt.Rows.Count} послуг за період {fromDate.ToShortDateString()} - {toDate.ToShortDateString()}";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка при фільтрації: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ФІЛЬТРАЦІЯ ЗА ЦІНОЮ
        private void btnFilterPrice_Click(object sender, EventArgs e)
        {
            try
            {
                decimal minPrice = numMinPrice.Value;
                decimal maxPrice = numMaxPrice.Value;

                if (minPrice > maxPrice)
                {
                    MessageBox.Show("Мінімальна ціна не може бути більшою за максимальну", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string query = @"SELECT * FROM Service 
                               WHERE Price BETWEEN @MinPrice AND @MaxPrice
                               ORDER BY Price";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@MinPrice", minPrice);
                    command.Parameters.AddWithValue("@MaxPrice", maxPrice);

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dataGridView1.DataSource = dt;
                    lblStatus.Text = $"Знайдено {dt.Rows.Count} послуг з ціною від {minPrice} до {maxPrice} грн";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка при фільтрації: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // СТАТИСТИКА ПОСЛУГ
        private void btnServiceStats_Click(object sender, EventArgs e)
        {
            try
            {
                string query = @"SELECT 
                               COUNT(*) as TotalServices,
                               MIN(Price) as MinPrice,
                               MAX(Price) as MaxPrice,
                               AVG(Price) as AvgPrice,
                               SUM(Price) as TotalRevenue,
                               COUNT(DISTINCT ClientID) as UniqueClients,
                               COUNT(DISTINCT DriverID) as AssignedDrivers
                               FROM Service";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        string stats = $"Статистика послуг:\n\n" +
                                     $"Всього послуг: {reader["TotalServices"]}\n" +
                                     $"Мінімальна ціна: {reader["MinPrice"]} грн\n" +
                                     $"Максимальна ціна: {reader["MaxPrice"]} грн\n" +
                                     $"Середня ціна: {Math.Round(Convert.ToDouble(reader["AvgPrice"]), 2)} грн\n" +
                                     $"Загальний дохід: {reader["TotalRevenue"]} грн\n" +
                                     $"Унікальних клієнтів: {reader["UniqueClients"]}\n" +
                                     $"Призначених водіїв: {reader["AssignedDrivers"]}";

                        MessageBox.Show(stats, "Статистика послуг", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка при розрахунку статистики: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ПОСЛУГИ ЗА КОНКРЕТНУ ДАТУ
        private void btnServicesByDate_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime selectedDate = dtpSingleDate.Value;

                string query = @"SELECT * FROM Service 
                               WHERE StartDate <= @SelectedDate AND EndDate >= @SelectedDate
                               ORDER BY StartDate";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@SelectedDate", selectedDate);

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dataGridView1.DataSource = dt;
                    lblStatus.Text = $"Знайдено {dt.Rows.Count} активних послуг на {selectedDate.ToShortDateString()}";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка при пошуку: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ПОШУК ПОСЛУГ ЗА КЛІЄНТОМ
        private void btnFindByClient_Click(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(txtClientID.Text, out int clientID) || clientID <= 0)
                {
                    MessageBox.Show("Введіть коректний ID клієнта", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string query = @"SELECT * FROM Service 
                               WHERE ClientID = @ClientID
                               ORDER BY StartDate DESC";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@ClientID", clientID);

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dataGridView1.DataSource = dt;
                    lblStatus.Text = $"Знайдено {dt.Rows.Count} послуг для клієнта ID: {clientID}";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка при пошуку: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // СОРТУВАННЯ ПОСЛУГ
        private void btnSort_Click(object sender, EventArgs e)
        {
            try
            {
                string field = cmbSortField.SelectedItem.ToString();
                string order = cmbSortOrder.SelectedItem.ToString();

                string query = $@"SELECT * FROM Service 
                                ORDER BY {field} {order}";

                using (SqlConnection connection = new System.Data.SqlClient.SqlConnection(connectionString))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dataGridView1.DataSource = dt;
                    lblStatus.Text = $"Відсортовано за {field} {order}";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка при сортуванні: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ПОКАЗАТИ ВСІ ПОСЛУГИ
        private void btnShowAll_Click(object sender, EventArgs e)
        {
            try
            {
                this.serviceTableAdapter.Fill(this.transportServiceDBDataSet.Service);
                dataGridView1.DataSource = this.serviceBindingSource;
                lblStatus.Text = "Показано всі послуги";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка при завантаженні даних: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ПОСЛУГИ БЕЗ ВОДІЯ
        private void btnServicesWithoutDriver_Click(object sender, EventArgs e)
        {
            try
            {
                string query = @"SELECT * FROM Service 
                               WHERE DriverID IS NULL
                               ORDER BY StartDate";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dataGridView1.DataSource = dt;
                    lblStatus.Text = $"Знайдено {dt.Rows.Count} послуг без призначеного водія";

                    if (dt.Rows.Count > 0)
                    {
                        MessageBox.Show($"Увага! Знайдено {dt.Rows.Count} послуг без призначеного водія!", "Попередження",
                                      MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка при пошуку: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ПОТОЧНІ ПОСЛУГИ
        private void btnCurrentServices_Click(object sender, EventArgs e)
        {
            try
            {
                string query = @"SELECT * FROM Service 
                               WHERE StartDate <= GETDATE() AND EndDate >= GETDATE()
                               ORDER BY EndDate";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dataGridView1.DataSource = dt;
                    lblStatus.Text = $"Знайдено {dt.Rows.Count} поточних послуг";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка при пошуку: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
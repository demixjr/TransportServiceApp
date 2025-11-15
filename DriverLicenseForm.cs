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
    public partial class DriverLicenseForm : Form
    {
        private string connectionString = @"Data Source=.;Initial Catalog=TransportServiceDB;Integrated Security=True;";

        public DriverLicenseForm()
        {
            InitializeComponent();
        }

        private void DriverLicenseForm_Load(object sender, EventArgs e)
        {
            this.driverLicenseTableAdapter.Fill(this.transportServiceDBDataSet.DriverLicense);

            cmbSortField.Items.AddRange(new string[] { "LicenseNumber", "LicenseID", "LicenseCategory", "IssueDate", "ExpiryDate" });
            cmbSortOrder.Items.AddRange(new string[] { "ASC", "DESC" });
            cmbRangeField.Items.AddRange(new string[] { "IssueDate", "ExpiryDate" });
            cmbGroupByField.Items.AddRange(new string[] { "LicenseCategory", "YEAR(IssueDate)" });

            cmbSortField.SelectedIndex = 0;
            cmbSortOrder.SelectedIndex = 0;
            cmbRangeField.SelectedIndex = 0;
            cmbGroupByField.SelectedIndex = 0;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.driverLicenseTableAdapter.Update(this.transportServiceDBDataSet.DriverLicense);
        }

        // Сортування
        private void btnSort_Click(object sender, EventArgs e)
        {
            try
            {
                string field = cmbSortField.SelectedItem.ToString();
                string order = cmbSortOrder.SelectedItem.ToString();

                string query = $@"SELECT * FROM DriverLicense 
                                ORDER BY {field} {order}";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dataGridView1.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка при сортуванні: {ex.Message}");
            }
        }

        // Фільтрація
        private void btnFilterRange_Click(object sender, EventArgs e)
        {
            try
            {
                string field = cmbRangeField.SelectedItem.ToString();
                DateTime fromDate = dtpFrom.Value;
                DateTime toDate = dtpTo.Value;

                string query = $@"SELECT * FROM DriverLicense 
                                WHERE {field} BETWEEN @FromDate AND @ToDate";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@FromDate", fromDate);
                    command.Parameters.AddWithValue("@ToDate", toDate);

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dataGridView1.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка при фільтрації: {ex.Message}");
            }
        }

        // Статистика
        private void btnShowStats_Click(object sender, EventArgs e)
        {
            try
            {
                string query = @"SELECT 
                                COUNT(*) as TotalLicenses,
                                MIN(LicenseID) as MinID,
                                MAX(LicenseID) as MaxID,
                                AVG(CAST(LicenseID as float)) as AvgID
                                FROM DriverLicense";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        string stats = $"Статистика по LicenseID:\n" +
                                     $"Усього посвідчень: {reader["TotalLicenses"]}\n" +
                                     $"Мінімальний ID: {reader["MinID"]}\n" +
                                     $"Максимальний ID: {reader["MaxID"]}";

                        MessageBox.Show(stats, "Статистика");
                    }
                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка: {ex.Message}");
            }
        }

        // Группування
        private void btnGroupBy_Click(object sender, EventArgs e)
        {
            try
            {
                string groupField = cmbGroupByField.SelectedItem.ToString();
                DateTime minIssueDate = dtpGroupMinDate.Value;

                string query = $@"SELECT {groupField} as GroupField, 
                                COUNT(*) as Count 
                                FROM DriverLicense 
                                WHERE IssueDate >= @MinDate 
                                GROUP BY {groupField}";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@MinDate", minIssueDate);

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dataGridView1.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка при группуванні: {ex.Message}");
            }
        }

        // Поєднання з таблицею водіїв
        private void btnJoin_Click(object sender, EventArgs e)
        {
            string query = @"SELECT 
        d.DriverID AS [ID водія],
        d.FirstName AS [Ім'я],
        d.LastName AS [Прізвище], 
        d.Phone AS [Номер телефону],
        dl.LicenseNumber, 
        dl.LicenseCategory,
        dl.IssueDate,
        dl.ExpiryDate
    FROM Driver d 
    INNER JOIN DriverLicense dl ON d.LicenseID = dl.LicenseID";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable dataTable = new DataTable();

                        adapter.Fill(dataTable);
                        dataGridView1.AutoGenerateColumns = true;
                        dataGridView1.DataSource = dataTable;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Помилка виконання запиту: " + ex.Message, "Помилка",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Пошук прострочених водійських посвідчень
        private void btnFindExpired_Click(object sender, EventArgs e)
        {
            try
            {
                string query = @"SELECT * FROM DriverLicense 
                                WHERE ExpiryDate < GETDATE()";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dataGridView1.DataSource = dt;

                    if (dt.Rows.Count > 0)
                    {
                        MessageBox.Show($"Увага! Знайдено {dt.Rows.Count} просрострочених водійських посвідчень!", "Попередження",
                                      MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка: {ex.Message}");
            }
        }

        // Усі записи
        private void btnShowAll_Click(object sender, EventArgs e)
        {
            this.driverLicenseTableAdapter.Fill(this.transportServiceDBDataSet.DriverLicense);
            dataGridView1.DataSource = this.driverLicenseBindingSource;
        }

    }
}
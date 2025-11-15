using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Xml.XPath;

namespace TransportServiceApp
{
    public partial class DriverForm : Form
    {
        private string connectionString = @"Data Source=.;Initial Catalog=TransportServiceDB;Integrated Security=True;";

        public DriverForm()
        {
            InitializeComponent();
        }

        private void DriverForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "transportServiceDBDataSet.DriverLicense". При необходимости она может быть перемещена или удалена.
            this.driverLicenseTableAdapter.Fill(this.transportServiceDBDataSet.DriverLicense);
            this.driverTableAdapter.Fill(this.transportServiceDBDataSet.Driver);
            cmbSortField.SelectedIndex = 0;
            cmbSortOrder.SelectedIndex = 0;
            cmbExperienceFilter.SelectedIndex = 0;
        }

        private void bindingNavigator1_RefreshItems(object sender, EventArgs e) { }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                this.driverTableAdapter.Update(this.transportServiceDBDataSet.Driver);
                MessageBox.Show("Дані водіїв успішно оновлено", "Успіх",
                              MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                if (ex.Number == 547)
                {
                    MessageBox.Show("Не можна видалити водія, оскільки він має пов'язані записи в послугах.",
                                   "Помилка видалення",
                                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.transportServiceDBDataSet.Driver.RejectChanges();
                    this.driverTableAdapter.Fill(this.transportServiceDBDataSet.Driver);
                }
                else
                {
                    MessageBox.Show("Помилка бази даних: " + ex.Message, "Помилка",
                                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Сталася помилка: " + ex.Message, "Помилка",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Пошук водіїв за іменем або прізвищем
        private void btnSearchByName_Click(object sender, EventArgs e)
        {
            string searchText = txtSearchName.Text.Trim();
            if (!string.IsNullOrEmpty(searchText))
            {
                string query = "SELECT * FROM Driver WHERE FirstName LIKE @Search OR LastName LIKE @Search";
                ExecuteQueryAndDisplay(query, new SqlParameter("@Search", $"%{searchText}%"));
            }
        }

        // Фільтрація за стажем водіння
        private void btnFilterByExperience_Click(object sender, EventArgs e)
        {
            string experienceFilter = cmbExperienceFilter.Text;
            if (!string.IsNullOrEmpty(experienceFilter))
            {
                string query = "";
                switch (experienceFilter)
                {
                    case "Менше 2 років":
                        query = "SELECT * FROM Driver WHERE ExperienceYears < 2";
                        break;
                    case "2-5 років":
                        query = "SELECT * FROM Driver WHERE ExperienceYears BETWEEN 2 AND 5";
                        break;
                    case "5-10 років":
                        query = "SELECT * FROM Driver WHERE ExperienceYears BETWEEN 5 AND 10";
                        break;
                    case "Більше 10 років":
                        query = "SELECT * FROM Driver WHERE ExperienceYears > 10";
                        break;
                }
                if (!string.IsNullOrEmpty(query))
                    ExecuteQueryAndDisplay(query);
            }
        }

        // Перевірка водіїв з простроченими посвідченнями
        private void btnCheckExpiredLicenses_Click(object sender, EventArgs e)
        {
            string query = @"SELECT d.DriverID, d.FirstName, d.LastName, d.Phone, 
                           dl.LicenseNumber, dl.ExpiryDate 
                           FROM Driver d 
                           INNER JOIN DriverLicense dl ON d.LicenseID = dl.LicenseID 
                           WHERE dl.ExpiryDate < GETDATE()";
            ExecuteQueryAndDisplay(query);
        }

        // Статистика по категоріях посвідчень
        private void btnLicenseStats_Click(object sender, EventArgs e)
        {
            string query = @"SELECT dl.LicenseCategory, COUNT(*) as DriverCount 
                           FROM Driver d 
                           INNER JOIN DriverLicense dl ON d.LicenseID = dl.LicenseID 
                           GROUP BY dl.LicenseCategory 
                           ORDER BY DriverCount DESC";
            ExecuteQueryAndDisplay(query);
        }

        // Водії без активних послуг (вільні водії)
        private void btnAvailableDrivers_Click(object sender, EventArgs e)
        {
            string query = @"SELECT d.* FROM Driver d 
                           WHERE d.DriverID NOT IN (
                               SELECT DISTINCT DriverID FROM Service 
                               WHERE DriverID IS NOT NULL 
                               AND ServiceStatus = 'активна'
                           )";
            ExecuteQueryAndDisplay(query);
        }

        // Топ водіїв за досвідом
        private void btnTopExperienced_Click(object sender, EventArgs e)
        {
            string query = "SELECT TOP 5 * FROM Driver ORDER BY ExperienceYears DESC";
            ExecuteQueryAndDisplay(query);
        }

        // Сортування за вибраним полем
        private void btnSort_Click(object sender, EventArgs e)
        {
            string field = cmbSortField.Text;
            string order = cmbSortOrder.Text;

            if (!string.IsNullOrEmpty(field) && !string.IsNullOrEmpty(order))
            {
                string query = $"SELECT * FROM Driver ORDER BY {field} {order}";
                ExecuteQueryAndDisplay(query);
            }
        }

        // Середній стаж водіїв
        private void btnAvgExperience_Click(object sender, EventArgs e)
        {
            string query = "SELECT AVG(ExperienceYears) as AverageExperience FROM Driver";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    object result = command.ExecuteScalar();

                    MessageBox.Show($"Середній стаж водіїв: {result} років",
                                  "Статистика",
                                  MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Помилка: " + ex.Message, "Помилка",
                                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        // Скидання фільтрів
        private void btnReset_Click(object sender, EventArgs e)
        {
            this.driverTableAdapter.Fill(this.transportServiceDBDataSet.Driver);
            dataGridView1.DataSource = transportServiceDBDataSet.Driver;
            txtSearchName.Clear();
        }

        //Допоміжний метод для виконання запиту
        private void ExecuteQueryAndDisplay(string query, SqlParameter parameter = null)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        if (parameter != null)
                            command.Parameters.Add(parameter);

                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable dataTable = new DataTable();

                        adapter.Fill(dataTable);
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

        private void btnDriversWithLicenseInfo_Click(object sender, EventArgs e)
        {
            string query = @"SELECT 
        d.DriverID,
        d.FirstName,
        d.LastName, 
        d.Phone,
        d.ExperienceYears,
        dl.LicenseNumber AS DriverLicenseNumber, 
        dl.LicenseCategory AS DriverLicenseCategory,
        dl.IssueDate AS LicenseIssueDate,
        dl.ExpiryDate AS LicenseExpiryDate
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
    }
}

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
    public partial class RouteForm : Form
    {
        private string connectionString = @"Data Source=.;Initial Catalog=TransportServiceDB;Integrated Security=True;";

        public RouteForm()
        {
            InitializeComponent();
        }

        private void RouteForm_Load(object sender, EventArgs e)
        {
            this.routeTableAdapter.Fill(this.transportServiceDBDataSet.Route);

            cmbSortField.Items.AddRange(new string[] { "RouteID", "RouteFrom", "RouteTo", "Distance" });
            cmbSortOrder.Items.AddRange(new string[] { "ASC", "DESC" });
            cmbSearchField.Items.AddRange(new string[] { "RouteFrom", "RouteTo" });

            cmbSortField.SelectedIndex = 0;
            cmbSortOrder.SelectedIndex = 0;
            cmbSearchField.SelectedIndex = 0;

            numMinDistance.Value = 0;
            numMaxDistance.Value = 1000;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                this.routeTableAdapter.Update(this.transportServiceDBDataSet.Route);
                MessageBox.Show("Дані успішно збережено!", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка при збереженні: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Пошук маршрутів за містом
        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string searchField = cmbSearchField.SelectedItem.ToString();
                string searchText = txtSearch.Text.Trim();

                if (string.IsNullOrEmpty(searchText))
                {
                    MessageBox.Show("Введіть текст для пошуку", "Увага", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string query = $@"SELECT * FROM Route 
                                WHERE {searchField} LIKE @SearchText
                                ORDER BY {searchField}";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@SearchText", "%" + searchText + "%");

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dataGridView1.DataSource = dt;
                    lblStatus.Text = $"Знайдено {dt.Rows.Count} маршрутів за запитом '{searchText}'";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка при пошуку: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Фільтрація за дистанцією
        private void btnFilterDistance_Click(object sender, EventArgs e)
        {
            try
            {
                decimal minDistance = numMinDistance.Value;
                decimal maxDistance = numMaxDistance.Value;

                if (minDistance > maxDistance)
                {
                    MessageBox.Show("Мінімальна дистанція не може бути більшою за максимальну", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string query = @"SELECT * FROM Route 
                               WHERE Distance BETWEEN @MinDistance AND @MaxDistance
                               ORDER BY Distance";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@MinDistance", minDistance);
                    command.Parameters.AddWithValue("@MaxDistance", maxDistance);

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dataGridView1.DataSource = dt;
                    lblStatus.Text = $"Знайдено {dt.Rows.Count} маршрутів з дистанцією від {minDistance} до {maxDistance} км";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка при фільтрації: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Статистика маршрутів
        private void btnRouteStats_Click(object sender, EventArgs e)
        {
            try
            {
                string query = @"SELECT 
                               COUNT(*) as TotalRoutes,
                               MIN(Distance) as MinDistance,
                               MAX(Distance) as MaxDistance,
                               AVG(Distance) as AvgDistance,
                               SUM(Distance) as TotalDistance,
                               COUNT(DISTINCT RouteFrom) as UniqueFromCities,
                               COUNT(DISTINCT RouteTo) as UniqueToCities
                               FROM Route";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        string stats = $"Статистика маршрутів:\n\n" +
                                     $"Всього маршрутів: {reader["TotalRoutes"]}\n" +
                                     $"Мінімальна дистанція: {reader["MinDistance"]} км\n" +
                                     $"Максимальна дистанція: {reader["MaxDistance"]} км\n" +
                                     $"Середня дистанція: {Math.Round(Convert.ToDouble(reader["AvgDistance"]), 2)} км\n" +
                                     $"Загальна дистанція: {reader["TotalDistance"]} км\n" +
                                     $"Унікальних міст відправлення: {reader["UniqueFromCities"]}\n" +
                                     $"Унікальних міст прибуття: {reader["UniqueToCities"]}";

                        MessageBox.Show(stats, "Статистика маршрутів", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка при розрахунку статистики: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        //Сортування
        private void btnSort_Click(object sender, EventArgs e)
        {
            try
            {
                string field = cmbSortField.SelectedItem.ToString();
                string order = cmbSortOrder.SelectedItem.ToString();

                string query = $@"SELECT * FROM Route 
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
                MessageBox.Show($"Помилка при сортуванні: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Усі маршрути
        private void btnShowAll_Click(object sender, EventArgs e)
        {
            try
            {
                this.routeTableAdapter.Fill(this.transportServiceDBDataSet.Route);
                dataGridView1.DataSource = this.routeBindingSource;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка при завантаженні даних: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Xml.XPath;

namespace TransportServiceApp
{
    public partial class ClientForm : Form
    {
        private string connectionString = @"Data Source=.;Initial Catalog=TransportServiceDB;Integrated Security=True;";

        public ClientForm()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                this.clientTableAdapter.Update(this.transportServiceDBDataSet.Client);
                MessageBox.Show("Дані успішно оновлено", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                if (ex.Number == 547) // Код помилки конфлікту зовнішнього ключа
                {
                    MessageBox.Show("Не можна видалити клієнта, оскільки він має пов'язані записи в послугах.\n\n" +
                                   "Спочатку видаліть всі послуги цього клієнта.",
                                   "Помилка видалення",
                                   MessageBoxButtons.OK,
                                   MessageBoxIcon.Error);

                    // Відміна змін в DataSet
                    this.transportServiceDBDataSet.Client.RejectChanges();
                    this.clientTableAdapter.Fill(this.transportServiceDBDataSet.Client);
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
        private void ClientForm_Load(object sender, EventArgs e)
        {
            this.clientTableAdapter.Fill(this.transportServiceDBDataSet.Client);
        }

        private void bindingNavigator1_RefreshItems(object sender, EventArgs e) { }

        // Сортування
        private void btnSort_Click(object sender, EventArgs e)
        {
            string field = cmbSortField.Text;
            string order = cmbSortOrder.Text;

            if (!string.IsNullOrEmpty(field) && !string.IsNullOrEmpty(order))
            {
                string query = $"SELECT * FROM Client ORDER BY {field} {order}";
                ExecuteQueryAndDisplay(query);
            }
        }

        // Фільтрація за діапазоном (для ClientID)
        private void btnFilter_Click(object sender, EventArgs e)
        {
            string field = cmbFilterField.Text;
            string minValue = txtMinValue.Text;
            string maxValue = txtMaxValue.Text;

            if (!string.IsNullOrEmpty(field) && !string.IsNullOrEmpty(minValue) && !string.IsNullOrEmpty(maxValue))
            {
                string query = $"SELECT * FROM Client WHERE {field} BETWEEN {minValue} AND {maxValue}";
                ExecuteQueryAndDisplay(query);
            }
        }

        // Агрегатні функції
        private void btnAggregate_Click(object sender, EventArgs e)
        {
            string field = cmbAggregateField.Text;
            string function = cmbAggregateFunction.Text;

            if (!string.IsNullOrEmpty(field) && !string.IsNullOrEmpty(function))
            {
                string query = $"SELECT {function}({field}) as Result FROM Client";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();
                        SqlCommand command = new SqlCommand(query, connection);
                        object result = command.ExecuteScalar();

                        MessageBox.Show($"{function}({field}) = {result}");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Помилка: " + ex.Message);
                    }
                }
            }
        }

        // Допоміжний метод для виконання запиту та відображення результатів
        private void ExecuteQueryAndDisplay(string query)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    ClientDataGrid.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Помилка виконання запиту: " + ex.Message);
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
                string groupField = cmbGroupField.Text;
                string conditionValue = txtConditionValue.Text;

                if (!string.IsNullOrEmpty(groupField) && !string.IsNullOrEmpty(conditionValue))
                {
                    string query = $"SELECT * FROM Client WHERE {groupField} = '{conditionValue}'";
                    ExecuteQueryAndDisplay(query);
                }
        }
    }
}
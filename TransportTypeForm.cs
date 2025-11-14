using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TransportServiceApp
{
    public partial class TransportTypeForm : Form
    {
        public TransportTypeForm()
        {
            InitializeComponent();
        }

        private void TransportTypeForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "transportServiceDBDataSet.TransportType". При необходимости она может быть перемещена или удалена.
            this.transportTypeTableAdapter.Fill(this.transportServiceDBDataSet.TransportType);

        }

        private void bindingNavigator1_RefreshItems(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.transportTypeTableAdapter.Update(this.transportServiceDBDataSet.TransportType);
        }
    }
}

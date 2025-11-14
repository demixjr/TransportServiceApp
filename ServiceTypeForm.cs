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
    public partial class ServiceTypeForm : Form
    {
        public ServiceTypeForm()
        {
            InitializeComponent();
        }

        private void ServiceTypeForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "transportServiceDBDataSet.ServiceType". При необходимости она может быть перемещена или удалена.
            this.serviceTypeTableAdapter.Fill(this.transportServiceDBDataSet.ServiceType);

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.serviceTypeTableAdapter.Update(this.transportServiceDBDataSet.ServiceType);
        }
    }
}

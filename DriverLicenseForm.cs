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
    public partial class DriverLicenseForm : Form
    {
        public DriverLicenseForm()
        {
            InitializeComponent();
        }

        private void DriverLicenseForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "transportServiceDBDataSet.DriverLicense". При необходимости она может быть перемещена или удалена.
            this.driverLicenseTableAdapter.Fill(this.transportServiceDBDataSet.DriverLicense);

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.driverLicenseTableAdapter.Update(this.transportServiceDBDataSet.DriverLicense);
        }
    }
}

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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "transportServiceDBDataSet.TransportType". При необходимости она может быть перемещена или удалена.
            this.transportTypeTableAdapter.Fill(this.transportServiceDBDataSet.TransportType);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "transportServiceDBDataSet.Transport". При необходимости она может быть перемещена или удалена.
            this.transportTableAdapter.Fill(this.transportServiceDBDataSet.Transport);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "transportServiceDBDataSet.TransportType". При необходимости она может быть перемещена или удалена.
            this.transportTypeTableAdapter.Fill(this.transportServiceDBDataSet.TransportType);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "transportServiceDBDataSet.Transport". При необходимости она может быть перемещена или удалена.
            this.transportTableAdapter.Fill(this.transportServiceDBDataSet.Transport);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "transportServiceDBDataSet.ServiceType". При необходимости она может быть перемещена или удалена.
            this.serviceTypeTableAdapter.Fill(this.transportServiceDBDataSet.ServiceType);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "transportServiceDBDataSet.Service". При необходимости она может быть перемещена или удалена.
            this.serviceTableAdapter.Fill(this.transportServiceDBDataSet.Service);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "transportServiceDBDataSet.Route". При необходимости она может быть перемещена или удалена.
            this.routeTableAdapter.Fill(this.transportServiceDBDataSet.Route);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "transportServiceDBDataSet.DriverLicense". При необходимости она может быть перемещена или удалена.
            this.driverLicenseTableAdapter.Fill(this.transportServiceDBDataSet.DriverLicense);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "transportServiceDBDataSet.Driver". При необходимости она может быть перемещена или удалена.
            this.driverTableAdapter.Fill(this.transportServiceDBDataSet.Driver);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "transportServiceDBDataSet.Client". При необходимости она может быть перемещена или удалена.
            this.clientTableAdapter.Fill(this.transportServiceDBDataSet.Client);

        }

        private void водіїToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DriverForm driverForm = new DriverForm();
            driverForm.Show();
        }

        private void клієнтиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClientForm clientForm = new ClientForm();
            clientForm.Show();
        }

        private void маршрутиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RouteForm routeForm = new RouteForm();
            routeForm.Show();
        }

        private void водійськіПосвідченняToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DriverLicenseForm driverLicenseForm = new DriverLicenseForm();
            driverLicenseForm.Show();
        }

        private void послугиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ServiceForm serviceForm = new ServiceForm();
            serviceForm.Show();
        }

        private void типиПослугToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ServiceTypeForm serviceTypeForm = new ServiceTypeForm();
            serviceTypeForm.Show();
        }

        private void автотранспортToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TransportForm transportForm = new TransportForm();
            transportForm.Show();
        }

        private void типиАвтотранспортуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TransportTypeForm transportTypeForm = new TransportTypeForm();
            transportTypeForm.Show();
        }
    }
}

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
    public partial class TransportForm : Form
    {
        public TransportForm()
        {
            InitializeComponent();
        }

        private void TransportForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "transportServiceDBDataSet.Transport". При необходимости она может быть перемещена или удалена.
            this.transportTableAdapter.Fill(this.transportServiceDBDataSet.Transport);

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.transportTableAdapter.Update(this.transportServiceDBDataSet.Transport);
        }
    }
}

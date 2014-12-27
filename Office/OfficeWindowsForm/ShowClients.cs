using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OfficeWindowsForm
{
    public partial class ShowClients : Form
    {
        public ShowClients()
        {
            InitializeComponent();
            dataGridViewSearch.Rows.Add();
        }

        private void buttonShow_Click(object sender, EventArgs e)
        {
            ChangeClient changeClient = new ChangeClient();
            changeClient.Visible = true;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            ChangeClient changeClient = new ChangeClient();
            changeClient.Visible = true;
        }

        private void buttonChange_Click(object sender, EventArgs e)
        {
            ChangeClient changeClient = new ChangeClient();
            changeClient.Visible = true;
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            ChangeClient changeClient = new ChangeClient();
            changeClient.Visible = true;
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {

        }

        private void buttonReturn_Click(object sender, EventArgs e)
        {

        }
    }
}

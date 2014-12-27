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
    public partial class Menu : Form
    {
        ShowSchedule showSchedule;
        ShowClients showClients;
        ShowDocuments showDocuments;
        ShowNumberPolePayment showNumberPolePayment;
        public Menu(string who)
        {
            InitializeComponent();
            if (who == "Юрист")
            {
            }
            else if (who == "Секретарь")
            {
            }
            else if (who == "Бухгалтер")
            {
                
            }
        }

        private void buttonShowListTasks_Click(object sender, EventArgs e)
        {
            if (showSchedule == null || showSchedule.IsDisposed == true)
            {
                showSchedule = new ShowSchedule();
                showSchedule.Visible = true;
                showSchedule.Activate();
            }
            else
            {
                showSchedule.Visible = true;
                showSchedule.Activate();
            }
        }

        private void buttonShowListClients_Click(object sender, EventArgs e)
        {
            if (showClients == null||showClients.IsDisposed==true)
            {
                showClients = new ShowClients();
                showClients.Visible = true;
                showClients.Activate();
            }
            else
            {
                showClients.Activate();
            }
        }

        private void buttonShowListDocuments_Click(object sender, EventArgs e)
        {
            if (showDocuments == null||showDocuments.IsDisposed==true)
            {
                showDocuments = new ShowDocuments();
                showDocuments.Visible = true;
                showDocuments.Activate();
            }
            else
            {
                showDocuments.Activate();
            }
        }

        private void buttonShowNumberPolePayment_Click(object sender, EventArgs e)
        {
            if (showNumberPolePayment == null||showNumberPolePayment.IsDisposed==true)
            {
                showNumberPolePayment = new ShowNumberPolePayment();
                showNumberPolePayment.Visible = true;
                showNumberPolePayment.Activate();
            }
            else
            {
                showNumberPolePayment.Activate();
            }
        }
    }
}

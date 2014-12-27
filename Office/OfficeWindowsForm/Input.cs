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
    public partial class Input : Form
    {
        
        public Input()
        {
            InitializeComponent();
        }

        private void buttonInput_Click(object sender, EventArgs e)
        {
            if (comboBoxWho.SelectedItem.ToString() == comboBoxWho.Items[0].ToString() ||
                comboBoxWho.SelectedItem.ToString() == comboBoxWho.Items[1].ToString() ||
                comboBoxWho.SelectedItem.ToString() == comboBoxWho.Items[2].ToString())
            {
                Menu menu=new Menu(comboBoxWho.SelectedItem.ToString());
                menu.Visible = true;
            }
            else
            {
                MessageBox.Show("Ошибка выбора");
            }
        }
    }
}

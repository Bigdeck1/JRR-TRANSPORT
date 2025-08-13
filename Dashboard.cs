using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jrr_Transport_Management_System
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void payrollToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void vichicleToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void employeeListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Employee_list empListForm = new Employee_list();
            this.Hide();
            empListForm.ShowDialog();
        }
        private void dashboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
 
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }
    }
}

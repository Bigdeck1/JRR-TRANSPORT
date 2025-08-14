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

            emloyeeL.Click += emloyeeL_Click;
            logoutL.Click += logoutL_Click;
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

        private void logoutL_Click(object? sender, EventArgs e)
        {
            this.Close();
        }

        private void emloyeeL_Click(object? sender, EventArgs e)
        {
            Employee_list empListForm = new Employee_list();
            this.Hide();
            empListForm.FormClosed += (s, args) => this.Show(); // when closed, return to dashboard
            empListForm.Show();
        }
        private void dashboardToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}

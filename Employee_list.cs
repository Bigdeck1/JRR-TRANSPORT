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
    public partial class Employee_list : Form
    {
        public Employee_list()
        {
            InitializeComponent();
            dashB.Click += dashB_Click;
            logoutL.Click += logoutL_Click;
        }

        private void Employee_list_Load(object sender, EventArgs e)
        {

        }

        private void dashB_Click(object? sender, EventArgs e)
        {
            Dashboard dashForm = new Dashboard();
            this.Hide(); 
            dashForm.FormClosed += (s, args) => this.Close(); 
            dashForm.Show();
        }

        private void logoutL_Click(object? sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
    }
}

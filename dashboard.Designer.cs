namespace Jrr_Transport_Management_System
{
    partial class Dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            menuStrip1 = new MenuStrip();
            dashboardToolStripMenuItem = new ToolStripMenuItem();
            dashboardToolStripMenuItem1 = new ToolStripMenuItem();
            employeeListToolStripMenuItem = new ToolStripMenuItem();
            attendanceToolStripMenuItem = new ToolStripMenuItem();
            payrollToolStripMenuItem = new ToolStripMenuItem();
            payrollToolStripMenuItem1 = new ToolStripMenuItem();
            payslipGeneratorToolStripMenuItem = new ToolStripMenuItem();
            bookingToolStripMenuItem = new ToolStripMenuItem();
            vichicleToolStripMenuItem = new ToolStripMenuItem();
            reportsToolStripMenuItem = new ToolStripMenuItem();
            payrollSummariesToolStripMenuItem = new ToolStripMenuItem();
            monthlyIncomeToolStripMenuItem = new ToolStripMenuItem();
            employeeAttendanceToolStripMenuItem = new ToolStripMenuItem();
            driverVehicleLogsToolStripMenuItem = new ToolStripMenuItem();
            printableReportsToolStripMenuItem = new ToolStripMenuItem();
            logoutToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.AutoSize = false;
            menuStrip1.BackColor = Color.Transparent;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { dashboardToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1352, 32);
            menuStrip1.Stretch = false;
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.ItemClicked += menuStrip1_ItemClicked;
            // 
            // dashboardToolStripMenuItem
            // 
            dashboardToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { dashboardToolStripMenuItem1, employeeListToolStripMenuItem, attendanceToolStripMenuItem, payrollToolStripMenuItem, bookingToolStripMenuItem, vichicleToolStripMenuItem, reportsToolStripMenuItem, logoutToolStripMenuItem });
            dashboardToolStripMenuItem.Enabled = false;
            dashboardToolStripMenuItem.Image = (Image)resources.GetObject("dashboardToolStripMenuItem.Image");
            dashboardToolStripMenuItem.MergeAction = MergeAction.Insert;
            dashboardToolStripMenuItem.Name = "dashboardToolStripMenuItem";
            dashboardToolStripMenuItem.Size = new Size(34, 28);
            dashboardToolStripMenuItem.Click += dashboardToolStripMenuItem_Click;
            // 
            // dashboardToolStripMenuItem1
            // 
            dashboardToolStripMenuItem1.Name = "dashboardToolStripMenuItem1";
            dashboardToolStripMenuItem1.Size = new Size(224, 26);
            dashboardToolStripMenuItem1.Text = "Dashboard";
            // 
            // employeeListToolStripMenuItem
            // 
            employeeListToolStripMenuItem.Name = "employeeListToolStripMenuItem";
            employeeListToolStripMenuItem.Size = new Size(224, 26);
            employeeListToolStripMenuItem.Text = "Employee List";
            employeeListToolStripMenuItem.Click += employeeListToolStripMenuItem_Click;
            // 
            // attendanceToolStripMenuItem
            // 
            attendanceToolStripMenuItem.Name = "attendanceToolStripMenuItem";
            attendanceToolStripMenuItem.Size = new Size(224, 26);
            attendanceToolStripMenuItem.Text = "Attendance";
            // 
            // payrollToolStripMenuItem
            // 
            payrollToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { payrollToolStripMenuItem1, payslipGeneratorToolStripMenuItem });
            payrollToolStripMenuItem.Name = "payrollToolStripMenuItem";
            payrollToolStripMenuItem.Size = new Size(224, 26);
            payrollToolStripMenuItem.Text = "Salary";
            payrollToolStripMenuItem.Click += payrollToolStripMenuItem_Click;
            // 
            // payrollToolStripMenuItem1
            // 
            payrollToolStripMenuItem1.Name = "payrollToolStripMenuItem1";
            payrollToolStripMenuItem1.Size = new Size(207, 26);
            payrollToolStripMenuItem1.Text = "Payroll";
            // 
            // payslipGeneratorToolStripMenuItem
            // 
            payslipGeneratorToolStripMenuItem.Name = "payslipGeneratorToolStripMenuItem";
            payslipGeneratorToolStripMenuItem.Size = new Size(207, 26);
            payslipGeneratorToolStripMenuItem.Text = "Payslip Generator";
            // 
            // bookingToolStripMenuItem
            // 
            bookingToolStripMenuItem.Name = "bookingToolStripMenuItem";
            bookingToolStripMenuItem.Size = new Size(224, 26);
            bookingToolStripMenuItem.Text = "Booking";
            // 
            // vichicleToolStripMenuItem
            // 
            vichicleToolStripMenuItem.Name = "vichicleToolStripMenuItem";
            vichicleToolStripMenuItem.Size = new Size(224, 26);
            vichicleToolStripMenuItem.Text = "Available";
            vichicleToolStripMenuItem.Click += vichicleToolStripMenuItem_Click;
            // 
            // reportsToolStripMenuItem
            // 
            reportsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { payrollSummariesToolStripMenuItem, monthlyIncomeToolStripMenuItem, employeeAttendanceToolStripMenuItem, driverVehicleLogsToolStripMenuItem, printableReportsToolStripMenuItem });
            reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            reportsToolStripMenuItem.Size = new Size(224, 26);
            reportsToolStripMenuItem.Text = "Reports";
            // 
            // payrollSummariesToolStripMenuItem
            // 
            payrollSummariesToolStripMenuItem.Name = "payrollSummariesToolStripMenuItem";
            payrollSummariesToolStripMenuItem.Size = new Size(238, 26);
            payrollSummariesToolStripMenuItem.Text = "Payroll Summaries";
            // 
            // monthlyIncomeToolStripMenuItem
            // 
            monthlyIncomeToolStripMenuItem.Name = "monthlyIncomeToolStripMenuItem";
            monthlyIncomeToolStripMenuItem.Size = new Size(238, 26);
            monthlyIncomeToolStripMenuItem.Text = "Monthly Income";
            // 
            // employeeAttendanceToolStripMenuItem
            // 
            employeeAttendanceToolStripMenuItem.Name = "employeeAttendanceToolStripMenuItem";
            employeeAttendanceToolStripMenuItem.Size = new Size(238, 26);
            employeeAttendanceToolStripMenuItem.Text = "Employee Attendance";
            // 
            // driverVehicleLogsToolStripMenuItem
            // 
            driverVehicleLogsToolStripMenuItem.Name = "driverVehicleLogsToolStripMenuItem";
            driverVehicleLogsToolStripMenuItem.Size = new Size(238, 26);
            driverVehicleLogsToolStripMenuItem.Text = "Driver/Vehicle logs";
            // 
            // printableReportsToolStripMenuItem
            // 
            printableReportsToolStripMenuItem.Name = "printableReportsToolStripMenuItem";
            printableReportsToolStripMenuItem.Size = new Size(238, 26);
            printableReportsToolStripMenuItem.Text = "Printable reports";
            // 
            // logoutToolStripMenuItem
            // 
            logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            logoutToolStripMenuItem.Size = new Size(224, 26);
            logoutToolStripMenuItem.Text = "Logout";
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1352, 531);
            Controls.Add(menuStrip1);
            Cursor = Cursors.Hand;
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            MainMenuStrip = menuStrip1;
            Name = "Dashboard";
            RightToLeftLayout = true;
            Text = "Dashboard";
            WindowState = FormWindowState.Maximized;
            Load += Dashboard_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem dashboardToolStripMenuItem;
        private ToolStripMenuItem employeeListToolStripMenuItem;
        private ToolStripMenuItem payrollToolStripMenuItem;
        private ToolStripMenuItem vichicleToolStripMenuItem;
        private ToolStripMenuItem dashboardToolStripMenuItem1;
        private ToolStripMenuItem reportsToolStripMenuItem;
        private ToolStripMenuItem attendanceToolStripMenuItem;
        private ToolStripMenuItem payrollToolStripMenuItem1;
        private ToolStripMenuItem payslipGeneratorToolStripMenuItem;
        private ToolStripMenuItem logoutToolStripMenuItem;
        private ToolStripMenuItem payrollSummariesToolStripMenuItem;
        private ToolStripMenuItem monthlyIncomeToolStripMenuItem;
        private ToolStripMenuItem employeeAttendanceToolStripMenuItem;
        private ToolStripMenuItem driverVehicleLogsToolStripMenuItem;
        private ToolStripMenuItem printableReportsToolStripMenuItem;
        private ToolStripMenuItem bookingToolStripMenuItem;
    }
}
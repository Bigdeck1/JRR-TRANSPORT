﻿namespace Jrr_Transport_Management_System
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
            employeeListToolStripMenuItem = new ToolStripMenuItem();
            payrollToolStripMenuItem = new ToolStripMenuItem();
            vichicleToolStripMenuItem = new ToolStripMenuItem();
            dashboardToolStripMenuItem1 = new ToolStripMenuItem();
            reportsToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.ButtonFace;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { dashboardToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1352, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.ItemClicked += menuStrip1_ItemClicked;
            // 
            // dashboardToolStripMenuItem
            // 
            dashboardToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { employeeListToolStripMenuItem, payrollToolStripMenuItem, vichicleToolStripMenuItem, dashboardToolStripMenuItem1, reportsToolStripMenuItem });
            dashboardToolStripMenuItem.Name = "dashboardToolStripMenuItem";
            dashboardToolStripMenuItem.Size = new Size(60, 24);
            dashboardToolStripMenuItem.Text = "Menu";
            // 
            // employeeListToolStripMenuItem
            // 
            employeeListToolStripMenuItem.Name = "employeeListToolStripMenuItem";
            employeeListToolStripMenuItem.Size = new Size(184, 26);
            employeeListToolStripMenuItem.Text = "Employee List";
            // 
            // payrollToolStripMenuItem
            // 
            payrollToolStripMenuItem.Name = "payrollToolStripMenuItem";
            payrollToolStripMenuItem.Size = new Size(184, 26);
            payrollToolStripMenuItem.Text = "Payroll";
            payrollToolStripMenuItem.Click += payrollToolStripMenuItem_Click;
            // 
            // vichicleToolStripMenuItem
            // 
            vichicleToolStripMenuItem.Name = "vichicleToolStripMenuItem";
            vichicleToolStripMenuItem.Size = new Size(184, 26);
            vichicleToolStripMenuItem.Text = "Vehicle";
            // 
            // dashboardToolStripMenuItem1
            // 
            dashboardToolStripMenuItem1.Name = "dashboardToolStripMenuItem1";
            dashboardToolStripMenuItem1.Size = new Size(184, 26);
            dashboardToolStripMenuItem1.Text = "Dashboard";
            // 
            // reportsToolStripMenuItem
            // 
            reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            reportsToolStripMenuItem.Size = new Size(184, 26);
            reportsToolStripMenuItem.Text = "Reports";
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
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem dashboardToolStripMenuItem;
        private ToolStripMenuItem employeeListToolStripMenuItem;
        private ToolStripMenuItem payrollToolStripMenuItem;
        private ToolStripMenuItem vichicleToolStripMenuItem;
        private ToolStripMenuItem dashboardToolStripMenuItem1;
        private ToolStripMenuItem reportsToolStripMenuItem;
    }
}
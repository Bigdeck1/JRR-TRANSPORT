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
            button1 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(427, 246);
            button1.Name = "button1";
            button1.Size = new Size(118, 31);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.d879b042_9903_4ae7_b02b_cd5c3f2a037a_removebg_preview;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(1352, 531);
            Controls.Add(button1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Dashboard";
            Text = "Dashboard";
            WindowState = FormWindowState.Maximized;
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
    }
}
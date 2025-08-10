namespace Jrr_Transport_Management_System
{
    partial class Form2
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
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 52, 61);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(776, 74);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(0, 52, 61);
            panel2.Controls.Add(button5);
            panel2.Controls.Add(button4);
            panel2.Controls.Add(button3);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(button1);
            panel2.Location = new Point(12, 105);
            panel2.Name = "panel2";
            panel2.Size = new Size(183, 333);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ActiveBorder;
            panel3.Location = new Point(213, 105);
            panel3.Name = "panel3";
            panel3.Size = new Size(251, 333);
            panel3.TabIndex = 2;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.ActiveBorder;
            panel4.Location = new Point(484, 105);
            panel4.Name = "panel4";
            panel4.Size = new Size(304, 333);
            panel4.TabIndex = 3;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ControlText;
            button1.Location = new Point(80, 13);
            button1.Name = "button1";
            button1.Size = new Size(91, 47);
            button1.TabIndex = 0;
            button1.Text = "HOME";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            button2.Location = new Point(80, 76);
            button2.Name = "button2";
            button2.Size = new Size(91, 47);
            button2.TabIndex = 1;
            button2.Text = "USER";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            button3.Location = new Point(80, 142);
            button3.Name = "button3";
            button3.Size = new Size(91, 47);
            button3.TabIndex = 2;
            button3.Text = "PAYROLL";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            button4.Location = new Point(80, 206);
            button4.Name = "button4";
            button4.Size = new Size(91, 47);
            button4.TabIndex = 3;
            button4.Text = "REPORTS";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            button5.Location = new Point(80, 271);
            button5.Name = "button5";
            button5.Size = new Size(91, 47);
            button5.TabIndex = 4;
            button5.Text = "SETTING";
            button5.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form2";
            Text = "Form2";
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Button button1;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button2;
    }
}
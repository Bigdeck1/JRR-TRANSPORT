namespace Jrr_Transport_Management_System
{
    partial class login_Form
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login_Form));
            login_Btn = new Button();
            pass_word = new TextBox();
            user_name = new TextBox();
            label1 = new Label();
            label2 = new Label();
            acc_Create = new Label();
            SuspendLayout();
            // 
            // login_Btn
            // 
            login_Btn.BackColor = Color.DeepSkyBlue;
            login_Btn.BackgroundImageLayout = ImageLayout.Center;
            login_Btn.FlatStyle = FlatStyle.Flat;
            login_Btn.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            login_Btn.ForeColor = SystemColors.ButtonFace;
            login_Btn.Location = new Point(933, 728);
            login_Btn.Name = "login_Btn";
            login_Btn.Size = new Size(142, 43);
            login_Btn.TabIndex = 1;
            login_Btn.Text = "Login";
            login_Btn.UseVisualStyleBackColor = false;
            // 
            // pass_word
            // 
            pass_word.Location = new Point(827, 695);
            pass_word.Name = "pass_word";
            pass_word.Size = new Size(354, 27);
            pass_word.TabIndex = 3;
            // 
            // user_name
            // 
            user_name.Location = new Point(827, 662);
            user_name.Name = "user_name";
            user_name.Size = new Size(354, 27);
            user_name.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(739, 665);
            label1.Name = "label1";
            label1.Size = new Size(82, 20);
            label1.TabIndex = 6;
            label1.Text = "Username: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(744, 695);
            label2.Name = "label2";
            label2.Size = new Size(77, 20);
            label2.TabIndex = 8;
            label2.Text = "Password: ";
            // 
            // acc_Create
            // 
            acc_Create.AutoSize = true;
            acc_Create.ForeColor = Color.IndianRed;
            acc_Create.Location = new Point(950, 774);
            acc_Create.Name = "acc_Create";
            acc_Create.Size = new Size(110, 20);
            acc_Create.TabIndex = 10;
            acc_Create.Text = "Create Account";
            // 
            // login_Form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.FromArgb(224, 224, 224);
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(1442, 787);
            Controls.Add(acc_Create);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(user_name);
            Controls.Add(pass_word);
            Controls.Add(login_Btn);
            DoubleBuffered = true;
            ForeColor = SystemColors.ActiveBorder;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "login_Form";
            StartPosition = FormStartPosition.CenterParent;
            Text = "JRR TRANSPORT SERVICE ";
            WindowState = FormWindowState.Maximized;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button login_Btn;
        private TextBox pass_word;
        private TextBox user_name;
        private Label label1;
        private Label label2;
        private Label acc_Create;
    }
}
